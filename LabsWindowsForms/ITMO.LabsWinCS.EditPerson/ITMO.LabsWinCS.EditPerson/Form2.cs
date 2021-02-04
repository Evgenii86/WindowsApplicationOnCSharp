using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.LabsWinCS.EditPerson
{
    public partial class EditPersonForm : Form
    {
        public EditPersonForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.FirstName = this.FirstName; p.LastName = this.LastName; p.Age = this.Age;
            MessageBox.Show("Сотрудник: " + p.ToString());
        }
    }
}
