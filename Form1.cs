using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace signaturochka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //РЕГИСТРАЦИЯ!!!!!!!!!!!!!!
        private void regb_Click(object sender, EventArgs e)
        {


            string login = regbox.Text;
            string password = passwordbox_reg.Text;
            string mail = mailbox.Text;
            string num = numbox.Text;

            //введены ли поля

            //if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) 
            //{
            //    MessageBox.Show("Введите все данные");

            //    return;
            //}
            if (login == "" || password == "" || mail == "" || num == "")
            {
                MessageBox.Show("Введите ВСЕ данные");

                return;
            }


            //создание и проверка на хмльку
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load("data.xml");
            }
            catch (Exception)
            {
                XmlDeclaration newdoc = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
                xml.AppendChild(newdoc);

                XmlElement root = xml.CreateElement("data");
                xml.AppendChild(root);
            }

            //повторы
            XmlNodeList whitelist = xml.SelectNodes("/data/User[translate(Login, 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz')='" + login.ToLower() + "']");
            if (whitelist.Count > 0)
            {
                MessageBox.Show("Логин занят");
                return;
            }

            // Новый юзер
            XmlElement user = xml.CreateElement("User");
            XmlElement reg = xml.CreateElement("Login");
            XmlElement gmail = xml.CreateElement("Mail");
            XmlElement number = xml.CreateElement("Number");
            reg.InnerText = login;
            gmail.InnerText = mail;
            number.InnerText = num;
            user.AppendChild(reg);
            user.AppendChild(gmail);
            user.AppendChild(number);

            XmlElement pass = xml.CreateElement("Password");
            pass.InnerText = password;
            user.AppendChild(pass);

            xml.DocumentElement.AppendChild(user);
            xml.Save("data.xml");

            MessageBox.Show("Вы зарегистрировались");
            regbox.Clear();
            passwordbox_reg.Clear();
            mailbox.Clear();
            numbox.Clear();




            //АВТОРИЗАЦИЯ!!!!!!!!!!!!!!
        }

        private void logb_Click(object sender, EventArgs e)
        {
            string login = loginbox.Text;
            string password = passwordbox_log.Text;


            // введены ли поля х2
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль");
                return;
            }

            //грузим хмл
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load("data.xml");
            }
            catch (Exception)
            {
                MessageBox.Show("Такого аккаунта нет");
                return;
            }

            // поиск челиков в хмльке
            XmlNode userNode = xmlDoc.SelectSingleNode("/data/User[Login='" + login + "' and Password='" + password + "']");
            if (userNode != null)
            {
                Form2 f2 = new Form2();
                f2.Show();
                loginbox.Clear();
                passwordbox_log.Clear();

            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}


   