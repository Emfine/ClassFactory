using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Core
{
    public class IOCHelper
    {
        public static IContainer Container { get; private set; }

        public static void SetContainer(IContainer container)
        {
            Container = container;
        }

        public static TService Resolve<TService>()
        {
            var service = default(TService);
            Container.TryResolve(out service);
            return service;
        }
    }
}