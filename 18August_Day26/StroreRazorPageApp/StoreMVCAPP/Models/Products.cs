using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMVCAPP.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("categ")]
        public int Price { get; set; }
        public int categID { get; set; }
        public Categories? categ { get; set; }
    }
}
