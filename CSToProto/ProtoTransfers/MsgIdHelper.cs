using System;
using System.Collections.Generic;
using System.Reflection;
using Google.Protobuf;
using Newtonsoft.Json;
using Proto.ProtoInterface;

// ReSharper disable PossibleNullReferenceException
namespace Proto.ProtoTransfers
{
    public static class MsgIdExtension
    {
        public static MessageParser GetProtoParser(this int id)
        {
            return IdToParsers[id];
        }

        public static MessageParser GetProtoParser(this Type msgType)
        {
            return TypeToParsers[msgType];
        }

        public static int GetProtoId(this Type msg)
        {
            return TypeToId[msg];
        }

        public static Proto_MsgReqInfo GetReqInfo(this IMessage msg)
        {
            var t = msg.GetType();
            if (!TypeToBaseProperty.ContainsKey(t))
            {
                throw new Exception("MsgBase:" + t.Name);
            }

            var prop = TypeToBaseProperty[t];
            return (Proto_MsgReqInfo)prop.GetValue(msg);
        }

        public static Proto_MsgResInfo GetResInfo(this IMessage msg)
        {
            var t = msg.GetType();
            if (!TypeToBaseProperty.ContainsKey(t))
            {
                throw new Exception("MsgBase:" + t.Name);
            }

            var prop = TypeToBaseProperty[t];
            return (Proto_MsgResInfo)prop.GetValue(msg);
        }

        public static T InitMsgInfo<T>(this T msg) where T : IMessage
        {
            var t = msg.GetType();
            if (!TypeToBaseProperty.ContainsKey(t))
            {
                throw new Exception("Msg Has No BaseProperty:" + t.Name);
            }
            var prop = TypeToBaseProperty[msg.GetType()];
            if (MsgIds.IsReq(t.GetProtoId()))
            {
                prop.SetValue(msg, new Proto_MsgReqInfo());
            }
            else
            {
                prop.SetValue(msg, new Proto_MsgResInfo());
            }
            return msg;
        }

        private static readonly string ReqPropName = 
            typeof(Proto_MsgReqInfo).Name.TrimStartEx(MsgTransferHelper.MsgStart);
        private static readonly string ResPropName =
            typeof(Proto_MsgResInfo).Name.TrimStartEx(MsgTransferHelper.MsgStart);
        private static readonly Dictionary<Type, int> TypeToId = new Dictionary<Type, int>();
        private static readonly Dictionary<int, MessageParser> IdToParsers = 
            new Dictionary<int, MessageParser>();
        private static readonly Dictionary<Type, MessageParser> TypeToParsers =
            new Dictionary<Type, MessageParser>();
        private static readonly Dictionary<Type, PropertyInfo> TypeToBaseProperty = 
            new Dictionary<Type, PropertyInfo>();
        public static void AddMsgData(int id, Type t)
        {
            TypeToId[t] = id;
            var parserType = t.GetField("_parser", BindingFlags.Static | BindingFlags.NonPublic);
            var parser = (MessageParser)parserType.GetValue(null);
            IdToParsers[id] = parser;
            TypeToParsers[t] = parser;

            var prop = t.GetProperty(
                MsgIds.IsReq(id) ? ReqPropName : ResPropName,
                BindingFlags.Public | BindingFlags.Instance);
            TypeToBaseProperty[t] = prop 
                ?? throw new Exception("No MsgBase:" + t.Name);
        }
    }

    public class MsgIdHelper
    {
        public Dictionary<int, MessageParser> IdToTypeDict { get;  } = new Dictionary<int, MessageParser>();
        public Dictionary<string, Type> TcpReq { get;  } = new Dictionary<string, Type>();
        public Dictionary<string, Type> TcpRes { get; } = new Dictionary<string, Type>();
        public Dictionary<string, Type> HttpReq { get;  } = new Dictionary<string, Type>();
        public Dictionary<string, Type> HttpRes { get;  } = new Dictionary<string, Type>();
        public Dictionary<Type, Type> HttpReqToRes { get; } = new Dictionary<Type, Type>();

        public static MsgIdHelper Instance { get; } = new MsgIdHelper();

        private MsgIdHelper()
        {
        }

        public void InitFromJson()
        {
            var jsonStr = ShareHelper.PathHelperImple.ReadFromShareFile("GeneMsgId");
            var msgIdData = JsonConvert.DeserializeObject<MsgIds>(jsonStr);
            InitMsgIdDict(msgIdData);
        }

        private void InitMsgIdDict(MsgIds msgIdData)
        {
            IdToTypeDict.Clear();
            Init(msgIdData.HttpReq, HttpReq, MsgTransferHelper.ReqEnd);
            Init(msgIdData.HttpRes, HttpRes, MsgTransferHelper.ResEnd);
            Init(msgIdData.TcpReq, TcpReq, MsgTransferHelper.ReqEnd);
            Init(msgIdData.TcpRes, TcpRes, MsgTransferHelper.ResEnd);
            HttpReqToRes.Clear();
            foreach (var kv in HttpReq)
            {
                if (!HttpRes.ContainsKey(kv.Key))
                {
                    throw new Exception("HttpResNotExist:" + kv.Key);
                }
                HttpReqToRes[kv.Value] = HttpRes[kv.Key];
            }
        }

        private void Init(
            Dictionary<int, string> idData,
            Dictionary<string, Type> typeDict,
            string msgEnd)
        {
            typeDict.Clear();
            foreach (var kv in idData)
            {
                var t = Type.GetType(kv.Value);
                if (t == null)
                {
                    throw new Exception("interface id err:" + kv.Value);
                }
                MsgIdExtension.AddMsgData(kv.Key, t);
                typeDict[t.Name.TrimEndEx(msgEnd).TrimStartEx(MsgTransferHelper.MsgStart)] = t;
            }
        }
    }
}
