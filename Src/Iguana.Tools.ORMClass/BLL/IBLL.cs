﻿using Iguana.Tools.ORMClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iguana.Tools.ORMClass.BLL
{
    internal interface IBLL
    {
        string GenerateORMClass(GenerateCDT condition);
    }
}