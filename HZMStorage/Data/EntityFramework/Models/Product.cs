using System;
using System.Collections.Generic;

namespace HZMStorage.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string SnNum { get; set; }
        public string BarCode { get; set; }
        public string ProductName { get; set; }
        public double Num { get; set; }
        public double MinNum { get; set; }
        public double MaxNum { get; set; }
        public string UnitNum { get; set; }
        public string UnitName { get; set; }
        public string CateNum { get; set; }
        public string CateName { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public double InPrice { get; set; }
        public double OutPrice { get; set; }
        public double AvgPrice { get; set; }
        public double NetWeight { get; set; }
        public double GrossWeight { get; set; }
        public string Description { get; set; }
        public string PicUrl { get; set; }
        public int IsDelete { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public string StorageNum { get; set; }
        public string DefaultLocal { get; set; }
        public string CusNum { get; set; }
        public string CusName { get; set; }
        public string Display { get; set; }
        public string Remark { get; set; }
    }
}
