namespace Proto.Interfaces.Http.HttpReqs
{
    internal class LoginReq : HttpReqBase
    {
        internal string UserName { set; get; }
        internal string Password { set; get; }
        internal string Version { set; get; }
    }
}
