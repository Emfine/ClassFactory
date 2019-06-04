using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.Model
{
    internal class GenerateCDT
    {
        public string DBType { get; set; }
        public string ConnectionString { get; set; }
        public string Table { get; set; }
        public string Prefix { get; set; }
        public bool ShowMemo { get; set; }
    }
}