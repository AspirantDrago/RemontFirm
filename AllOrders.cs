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
    
    public partial class AllOrders : Form
    {
        private static AllOrders _instance;
        public static AllOrders Instance
        {
            get
            {
                return _instance;
            }
        }

        public AllOrders()
        {
            InitializeComponent();
            _instance = this;
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {
            Data.Instance.Initialize();
            UpdateTableApplications();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            NewOrder form = new NewOrder();
            form.ShowDialog();
        }

        public void UpdateTableApplications()
        {
            applicationsBindingSource.Clear();
            foreach (var app in Data.Instance.applications)
            {
                applicationsBindingSource.Add(app);
            }
        }
    }
}
