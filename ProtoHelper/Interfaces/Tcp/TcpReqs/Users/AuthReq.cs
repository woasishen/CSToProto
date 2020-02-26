namespace Proto.Interfaces.Tcp.TcpReqs.Users
{
    internal class AuthReq : TcpReqBase
    {
        internal string RSAKey { set; get; }
        internal string Token { set; get; }
        internal ulong UserId { set; get; }
    }
}
