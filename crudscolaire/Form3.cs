using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crudscolaire
{
    public partial class Form3 : Form
    {
        schoolEntities context = new schoolEntities();

        public Form3()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            var user = context.users.FirstOrDefault(u => u.login == Username && u.passwd == Password);
            if (user != null)
            {
                Form4 form4 = new Form4();
                form4.Show();
                //this.Hide();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
