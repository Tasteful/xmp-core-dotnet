using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sharpen
{
    public static class Collections
    {
        static readonly IList Empty = new object[0];

        public static IList EmptySet
        {
            get { return Empty; }
        }

        public static bool AddAll<T> (ICollection<T> list, IEnumerable toAdd)
        {
            foreach (T t in toAdd)
                list.Add (t);
            return true;
        }

        public static object[] ToArray (IList list, object[] result)
        {
            for (var i = 0; i < result.Length; i++)
            {
                result[i] = list[i];
            }

            return result;
        }

        public static TU[] ToArray<T,TU> (ICollection<T> list, TU[] res) where T:TU
        {
            if (res.Length < list.Count)
                res = new TU [list.Count];

            var n = 0;
            foreach (var t in list)
                res [n++] = t;

            if (res.Length > list.Count)
                res [list.Count] = default (T);
            return res;
        }

        public static IList EmptyList()
        {
            return EmptySet;
        }

        public static ICollection<T> UnmodifiableCollection<T> (ICollection<T> list)
        {
            return list;
        }

        public static IList UnmodifiableList (IList list)
        {
            return new ReadOnlyCollection<object>(ConvertToGenericList(list));
        }

        public static ICollection<T> UnmodifiableSet<T> (ICollection<T> list)
        {
            return list;
        }

        public static IDictionary UnmodifiableMap(IDictionary dict)
        {
            return dict;
        }

        public static IDictionary<TK,TV> UnmodifiableMap<TK,TV> (IDictionary<TK,TV> dict)
        {
            return dict;
        }

        private static IList<object> ConvertToGenericList(IList list)
        {
            return list.Cast<object>().ToList();
        }
    }
}
