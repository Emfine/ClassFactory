using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iguana.Tools.DAO
{
    public class TableFieldDAO
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public short Length { get; set; }
        /// <summary>
        /// 是否可空
        /// </summary>
        public bool IsNuallable { get; set; }
        /// <summary>
        /// 是否自增
        /// </summary>
        public bool IsIdentity { get; set; }
    }
}