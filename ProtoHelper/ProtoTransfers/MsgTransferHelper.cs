using System;
using System.IO;
using Google.Protobuf;
using Proto.ProtoInterface;

namespace Proto.ProtoTransfers
{
    public static class MsgTransferHelper
    {
        public static Proto_MsgReqInfo NullMsg { get; } = new Proto_MsgReqInfo();
        public const string MsgStart = "Proto_";
        public const string ReqEnd = "Req";
        public const string ResEnd = "Res";
        public const string ManagerEnd = "Manager";

        public const int HttpPort = 18020;
        public const int TcpPort = 18021;
        public const int PhonePort = 18022;

        public const int TestInfoPort = 18031;

        //4位int32，标示tcp消息总长度
        public const int TcpHeadLength = 4;
        //4位int32，tcp msgId 的对应数字
        public const int TcpIdLength = 4;

        public const int TokenLength = 32;

        public static IMessage MjToMsgObj(this byte[] body)
        {
            var msgId = BitConverter.ToInt32(body, 0);
            var msgParser = msgId.GetProtoParser();
            return msgParser.ParseFrom(body, TcpIdLength, body.Length - TcpIdLength);
        }

        public static byte[] MjToBytes(this IMessage msgObj)
        {
            using (var ms = new MemoryStream())
            {
                var msgIdBytes = BitConverter.GetBytes(msgObj.GetType().GetProtoId());
                ms.Write(msgIdBytes, 0, TcpIdLength);
                msgObj.WriteTo(ms);
                return ms.ToArray();
            }
        }
    }
}
