using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.Helper
{
    internal class EnumHelper
    {
        /// <summary>
        /// 获取指定枚举值备注
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string GetEnumDescription<T>(T obj)
        {
            var des = "";
            if (typeof(T).IsEnum)
            {
                var desList = obj.GetType().GetField(obj.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (desList != null && desList.Length > 0)
                {
                    return (desList[0] as DescriptionAttribute).Description;
                }
            }
            return des;
        }
    }
}