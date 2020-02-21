namespace Proto.Interfaces.Tcp.TcpReqs.User
{
    internal class AuthReq : TcpReqBase
    {
        internal string RSAKey { set; get; }
        internal string Token { set; get; }
        internal ulong UserId { set; get; }
    }
}
