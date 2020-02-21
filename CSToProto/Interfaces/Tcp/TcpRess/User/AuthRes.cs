using Google.Protobuf;

namespace Proto.Interfaces.Tcp.TcpRess.User
{
    internal class AuthRes : TcpResBase
    {
        internal ByteString SecretKey { set; get; }
        internal long JoinedGameId { set; get; }
    }
}
