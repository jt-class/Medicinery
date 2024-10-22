﻿namespace Medicinery.Models
{
    public class Categories
    {
        public Categories(short id, string name, short parentId, string image, string credit)
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
            Credit = credit;
        }
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public short ParentId { get; set; }
        private string Credit { get; set; }

        public bool IsMainCategories => ParentId == 0;


    }
}
