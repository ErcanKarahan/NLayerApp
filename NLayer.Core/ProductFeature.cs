using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class ProductFeature : BaseEntity
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public int Hight { get; set; }

        public int widht { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }


    }
}
