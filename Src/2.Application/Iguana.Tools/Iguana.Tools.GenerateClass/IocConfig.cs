using Autofac;
using Iguana.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Iguana.Tools.GenerateClass
{
    public class IOCConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            var assemblyList = GetConfigAssemblyList();
            foreach (var assembly in assemblyList)
            {
                builder.RegisterAssemblyTypes(assembly).Where(t => typeof(IBLL.IBaseBLL).IsAssignableFrom(t)).AsImplementedInterfaces();
                builder.RegisterAssemblyTypes(assembly).Where(t => typeof(BLL.BaseBLL).IsAssignableFrom(t)).AsImplementedInterfaces();
                builder.RegisterAssemblyTypes(assembly).Where(t => typeof(IDAL.IBaseDAL).IsAssignableFrom(t)).AsImplementedInterfaces();
                builder.RegisterAssemblyTypes(assembly).Where(t => typeof(DAL.BaseDAL).IsAssignableFrom(t)).AsImplementedInterfaces();
            }
            var container = builder.Build();
            IOCHelper.SetContainer(container);
        }

        private static List<Assembly> GetConfigAssemblyList()
        {
            var result = new List<Assembly>();
            result.Add(Assembly.Load(Utilities.GetValueFromAppConfigAppSettings("IBLL")));
            result.Add(Assembly.Load(Utilities.GetValueFromAppConfigAppSettings("BLL")));
            result.Add(Assembly.Load(Utilities.GetValueFromAppConfigAppSettings("IDAL")));
            result.Add(Assembly.Load(Utilities.GetValueFromAppConfigAppSettings("DAL")));
            return result;
        }
    }
}