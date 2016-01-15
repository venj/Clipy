using System;

namespace Clipy
{
    public static class StringExtension
    {
        public static string FirstLine(this string self)
        {
            var lines = self.Split(new Char[]{'\n'});
            return lines[0];
        }
    }
}
