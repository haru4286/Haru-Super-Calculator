using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Left = Location.X + 40;
            newForm.Top = Location.Y + 40;
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.ShowDialog();
        }
    }
}
