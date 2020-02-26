using Proto.Interfaces.Entities.Enums;

namespace Proto.Interfaces.Entities
{
    internal class User : IInterface
    {
        internal ulong UserId { set; get; }
        internal string UserName { set; get; }
        internal Gender Gender { set; get; }
    }
}
