using System;

namespace DoclerAutomationFramework.Utils
{
    public static class ParseUrl
    {
        public static string GetAbsolutePath(Uri url)
        {
            return url.AbsolutePath;
        }
    }
}
