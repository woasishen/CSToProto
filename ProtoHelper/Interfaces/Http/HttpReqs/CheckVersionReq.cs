namespace Proto.Interfaces.Http.HttpReqs
{
    internal class CheckVersionReq : HttpReqBase
    {
        internal string CSVersion { set; get; }
        internal string LuaVersion { set; get; }
    }
}
