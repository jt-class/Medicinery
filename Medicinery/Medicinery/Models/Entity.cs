namespace Medicinery.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Image { get; set; }

        public Categories(int id, string name, string image) : this()
        {
            Id = id;
            Name = name;
            Image = image;
        }

        public Categories()
        {

        }
    }
}
