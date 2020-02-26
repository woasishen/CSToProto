using Proto.Interfaces.Entities.Enums;

namespace Proto.Interfaces
{
    internal class MsgResInfo : MsgBase
    {
        internal bool Succeed { set; get; }
        internal ErrorIds ErrorId { set; get; }
        internal string Error { set; get; }
    }
}
