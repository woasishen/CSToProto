namespace Proto.Interfaces
{
    internal class MsgReqInfo : MsgBase
    {
        internal ulong UserId { set; get; }
        internal string Token { set; get; }
    }
}
