using System.Reflection.Metadata.Ecma335;

namespace APIwithSql.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public int IsActive { get; set; }
    }
}
