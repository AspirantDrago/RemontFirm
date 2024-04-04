using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontFirm.Models
{
    public class Applications
    {
        static private int countEntites = 0;

        private int _applicationsID;
        public DateTime DateOfCreation {  get; set; }
        public TypeOfFault TypeOfFault {  get; set; }
        public Equipment Equipment {  get; set; }
        public Priority Priority { get; set; }
        public string Information { get; set; }
        //Client;
        public Status Status { get; set; }

        public string EquipmentTitle => Equipment.Title;
        public string EquipmentInformation => Equipment.Information;
        public string EquipmentSerialNumber => Equipment.SerialNumber;

        public Applications(
            TypeOfFault TypeOfFault,
            Equipment Equipment,
            Priority Priority,
            string Information,
            Status Status
            )
        {
            countEntites++;
            _applicationsID = countEntites;
            this.DateOfCreation = DateTime.Now;
            this.TypeOfFault = TypeOfFault;
            this.Equipment = Equipment;
            this.Priority = Priority;
            this.Information = Information;
            this.Status = Status;
        }
    }
}
