using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sign_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db1=new db();
            sign_up sign_up=new sign_up();
            bool b = false;
            foreach(var item in db1.sign_Ups)
            {
                if(item.user==textBox1.Text)
                {
                    MessageBox.Show("تکراری لطفا اسم دیگری انتخاب کنید");
                    b = true;
                    break;
                }
            }
            if (b==false)
            {
                if (textBox2.Text==textBox4.Text)
                {
                    sign_up.user=textBox1.Text;
                    sign_up.password=textBox2.Text;
                    db1.sign_Ups.Add(sign_up);
                    db1.SaveChanges();

                }
                else
                {
                    MessageBox.Show("پسورد را چک کنید");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2();
            form2.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            log_in log_In = new log_in();
            this.Hide();
            log_In.ShowDialog();
            
        }
    }
}
