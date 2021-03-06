﻿using System;
using System.Collections.Generic;

namespace HZMStorage.Models
{
    public partial class InStorDetail
    {
        public int Id { get; set; }
        public string SnNum { get; set; }
        public string OrderNum { get; set; }
        public string ProductName { get; set; }
        public string BarCode { get; set; }
        public string ProductNum { get; set; }
        public string BatchNum { get; set; }
        public double Num { get; set; }
        public int IsPick { get; set; }
        public double RealNum { get; set; }
        public double InPrice { get; set; }
        public double Amount { get; set; }
        public string ContractOrder { get; set; }
        public DateTime CreateTime { get; set; }
        public string LocalNum { get; set; }
        public string StorageNum { get; set; }
    }
}
