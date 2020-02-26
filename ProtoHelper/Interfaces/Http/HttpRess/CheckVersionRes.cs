namespace Proto.Interfaces.Http.HttpRess
{
    internal class CheckVersionRes : HttpResBase
    {
        internal bool LuaNeedUpdate { set; get; }
        internal bool CSNeedUpdate { set; get; }
        internal string CSVersion { set; get; }
        internal string LuaVersion { set; get; }
    }
}
