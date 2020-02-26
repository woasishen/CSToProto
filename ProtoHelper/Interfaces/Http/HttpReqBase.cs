namespace Proto.Interfaces.Http
{
    internal abstract class HttpReqBase : MsgBase
    {
        internal MsgReqInfo MsgReqInfo { set; get; }
    }
}
