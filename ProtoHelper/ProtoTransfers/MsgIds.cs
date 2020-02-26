using System.Collections.Generic;

namespace Proto.ProtoTransfers
{
    public class MsgIds
    {
        public static bool IsReq(int id)
        {
            return id > 0;
        }

        public static MsgIds Instance { get; } = new MsgIds();

        public Dictionary<int, string> TcpReq = new Dictionary<int, string>();
        public Dictionary<int, string> TcpRes = new Dictionary<int, string>();
        public Dictionary<int, string> HttpReq = new Dictionary<int, string>();
        public Dictionary<int, string> HttpRes = new Dictionary<int, string>();
    }
}
