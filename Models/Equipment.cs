using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontFirm.Models
{
    public class Equipment
    {
        private static int countEntites = 0;

        public int Id { get;}
        public string SerialNumber { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }

        public TypeOfEquipment TypeOfEquipment { get; set; }


        public Equipment(
            TypeOfEquipment TypeOfEquipment,
            string Serial_number,
            string Title,
            string Information
            )
        {
            countEntites++;
            Id = countEntites;
            this.TypeOfEquipment = TypeOfEquipment;
            this.SerialNumber = Serial_number;
            this.Title = Title;
            this.Information = Information;
        }
    }
}
