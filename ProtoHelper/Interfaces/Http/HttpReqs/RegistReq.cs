using Proto.Interfaces.Entities.Enums;

namespace Proto.Interfaces.Http.HttpReqs
{
    internal class RegistReq : HttpReqBase
    {
        internal string UserName { set; get; }
        internal string Password { set; get; }
        internal Gender Gender { set; get; }
    }
}
