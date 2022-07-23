using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HanPerde.Models
{
    public class CurtainProduct
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual CategoryCurtain CategoryCurtain { get; set; }
    }
}
