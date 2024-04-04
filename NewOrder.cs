using RemontFirm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemontFirm
{


    public partial class NewOrder : Form
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            dataBindingSourceTypeOfFault.List.Clear();
            foreach (TypeOfFault obj in Data.Instance.typesOfFault)
            {
                dataBindingSourceTypeOfFault.List.Add(obj);
            }

            priorityBindingSourcePrority.List.Clear();
            foreach (Priority obj in Data.Instance.priorities)
            {
                priorityBindingSourcePrority.List.Add(obj);
            }

            typeOfEquipmentBindingSource.List.Clear();
            foreach (TypeOfEquipment obj in Data.Instance.typesOfEquipment)
            {
                typeOfEquipmentBindingSource.List.Add(obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.Instance.applications.Add(new Applications(
                    listBoxTypesOfFault.SelectedItem as TypeOfFault,
                    new Equipment(
                        listBoxTypeOfEq.SelectedItem as TypeOfEquipment,
                        textBoxEqSerialNumber.Text,
                        textBoxEq.Text,
                        textBoxEqInfo.Text
                    ),
                    listBoxPrority.SelectedItem as Priority,
                    textBoxInfo.Text,
                    Data.Instance.statuses[0]
                ));

            AllOrders.Instance.UpdateTableApplications();
            Hide();
        }
    }
}
