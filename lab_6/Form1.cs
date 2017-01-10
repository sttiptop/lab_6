using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Client : Form
    {
        TcpClient tcp_client = null;

        ASCIIEncoding ae;
        public Client(TcpClient tcp_client)
        {
            this.tcp_client = tcp_client;
            ae = new ASCIIEncoding();
            InitializeComponent();
            // this.ok.Enabled = false;
            this.textInfo.Enabled = false;
            this.textName.Enabled = false;
            this.textSecondName.Enabled = false;
            this.textFirstName.Enabled = false;
            this.textPosition.Enabled = false;

        }
        private void groupBoxActive(object sender, EventArgs e)
        {
            this.textInfo.Enabled = true;
            this.textName.Enabled = true;
            //this.ok.Enabled = true;
            this.textSecondName.Enabled = true;
            this.textFirstName.Enabled = true;
            this.textPosition.Enabled = true;
            radioChecked(sender, e);
        }
        private void radioChecked(object sender, EventArgs e)
        {
            if (search.Checked)
            {
                this.textInfo.Enabled = false;
                this.textName.Enabled = false;
                this.textSecondName.Enabled = false;
                this.textFirstName.Enabled = false;
                //this.textPosition.Enabled = false;
                textInfo.Text += "Введите в поле -" + "\"ДОЛЖНОСТЬ\"" + "задаваемый параметр";
            }
            if (showAll.Checked)
            {
                this.textInfo.Enabled = false;
                this.textName.Enabled = false;
                this.textSecondName.Enabled = false;
                this.textFirstName.Enabled = false;
                this.textPosition.Enabled = false;
               // textInfo.Text += "Введите в поле -" + "\"ДОЛЖНОСТЬ\"" + "задаваемый параметр";
            }
        }
        private void ok_Click(object sender, EventArgs e)
        {
            String command = "";

            int x = textName.Text.Length;
            if (add.Checked)
            {
                command = "add";
                if (false == textPosition.Text.Contains("   ") && textPosition.Text.Length > 0) {
                    x = 1;                  
                }
                else { return; }
                if (false == textFirstName.Text.Contains("   ") && textFirstName.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
                if (false == textSecondName.Text.Contains("   ") && textSecondName.Text.Length > 0)
                {
                    x = 1;
                }else { return; }
                if (false == textName.Text.Contains("   ") && textName.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
            }
            if (delete.Checked)
            {
                command = "delete";
          
                if (false == textPosition.Text.Contains("   ") && textPosition.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
                if (false == textFirstName.Text.Contains("   ") && textFirstName.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
                if (false == textSecondName.Text.Contains("   ") && textSecondName.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
                if (false == textName.Text.Contains("   ") && textName.Text.Length > 0)
                {
                    x = 1;
                }
                else { return; }
            }
            if (showAll.Checked)
            {
                command = "show";
                x = 1;
            }
            if (search.Checked)
            {
                command = "search";
                if (false == textPosition.Text.Contains("   ") | textPosition.Text.Length > 0)
                {
                    x = 1;
                }
            }
            if (x> 0)
            {
                textInfo.Clear();
                NetworkStream ns = tcp_client.GetStream();
                
                

                String res = command + "|" + textPosition.Text + "|" + textFirstName.Text + "|" + textSecondName.Text + "|" + textName.Text+"|";
                byte[] sent = ae.GetBytes(res);
                byte[] recieved = new byte[256];
                ns.Write(sent, 0, sent.Length);
                //Получаем результат выполнения запроса с сервера 
                try
                {
                    ns.Read(recieved, 0, recieved.Length);
                }
                catch (Exception ex)
                {
                    textInfo.Clear();
                    textInfo.Text += ex.ToString();
                }
                //Отображаем полученный результат в клиентском  
                textInfo.Text = ae.GetString(recieved);
                // String status = "=>Command sent:view data";
                //Отображеем служебную информацию в клиентском ListBox 
                //  textInfo.Items.Add(status);


            }
            else
            {
                textInfo.Clear();
                textInfo.Text += "Введите корректные данные";
                return;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
