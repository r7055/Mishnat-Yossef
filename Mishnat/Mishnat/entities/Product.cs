﻿namespace Mishnat.NewFolder
{

    public enum Category
    {
        Food, Housewares,FruteAndVegetable
    }
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public string MadeIn { get; set; }
         public double Price { get; set; }
        public bool IsCold { get; set; }
        public DateTime DateOfLastUpdate { get; set; }
        public int Qty { get; set; }
        //פגום???
    }
}
