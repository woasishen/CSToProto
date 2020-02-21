using Proto.ProtoTransfers;

// ReSharper disable once CheckNamespace
namespace Proto.Interfaces
{
    internal enum ErrorIds
    {
        None = 0,

        [Name("未知错误")]
        UnKnowError = 1,

        [Name("Json解析错误")]
        JsonError,

        [Name("认证失败，重新登录...")]
        AuthFailure,

        [Name("没有MsgId")]
        NoMsgId,

        [Name("无效的MsgId")]
        MsgIdNotValid,

        [Name("版本号不对,请更新版本")]
        VersionErr,

        [Name("用户名已存在")]
        UserNameAlreadyExist,

        [Name("用户名不存在")]
        UserNameNotExist,
    }
}
