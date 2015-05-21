using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace KundenManagementGUI
{
    public partial class FormKunde : Form
    {
        DataTransfer dto = new DataTransfer();
        List<Kunde> lstKunde =new List<Kunde>();
        public FormKunde()
        {
            InitializeComponent();
            
        }

        private void DataBinding()
        {
            textBoxKundenId.DataBindings.Add("Text", lstKunde, "KundenID");
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            lstKunde = dto.getAlleKunden();
            // Bindet Datenquelle an
            comboBoxKunden.DataSource = lstKunde;
            DataBinding();
        }
    }
}
