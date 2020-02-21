using System;
using System.Collections.Generic;
using System.Linq;
using Google.Protobuf;
using Google.Protobuf.Collections;

namespace Proto.ProtoTransfers
{
    public static class ShareExtension
    {
        public static string SubstringEx(this string str, int startIndex, int length)
        {
            if (str.Length <= length)
            {
                return str;
            }
            return str.Substring(startIndex, length);
        }

        public static string TrimStartEx(this string str, string trimStr)
        {
            if (str.StartsWith(trimStr))
            {
                return str.Substring(trimStr.Length, str.Length - trimStr.Length);
            }
            return str;
        }

        public static string TrimEndEx(this string str, string trimStr)
        {
            if (str.EndsWith(trimStr))
            {
                return str.Substring(0, str.Length - trimStr.Length);
            }
            return str;
        }

        public static T RemoveLastEx<T>(this IList<T> list)
        {
            if (!list.Any())
            {
                return default(T);
            }

            var res = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return res;
        }

        public static int CountEx<T>(this RepeatedField<T> list, Func<T, bool> compare)
        {
            var count = 0;
            foreach (var item in list)
            {
                if (compare(item))
                {
                    count++;
                }
            }
            return count;
        }

        public static int LastIndexOfEx<T>(this RepeatedField<T> list, T data)
        {
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (data.Equals(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int IndexOfEx<T>(this RepeatedField<T> list, Func<T, bool> compare)
        {
            for (var i = 0; i < list.Count; i++)
            {
                if (compare(list[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public static int RemoveAllEx<T>(this RepeatedField<T> list, Func<T, bool> compare)
        {
            var count = 0;
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (compare(list[i]))
                {
                    list.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }

        public static void Sort<T>(this RepeatedField<T> list)
        {
            var tmp = list.ToList();
            tmp.Sort();
            list.Clear();
            list.AddRange(tmp);
        }

        public static void Sort<T>(this RepeatedField<T> list, Comparison<T> del)
        {
            var tmp = list.ToList();
            tmp.Sort(del);
            list.Clear();
            list.AddRange(tmp);
        }

        public static string GetUserNameStr(this string str, int len)
        {
            var showLen = 0;
            var realLen = 0;
            for (var i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] > 129)
                {
                    showLen++;
                }

                showLen++;
                if (showLen > len)
                {
                    return str.Substring(str.Length - realLen, realLen);
                }
                realLen++;
            }

            return str;
        }

        private static readonly byte[] NullByte = new byte[0];

        public static T ParseFromEx<T>(
            this MessageParser<T> parsers, 
            byte[] bytes = null) where T : IMessage<T>
        {
            return parsers.ParseFrom(bytes ?? NullByte);
        }

        public static IMessage ParseFromEx(this MessageParser parsers, byte[] bytes = null)
        {
            return parsers.ParseFrom(bytes ?? NullByte);
        }
    }
}
