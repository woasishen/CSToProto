using System;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using Google.Protobuf;

namespace Proto.ProtoTransfers
{
    public static class MsgToTransfer
    {
        public const string NoStream = "user disconnect";

        private static byte[] GeneBytes(IMessage obj,
            ICryptoTransform encryptor = null)
        {
            var msgByte = obj.MjToBytes();
            if (encryptor != null)
            {
                lock (encryptor)
                {
                    ShareHelper.LogImple.LogDesKeyIV(encryptor);
                    ShareHelper.LogImple.LogNetTrsfDetails("GeneByte origin Bytes:" + BitConverter.ToString(msgByte));
                    msgByte = encryptor.TransformFinalBlock(msgByte, 0, msgByte.Length);
                    ShareHelper.LogImple.LogNetTrsfDetails("GeneByte encrypt Bytes:" + BitConverter.ToString(msgByte));
                }
            }
            return msgByte;
        }

        private static byte[] ReadByte(Stream stream, long length,
            ICryptoTransform decryptor = null)
        {
            if (length > int.MaxValue || length < 0)
            {
                return null;
            }
            var buffer = new byte[length];
            var leftLength = buffer.Length;
            var readPos = 0;
            while (leftLength > 0)
            {
                var readLen = stream.Read(buffer, readPos, leftLength);
                if (readLen == 0)
                {
                    ShareHelper.LogImple.LogNetTrsf(NoStream);
                    throw new Exception(NoStream);
                }
                readPos += readLen;
                leftLength -= readLen;
            }

            if (decryptor != null)
            {
                lock (decryptor)
                {
                    ShareHelper.LogImple.LogDesKeyIV(decryptor);
                    ShareHelper.LogImple.LogNetTrsfDetails("GeneByte origin Bytes:" + BitConverter.ToString(buffer));
                    buffer = decryptor.TransformFinalBlock(buffer, 0, buffer.Length);
                    ShareHelper.LogImple.LogNetTrsfDetails("ReadByte decrypt Bytes:" + BitConverter.ToString(buffer));
                }
            }
            return buffer;
        }

        private static void SendNullTcpMsg(Stream tcpStream)
        {
            var bytes = new byte[MsgTransferHelper.TcpHeadLength];
            lock (tcpStream)
            {
                tcpStream.Write(bytes, 0, bytes.Length);
            }
        }

        private static IMessage ReadMsg(Stream stream, long length,
            ICryptoTransform decryptor = null)
        {
            var bytes = ReadByte(stream, length, decryptor);
            return bytes.MjToMsgObj();
        }

        public static IMessage ReadOneHttpMsg(Stream stream, long length,
            ICryptoTransform decryptor = null)
        {
            IMessage getMsg;
            try
            {
                getMsg = ReadMsg(stream, length, decryptor);
            }
            catch (Exception e)
            {
                ShareHelper.LogImple.Log(e);
                throw;
            }
            
            if (getMsg != null)
            {
                ShareHelper.LogImple.LogNetTrsf($"http msg in:{getMsg.GetType().Name}", getMsg);
            }
            stream.Close();
            return getMsg;
        }

        public static IMessage ReadOneTcpMsg(Stream tcpStream,
            ICryptoTransform decryptor = null)
        {
            var headBytes = ReadByte(tcpStream, MsgTransferHelper.TcpHeadLength);
            var bodyLen = BitConverter.ToInt32(headBytes, 0);
            var getMsg = bodyLen == 0
                ? MsgTransferHelper.NullMsg
                : ReadMsg(tcpStream, bodyLen, decryptor);
            if (bodyLen == 0)
            {
                ShareHelper.LogImple.LogNetTrsfDetails("tcp msg in:null");
            }
            else
            {
                ShareHelper.LogImple.LogNetTrsf($"tcp msg in:{getMsg.GetType().Name}", getMsg);
            }
            return getMsg;
        }

        public static void SendHttpMsgServer(HttpListenerContext ctx,
            IMessage obj, ICryptoTransform decryptor = null)
        {
            ShareHelper.LogImple.LogNetTrsf($"http msg out:{obj.GetType().Name}", obj);
            var sendBytes = GeneBytes(obj, decryptor);
            ctx.Response.ContentLength64 = sendBytes.Length;
            ctx.Response.OutputStream.Write(
                sendBytes, 0, sendBytes.Length);
            ctx.Response.Close();
        }

        public static void SendHttpMsgClient(HttpWebRequest ctx,
            IMessage obj, ICryptoTransform decryptor = null)
        {
            ShareHelper.LogImple.LogNetTrsf($"http msg out:{obj.GetType().Name}", obj);
            var sendBytes = GeneBytes(obj, decryptor);
            ctx.ContentLength = sendBytes.Length;
            ctx.GetRequestStream().Write(
                sendBytes, 0, sendBytes.Length);
            ctx.GetRequestStream().Close();
        }

        public static void SendOneTcpMsg(Stream tcpStream, IMessage msgObj,
            ICryptoTransform encryptor = null)
        {
            if (msgObj == MsgTransferHelper.NullMsg)
            {
                ShareHelper.LogImple.LogNetTrsfDetails("tcp msg out:null");
                SendNullTcpMsg(tcpStream);
                return;
            }
            ShareHelper.LogImple.LogNetTrsf($"tcp msg out:{msgObj.GetType().Name}", msgObj);
            var msg = GeneBytes(msgObj, encryptor);
            var headBytes = BitConverter.GetBytes(msg.Length);
            lock (tcpStream)
            {
                tcpStream.Write(headBytes, 0, headBytes.Length);
                tcpStream.Write(msg, 0, msg.Length);
            }
        }
    }
}
