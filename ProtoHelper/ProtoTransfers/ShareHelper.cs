
using System.Security.Cryptography;

// ReSharper disable PossibleNullReferenceException

namespace Proto.ProtoTransfers
{
    public interface ILog
    {
        void LogDesKeyIV(ICryptoTransform desCryptoTransform);
        void Log(params object[] objs);
        void LogErr(params object[] jsonObjs);
        void LogWarn(params object[] jsonObjs);
        void LogNetTrsf(params object[] jsonObjs);
        void LogNetTrsfDetails(params object[] jsonObjs);
    }

    public interface IPathHelper
    {
        string ShareFilePath { get; }
        void SaveToShareFile(string fileName, string saveStr, bool append = false);
        string ReadFromShareFile(string fileName);
    }

    public static class ShareHelper
    {
        public const string FileExtension = ".txt";
        public const string TestInfoPath = "TestInfo";

        public static ILog LogImple { get; private set; }

        public static void InitLog(ILog iLog)
        {
            LogImple = iLog;
        }

        public static IPathHelper PathHelperImple { get; private set; }

        public static void InitPathHelper(IPathHelper iPathHelper)
        {
            PathHelperImple = iPathHelper;
        }
    }
}
