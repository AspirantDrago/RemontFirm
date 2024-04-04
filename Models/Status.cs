using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontFirm.Models
{
    public class Status
    {
        private static int countEntities = 0;

        public int Id { get;}
        public string Name { get; set; }

        public Status(string name)
        {
            countEntities++;
            Id = countEntities;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
