using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace signaturochka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            XElement data1 = XElement.Load("data.xml");
            var result1 = data1.Descendants("Login").Select(t => t.Value);
            foreach (var element in result1)
            {
                login.Text = element;
            }
            
                password.Text = "********";
          
            XElement data3 = XElement.Load("data.xml");
            var result3 = data3.Descendants("Mail").Select(t => t.Value);
            foreach (var element in result3)
            {
                mail.Text = element;
            }
            XElement data4 = XElement.Load("data.xml");
            var result = data4.Descendants("Number").Select(t => t.Value);
            foreach (var element in result)
            {
               number.Text = element;
            }
        }

        private void password_Click(object sender, EventArgs e)
        {
            XElement data2 = XElement.Load("data.xml");
            var result2 = data2.Descendants("Password").Select(t => t.Value);
            foreach (var element in result2)
            {
                password.Text = element;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();

        }
    }
}
