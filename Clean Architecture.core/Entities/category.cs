using Clean_Architecture.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture.core.Entities
{
    public class category:IsoftDeletable
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<product> products { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
