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

        [Name("用户ID不存在")]
        UserIdNotExist,

        [Name("用户名和ID匹配")]
        UserIdNotMatch,

        [Name("密码不匹配")]
        PasswordNotMatch,

        [Name("Token不匹配")]
        TokenNotMatch,

        [Name("已经在房间中了")]
        AlreadyInRoom,

        [Name("房间配置不合法")]
        RoomConfigNotValid,

        [Name("返回的房间不存在")]
        ReturnRoomNotExit,

        [Name("房间不存在")]
        RoomNotExist,

        [Name("并未加入房间")]
        NotInRoomExist,

        [Name("房间已满")]
        RoomIsFull,

        [Name("还没有加入房间")]
        NotInRoom,

        [Name("游戏已经开始,不能随意离开")]
        StartRoomCannotLeave,

        [Name("创建者不能随意离开")]
        OwnerCannotLeave,

        [Name("不是你的出牌回合")]
        NotYourPlayTime,

        [Name("打的牌不存在")]
        PlayItemNotExist,

        [Name("当前是等待出牌阶段")]
        WaitForPlay,

        [Name("您并没有标记碰杠该牌")]
        NotInSignUp,

        [Name("您并没有未发的发财")]
        NoFaToFa,

        [Name("没有足够的牌来杠")]
        NotEnoughForGang,

        [Name("没有能胡牌的名堂")]
        NoCanHuMingTang,

        [Name("胡不掉")]
        CannotHu,

        [Name("已在其他设备登录")]
        OtherDeviceConnected,

        [Name("日志上传成功")]
        LogUploadSucceed,

        [Name("战绩查询失败")]
        GameIdNotExist,

        [Name("金币不够")]
        MoneyNotEnough,

        [Name("已经在匹配了")]
        AlreadyMatching,

        [Name("不在匹配中")]
        NotInMatching,

        [Name("金币不够充值")]
        MoneyNotEnoughToGive,

        [Name("有人金币不足，房间即将提前关闭！")]
        UserMoneyNotEnough,

        [Name("语音通信链接不存在！")]
        PhoneTcpNotExist,
    }
}
