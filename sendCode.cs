using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace BTMS1
{
    public partial class sendCode : Form
    {

        public sendCode()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            newPassword ss = new newPassword();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
