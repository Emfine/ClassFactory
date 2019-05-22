using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.DTO
{
    public class GenerateCDT
    {
        public string DBType { get; set; }
        public string ConnectionString { get; set; }
        public string Table { get; set; }
        public string Prefix { get; set; }
    }
}