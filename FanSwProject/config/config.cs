using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanSwProject
{
    public static class Config
    {
        private static Dictionary<string, Dictionary<string, string>> _pageParams = new Dictionary<string, Dictionary<string, string>>()
    {
        {
            "Page1", new Dictionary<string, string>()
            {
                { "Param1", "Value1" },
                { "Param2", "Value2" }
            }
        },
        {
            "Page2", new Dictionary<string, string>()
            {
                { "ParamA", "ValueA" },
                { "ParamB", "ValueB" }
            }
        }
        // 可以添加更多页面的参数
    };

        public static string GetPageParam(string pageName, string paramName)
        {
            if (_pageParams.TryGetValue(pageName, out Dictionary<string, string> pageParams) &&
                pageParams.TryGetValue(paramName, out string paramValue))
            {
                return paramValue;
            }
            return null;
        }

        public static void SetPageParam(string pageName, string paramName, string paramValue)
        {
            if (_pageParams.TryGetValue(pageName, out Dictionary<string, string> pageParams))
            {
                pageParams[paramName] = paramValue;
            }
            else
            {
                _pageParams[pageName] = new Dictionary<string, string>
            {
                { paramName, paramValue }
            };
            }
        }
    }







}
