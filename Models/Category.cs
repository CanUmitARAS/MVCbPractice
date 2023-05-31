﻿namespace MVCbPractice.Models
{
    public class Category
    {
        public class UrunCategory
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ICollection<Product>? Products { get; set; }
        }

    }
}
