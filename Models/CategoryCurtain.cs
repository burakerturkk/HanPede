using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.Models
{
    public class CategoryCurtain
    {
        [Key]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Kategori Adı Boş Geçilemez.")]
        public string CategoryName { get; set; }
        public bool Active { get; set; }
        public List<CurtainProduct> CurtainProducts { get; set; }
    }
}
