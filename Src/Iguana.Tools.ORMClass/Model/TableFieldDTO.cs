using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.Model
{
    internal class TableFieldDTO
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
        /// 注释
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 长度
        /// </summary>
        public short Length { get; set; }
        /// <summary>
        /// 是否可空
        /// </summary>
        public bool IsNullable { get; set; }
        /// <summary>
        /// 是否自增
        /// </summary>
        public bool IsIdentity { get; set; }
    }
}