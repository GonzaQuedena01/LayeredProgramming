using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntityLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class PEmployee : Form
    {
        EEmployee EntityObject = new EEmployee();
        BEmployee BussinessObject = new BEmployee();

        public PEmployee()
        {
            InitializeComponent();
        }

        private void PEmployee_Load(object sender, EventArgs e)
        {
            ListEmployees();
        }

        void ListEmployees()
        {
            DataTable dt = BussinessObject.ListEmployees();
            dataGridView1.DataSource = dt;
        }
    }
}
