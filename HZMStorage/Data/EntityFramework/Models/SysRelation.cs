﻿using System;
using System.Collections.Generic;

namespace HZMStorage.Models
{
    public partial class SysRelation
    {
        public int Id { get; set; }
        public string RoleNum { get; set; }
        public string ResNum { get; set; }
        public short ResType { get; set; }
    }
}
