using Proto.Interfaces.Entities;

namespace Proto.Interfaces.Http.HttpRess
{
    internal class LoginRes : HttpResBase
    {
        internal ulong UserId { set; get; }
        internal string Token { set; get; }
        internal string IP { set; get; }
    }
}
