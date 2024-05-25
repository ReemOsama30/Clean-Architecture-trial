using Clean_Architecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.core.Entities
{
    public class product:IsoftDeletable
    {

        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public bool IsDeleted { get; set; } = false;



        [ForeignKey("category")]
        public int? categoryID { get; set; }
        public category? category { get; set; }
    }
}
