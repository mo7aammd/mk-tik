using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MakarmTech
{
    public partial class Form1 : Form
    {
        //for triger all textBox having value
        private bool[] textBoxTriger = {false, false, false, false, false};
        //for Moving the Form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            // assign value to variables
            int ip1 = int.Parse(txt_ip1.Text.ToString());
            int ip2 = int.Parse(txt_ip2.Text.ToString());
            int ip3 = int.Parse(txt_ip3.Text.ToString());
            int ip4 = int.Parse(txt_ip4.Text.ToString());
            int prefix = int.Parse(txt_prefix.Text.ToString());

            IpCalc ipCalc = new IpCalc(ip1, ip2, ip3, ip4, prefix);

            lab_networkNO.Text = ipCalc.getNetworkNumber();
            lab_maskNO.Text = ipCalc.getMaskNumber();
            lab_broadcastNO.Text = ipCalc.getBroadcastNumber();
            lab_firstNO.Text = ipCalc.getFirstIp();
            lab_lastNO.Text = ipCalc.getLastIp();
        }
        private void txt_ip1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ip1.Text.ToString()))
            {
                e.Cancel = true;
                txt_ip1.Focus();
                errorProvider1.SetError(lab_error_1, "this vild is emptiy");
            }
            else if (int.Parse(txt_ip1.Text.ToString()) >= 1 && int.Parse(txt_ip1.Text.ToString()) <= 255)
            {
                e.Cancel = false;
                errorProvider1.SetError(lab_error_1, "");
            }
            else
            {
                e.Cancel = true;
                txt_ip1.Focus();
                errorProvider1.SetError(lab_error_1, "enter valid numbers from 1 - 255");
            }
        }

        private void txt_ip2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ip2.Text.ToString()))
            {
                e.Cancel = true;
                txt_ip2.Focus();
                errorProvider1.SetError(lab_error2, "this vild is emptiy");
            }
            else if(int.Parse(txt_ip2.Text.ToString()) >= 1 && int.Parse(txt_ip2.Text.ToString()) <= 255)
            {
                e.Cancel = false;
                errorProvider1.SetError(lab_error2, "");
            }
            else
            {
                e.Cancel = true;
                txt_ip2.Focus();
                errorProvider1.SetError(lab_error2, "enter valid numbers from 1 - 255");
            }
        }

        private void txt_ip3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ip3.Text.ToString()))
            {
                e.Cancel = true;
                txt_ip3.Focus();
                errorProvider1.SetError(lab_error_3, "this vild is emptiy");
            }
            else if (int.Parse(txt_ip3.Text.ToString()) >= 1 && int.Parse(txt_ip3.Text.ToString()) <= 255)
            {
                e.Cancel = false;
                errorProvider1.SetError(lab_error_3, "");
            }
            else
            {
                e.Cancel = true;
                txt_ip3.Focus();
                errorProvider1.SetError(lab_error_3, "enter valid numbers from 1 - 255");
            }
        }

        private void txt_ip4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ip3.Text.ToString()))
            {
                e.Cancel = true;
                txt_ip3.Focus();
                errorProvider1.SetError(lab_error4, "this vild is emptiy");
            }
            else if (int.Parse(txt_ip4.Text.ToString()) >= 1 && int.Parse(txt_ip4.Text.ToString()) <= 255)
            {
                e.Cancel = false;
                errorProvider1.SetError(lab_error4, "");
            }
            else
            {
                e.Cancel = true;
                txt_ip4.Focus();
                errorProvider1.SetError(lab_error4, "enter valid numbers from 1 - 255");
            }
        }

        private void txt_prefix_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_prefix.Text.ToString()))
            {
                e.Cancel = true;
                txt_prefix.Focus();
                errorProvider1.SetError(lab_error_5, "this vild is emptiy");
            }
            else if (int.Parse(txt_prefix.Text.ToString()) >= 1 && int.Parse(txt_prefix.Text.ToString()) <= 31)
            {
                e.Cancel = false;
                errorProvider1.SetError(lab_error_5, "");
            }
            else
            {
                e.Cancel = true;
                txt_prefix.Focus();
                errorProvider1.SetError(lab_error_5, "enter valid numbers from 1 - 31");
            }
        }

        private void txt_ip1_TextChanged(object sender, EventArgs e)
        {
            if (txt_ip1.Text.Trim().Length > 0)
            {
                if (int.Parse(txt_ip1.Text)>=1 && int.Parse(txt_ip1.Text) <= 255)
                {
                    textBoxTriger[0] = true;
                }
                else
                {
                    textBoxTriger[0] = false;
                }
            }
            else
            {
                textBoxTriger[0] = false;
            }

            if (textBoxTriger[0] && textBoxTriger[1] && textBoxTriger[2] && textBoxTriger[3] && textBoxTriger[4])
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }

            
        }

        private void txt_ip2_TextChanged(object sender, EventArgs e)
        {
            if (txt_ip2.Text.Trim().Length > 0)
            {
                if (int.Parse(txt_ip2.Text) >= 1 && int.Parse(txt_ip2.Text) <= 255)
                {
                    textBoxTriger[1] = true;
                }
                else
                {
                    textBoxTriger[1] = false;
                }
            }
            else
            {
                textBoxTriger[1] = false;
            }

            if (textBoxTriger[0] && textBoxTriger[1] && textBoxTriger[2] && textBoxTriger[3] && textBoxTriger[4])
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void txt_ip3_TextChanged(object sender, EventArgs e)
        {
            if (txt_ip3.Text.Trim().Length > 0)
            {
                if (int.Parse(txt_ip3.Text) >= 1 && int.Parse(txt_ip3.Text) <= 255)
                {
                    textBoxTriger[2] = true;
                }
                else
                {
                    textBoxTriger[2] = false;
                }
            }
            else
            {
                textBoxTriger[2] = false;
            }

            if (textBoxTriger[0] && textBoxTriger[1] && textBoxTriger[2] && textBoxTriger[3] && textBoxTriger[4])
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void txt_ip4_TextChanged(object sender, EventArgs e)
        {
            if (txt_ip4.Text.Trim().Length > 0)
            {
                if (int.Parse(txt_ip4.Text) >= 1 && int.Parse(txt_ip4.Text) <= 255)
                {
                    textBoxTriger[3] = true;
                }
                else
                {
                    textBoxTriger[3] = false;
                }
            }
            else
            {
                textBoxTriger[3] = false;
            }

            if (textBoxTriger[0] && textBoxTriger[1] && textBoxTriger[2] && textBoxTriger[3] && textBoxTriger[4])
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void txt_prefix_TextChanged(object sender, EventArgs e)
        {
            if (txt_prefix.Text.Trim().Length > 0)
            {
                if (int.Parse(txt_prefix.Text) >= 1 && int.Parse(txt_prefix.Text) <= 31)
                {
                    textBoxTriger[4] = true;
                }
                else
                {
                    textBoxTriger[4] = false;
                }
            }
            else
            {
                textBoxTriger[4] = false;
            }

            if (textBoxTriger[0] && textBoxTriger[1] && textBoxTriger[2] && textBoxTriger[3] && textBoxTriger[4])
            {
                btn_calc.Enabled = true;
            }
            else
            {
                btn_calc.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure To Exit","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                Close();
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //to disable preventing exit if textBoxs have no value
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            e.Cancel = false;
        }

        //make form movable without border style
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_ip1.Clear();
            txt_ip2.Clear();
            txt_ip3.Clear();
            txt_ip4.Clear();
            txt_prefix.Clear();
        }
    }
}
