﻿using System;
using System.Collections.Generic;

namespace HZMStorage.Models
{
    public partial class Supplier
    {
        public int Id { get; set; }
        public string SupNum { get; set; }
        public string SupName { get; set; }
        public int? SupType { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string CreateUser { get; set; }
        public string Description { get; set; }
        public string ContractNum { get; set; }
        public int IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
