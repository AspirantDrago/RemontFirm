using RemontFirm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontFirm
{
    public class Data
    {
        public List<Priority> priorities = new List<Priority>();
        public List<TypeOfEquipment> typesOfEquipment = new List<TypeOfEquipment>();
        public List<TypeOfFault> typesOfFault = new List<TypeOfFault>();
        public List<Status> statuses = new List<Status>();
        public List<Applications> applications = new List<Applications>();

        private static Data _instance;
        public static Data Instance
        {
            get
            {
                if (_instance == null) { _instance = new Data(); }
                return _instance;
            }
        }

        private Data() { }

        public void Initialize()
        {
            priorities.Add(new Priority("Низкий"));
            priorities.Add(new Priority("Средний"));
            priorities.Add(new Priority("Высокий"));
            priorities.Add(new Priority("Срочный"));

            typesOfEquipment.Add(new TypeOfEquipment("Ноутбуки"));
            typesOfEquipment.Add(new TypeOfEquipment("Смартфоны"));
            typesOfEquipment.Add(new TypeOfEquipment("Телевизоры"));
            typesOfEquipment.Add(new TypeOfEquipment("ПК"));

            typesOfFault.Add(new TypeOfFault("Внешний дефект"));
            typesOfFault.Add(new TypeOfFault("Внутренний дефект"));
            typesOfFault.Add(new TypeOfFault("Обслуживание"));

            statuses.Add(new Status("Принят"));
            statuses.Add(new Status("Обрабатывается"));
            statuses.Add(new Status("В ремонте"));
            statuses.Add(new Status("Готов"));
            statuses.Add(new Status("Завершен"));
            statuses.Add(new Status("Не исправлено"));

            applications.Add(new Applications(
                    typesOfFault[0],
                    new Equipment(
                        typesOfEquipment[0],
                        "0123123AB",
                        "ASUS Zenbook",
                        "Серого цвета"
                    ),
                    priorities[1],
                    "Не включается",
                    statuses[2]
                    ));
            applications.Add(new Applications(
                    typesOfFault[2],
                    new Equipment(
                        typesOfEquipment[3],
                        "519195181",
                        "ACER",
                        "Черный с наклейками"
                    ),
                    priorities[1],
                    "Замена термопасты",
                    statuses[4]
                    ));
            applications.Add(new Applications(
                    typesOfFault[0],
                    new Equipment(
                        typesOfEquipment[1],
                        "GRV59595D",
                        "Samsung",
                        "Черный"
                    ),
                    priorities[3],
                    "Замена экрана",
                    statuses[3]
                    ));
        }
    }
}
