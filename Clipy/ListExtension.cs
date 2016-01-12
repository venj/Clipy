using System;
using System.Collections.Generic;

namespace Clipy
{
    public static class ListExtension
    {
        public static void Each<T>(this List<T> self, int batch, Action<List<T>> action)
        {
            var list = new List<T>();
            int counter = 0;
            self.ForEach((t) => {
                if (counter % batch == 0 && list.Count != 0)
                {
                    action(list);
                    list.Clear();
                }
                list.Add(t);
                counter++;
            });
            action(list);
        }

        public static void Each<T>(this List<T> self, Action<T> action)
        {
            self.ForEach((t) => action(t));
        }
    }
}