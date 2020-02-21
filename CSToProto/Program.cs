using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Proto.Interfaces;
using Proto.Interfaces.Http;
using Proto.Interfaces.Tcp;
using Proto.ProtoInterface;
using Proto.ProtoTransfers;

namespace Proto
{
    static class Program
    {
        private class FileNamePath
        {
            public FileNamePath(string fileName, string filePath)
            {
                FileName = fileName;
                FilePath = filePath;
            }

            public string FileName { get; }
            public string FilePath { get; }
        }

        private const string Version = "syntax = 'proto3';";
        private const string NameSpace = "Proto.ProtoInterface";
        private const string IgnoreTypeEnd = "Base";
        private static readonly string NameSpaceLine =
            $"option csharp_namespace = '{NameSpace}';";
        private static string _protoDir;
        private static string _csDir;
        private static string _msgIdPath;
        private static string AddTypeDir => $"{_protoDir}AddTypes/";
        private static readonly Type BaseType = typeof(IInterface);
        private static readonly Dictionary<Type, FileNamePath> AllAddTypes =
            new Dictionary<Type, FileNamePath>();

        static void Main()
        {
            var dir = new DirectoryInfo(Directory.GetCurrentDirectory());
            for (var i = 0; i < 2; i++)
            {
                dir = dir?.Parent;
            }
            var projDir = dir?.FullName.Replace("\\", "/");
            _protoDir = projDir + "/GeneProto/";
            _csDir = projDir + "/GeneCS/";
            _msgIdPath = projDir + "/GeneMsgId.txt";
            Console.WriteLine(_protoDir);

            GeneMsgId();
            Console.WriteLine(@"----------GeneMsgId Finished----------");

            GeneProtos();
            GeneProtoEx();
            Console.WriteLine(@"----------GeneProto Finished----------");

            GeneProtoWithCmd();
            Console.WriteLine(@"----------GeneCS Finished----------");

            Console.ReadLine();
        }

        private static void GeneProtoEx()
        {
            foreach (var addType in Proto3Struct.GeneAddTypesEx)
            {
                AddType(addType, out _, out _);
            }
        }

        private static void GeneMsgId()
        {
            var httpReqIndex = 1;//>0
            var tcpReqIndex = 10000;//>0

            var httpResIndex = -1;//<0
            var tcpResIndex = -10000;//<0

            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var t in types)
            {
                if (t.Name.EndsWith(IgnoreTypeEnd))
                {
                    continue;
                }

                if (t.IsSubclassOf(typeof(TcpReqBase)))
                {
                    MsgIds.Instance.TcpReq[tcpReqIndex++] = $"{NameSpace}.{GetFileName(t)}";
                    continue;
                }
                if (t.IsSubclassOf(typeof(TcpResBase)))
                {
                    MsgIds.Instance.TcpRes[tcpResIndex--] = $"{NameSpace}.{GetFileName(t)}";
                    continue;
                }
                if (t.IsSubclassOf(typeof(HttpReqBase)))
                {
                    MsgIds.Instance.HttpReq[httpReqIndex++] = $"{NameSpace}.{GetFileName(t)}";
                    continue;
                }
                if (t.IsSubclassOf(typeof(HttpResBase)))
                {
                    MsgIds.Instance.HttpRes[httpResIndex--] = $"{NameSpace}.{GetFileName(t)}";
                    continue;
                }
            }

            using (var fs = new FileStream(_msgIdPath, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(JsonConvert.SerializeObject(MsgIds.Instance));
                }
            }
        }

        private static void GeneProtoWithCmd()
        {
            var rootCS = new DirectoryInfo(_csDir);
            if (rootCS.Exists)
            {
                rootCS.Delete(true);
            }
            var cmdProcess = new Process
            {
                StartInfo =
                {
                    FileName = "cmd.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                },
            };
            cmdProcess.OutputDataReceived += (sender, args) =>
            {
                Console.WriteLine(args.Data);
            };
            cmdProcess.ErrorDataReceived += (sender, args) =>
            {
                Console.WriteLine(args.Data);
            };

            cmdProcess.Start();
            cmdProcess.BeginOutputReadLine();
            cmdProcess.BeginErrorReadLine();
            cmdProcess.StandardInput.WriteLine("cd " + _protoDir);
            GeneProtoCS(_protoDir, cmdProcess);
            cmdProcess.StandardInput.WriteLine("exit");
            cmdProcess.StandardInput.AutoFlush = true;
            cmdProcess.WaitForExit();
            cmdProcess.Close();
        }

        private static void GeneProtoCS(string filePath, Process cmdProcess)
        {
            filePath = filePath.Replace("\\", "/");
            var dirInfo = new DirectoryInfo(filePath);
            if (dirInfo.Exists)
            {
                foreach (var subDir in dirInfo.GetDirectories())
                {
                    GeneProtoCS(subDir.FullName, cmdProcess);
                }

                foreach (var subFile in dirInfo.GetFiles())
                {
                    GeneProtoCS(subFile.FullName, cmdProcess);
                }
                return;
            }

            var fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                var subFilePath = filePath.Replace(_protoDir, string.Empty);
                var targetFilePath = _csDir + Path.GetDirectoryName(subFilePath);
                Directory.CreateDirectory(targetFilePath);
                cmdProcess.StandardInput.WriteLine($"protoc {subFilePath} --csharp_out={targetFilePath}");
            }
        }

        private static void GeneProtos()
        {
            var rootProto = new DirectoryInfo(_protoDir);
            if (rootProto.Exists)
            {
                rootProto.Delete(true);
            }
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                if (type.Namespace == null || BaseType?.Namespace == null)
                {
                    throw new Exception("NameSpaceNull");
                }
                if (!type.Namespace.Contains(BaseType.Namespace))
                {
                    continue;
                }

                if (type.Name.EndsWith(IgnoreTypeEnd))
                {
                    continue;
                }
                if (type.IsEnum)
                {
                    EnumToProto(type);
                    continue;
                }

                if (BaseType.IsAssignableFrom(type) && BaseType != type)
                {
                    ClassToProto(type);
                }
            }
        }

        private static string GetFileName(Type t)
        {
            return $"Proto_{t.Name}";
        }

        private static string GetFilePath(Type t)
        {
            string dirName;
            if (t.IsEnum)
            {
                dirName = "Enums";
            }
            else
            {
                if (!BaseType.IsAssignableFrom(t) || t.Namespace == null)
                {
                    throw new Exception("GetFileNameErr Type:" + t.FullName);
                }
                var dirs = t.Namespace.Split('.').Skip(2);
                dirName = string.Join("/", dirs);
            }

            dirName = $"{_protoDir}{dirName}";
            dirName = dirName.TrimEnd('/');
            Directory.CreateDirectory(dirName);
            return $"{dirName}/{GetFileName(t)}.proto";
        }

        private static void Prepare(Type t, Action<StreamWriter> write)
        {
            var filePath = GetFilePath(t);
            Console.WriteLine($@"Parser:{filePath}");
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(Version);
                    sw.WriteLine(NameSpaceLine);
                    sw.WriteLine();
                    write(sw);
                }
            }
        }

        private static void EnumToProto(Type t)
        {
            Prepare(t, sw =>
            {
                sw.WriteLine($"enum {GetFileName(t)}{{");
                var values = Enum.GetValues(t);
                foreach (var v in values)
                {
                    sw.WriteLine($"\t{v} = {(int)v};");
                }
                sw.WriteLine("}");
            });
        }

        private static void ClassToProto(Type t)
        {
            Prepare(t, sw =>
            {
                var requireList = new HashSet<string>();
                var propList = new List<string>();
                var props = t.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                var index = 1;
                foreach (var prop in props)
                {
                    TryAddType(prop.PropertyType, prop.Name,
                        ref index, ref requireList, ref propList);
                }

                foreach (var require in requireList)
                {
                    if (!string.IsNullOrEmpty(require) && require != GetFilePath(t))
                    {
                        sw.WriteLine($"import '{require.Replace(_protoDir, string.Empty)}';");
                    }
                }
                sw.WriteLine($"message {GetFileName(t)}{{");
                foreach (var prop in propList)
                {
                    sw.WriteLine($"\t{prop};");
                }
                sw.WriteLine("}");
            });
        }

        private static void GeneAddTypeFile(
            List<Type> innerTypes, out string fileName, out string filePath)
        {
            AddType(innerTypes[0], out var subName1, out var subPath1);
            string subName2 = null;
            string subPath2 = null;
            if (innerTypes.Count == 2)
            {
                AddType(innerTypes[1], out subName2, out subPath2);
            }

            fileName = string.IsNullOrEmpty(subName2)
                ? $"_Arr_{subName1}"
                : $"_Map_{subName1}_{subName2}";
            filePath = $"{AddTypeDir}{fileName}.proto";
            Console.WriteLine($@"Parser:{fileName}");
            Directory.CreateDirectory(AddTypeDir);
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(Version);
                    sw.WriteLine(NameSpaceLine);
                    sw.WriteLine();
                    if (!string.IsNullOrEmpty(subPath1))
                    {
                        sw.WriteLine($"import '{subPath1.Replace(_protoDir, string.Empty)}';");
                    }

                    if (!string.IsNullOrEmpty(subPath2))
                    {
                        sw.WriteLine($"import '{subPath2.Replace(_protoDir, string.Empty)}';");
                    }
                    sw.WriteLine($"message {fileName}{{");
                    sw.WriteLine(string.IsNullOrEmpty(subName2)
                        ? $"\t repeated {subName1} {subName1} = 1;"
                        : $"\t map<{subName1},{subName2}> Map_{subName1}{subName2} = 1;");
                    sw.WriteLine("}");
                }
            }


        }

        private static bool IsEnumerableType(Type t)
        {
            return t.IsArray || t.IsGenericType;
        }

        private static void AddNormalType(Type t, out string fileName, out string filePath)
        {
            if (!BaseType.IsAssignableFrom(t) && !t.IsEnum)
            {
                if (!Proto3Struct.AllProto3Struct.ContainsKey(t))
                {
                    throw new Exception("TypeNotSupport Type:" + t.FullName);
                }

                fileName = Proto3Struct.AllProto3Struct[t];
                filePath = null;
                return;
            }
            fileName = GetFileName(t);
            filePath = GetFilePath(t);
        }

        private static List<Type> GetInnerTypes(Type t)
        {
            var innerTypes = new List<Type>();
            if (t.IsArray)
            {
                var fn = t.FullName;
                fn = fn.Substring(0, fn.Length - 2);
                innerTypes.Add(Type.GetType(fn));
            }
            else
            {
                innerTypes.AddRange(t.GenericTypeArguments);
            }
            if (innerTypes.Count < 1 || innerTypes.Count > 2)
            {
                throw new Exception("InnerTypeCountErr Type:" + t.FullName);
            }

            return innerTypes;
        }

        private static void AddIEnumerableType(Type t, out string fileName, out string filePath)
        {
            if (AllAddTypes.ContainsKey(t))
            {
                fileName = AllAddTypes[t].FileName;
                filePath = AllAddTypes[t].FilePath;
                return;
            }

            var innerTypes = GetInnerTypes(t);
            GeneAddTypeFile(innerTypes, out fileName, out filePath);
            AllAddTypes[t] = new FileNamePath(fileName, filePath);
        }

        private static void AddType(Type t, out string fileName, out string filePath)
        {
            if (IsEnumerableType(t))
            {
                AddIEnumerableType(t, out fileName, out filePath);
            }
            else
            {
                AddNormalType(t, out fileName, out filePath);
            }
        }

        private static void TryAddType(Type t, string propName, ref int index,
            ref HashSet<string> requireList,
            ref List<string> propList)
        {
            if (!IsEnumerableType(t))
            {
                AddNormalType(t, out var fileName, out var filePath);
                requireList.Add(filePath);
                propList.Add($"{fileName} {propName} = {index++}");
            }
            else
            {
                var innerTypes = GetInnerTypes(t);
                var innerType1 = innerTypes[0];
                AddType(innerType1, out var fileName1, out var filePath1);
                requireList.Add(filePath1);
                if (innerTypes.Count == 1)
                {
                    propList.Add($"repeated {fileName1} {propName} = {index++}");
                }
                else
                {
                    var innerType2 = innerTypes[1];
                    AddType(innerType2, out var fileName2, out var filePath2);
                    requireList.Add(filePath2);
                    propList.Add($"map<{fileName1},{fileName2}> {propName} = {index++}");
                }
            }
        }
    }
}
