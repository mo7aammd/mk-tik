namespace MakarmTech
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_networkNO = new System.Windows.Forms.Label();
            this.lab_maskNO = new System.Windows.Forms.Label();
            this.lab_broadcastNO = new System.Windows.Forms.Label();
            this.lab_firstNO = new System.Windows.Forms.Label();
            this.lab_lastNO = new System.Windows.Forms.Label();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_ip1 = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lab_error_1 = new System.Windows.Forms.Label();
            this.txt_ip2 = new System.Windows.Forms.MaskedTextBox();
            this.txt_ip3 = new System.Windows.Forms.MaskedTextBox();
            this.txt_ip4 = new System.Windows.Forms.MaskedTextBox();
            this.txt_prefix = new System.Windows.Forms.MaskedTextBox();
            this.lab_error2 = new System.Windows.Forms.Label();
            this.lab_error_3 = new System.Windows.Forms.Label();
            this.lab_error4 = new System.Windows.Forms.Label();
            this.lab_error_5 = new System.Windows.Forms.Label();
            this.btn_exitP = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 253);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(31, 318);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Network Number : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(31, 350);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mask Number : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(31, 382);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Broadcast Number : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(31, 414);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "First IP Number :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(31, 445);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Last IP Number : ";
            // 
            // lab_networkNO
            // 
            this.lab_networkNO.AutoSize = true;
            this.lab_networkNO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lab_networkNO.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_networkNO.Location = new System.Drawing.Point(184, 318);
            this.lab_networkNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_networkNO.Name = "lab_networkNO";
            this.lab_networkNO.Size = new System.Drawing.Size(12, 17);
            this.lab_networkNO.TabIndex = 0;
            this.lab_networkNO.Text = " ";
            // 
            // lab_maskNO
            // 
            this.lab_maskNO.AutoSize = true;
            this.lab_maskNO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lab_maskNO.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_maskNO.Location = new System.Drawing.Point(184, 350);
            this.lab_maskNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_maskNO.Name = "lab_maskNO";
            this.lab_maskNO.Size = new System.Drawing.Size(0, 17);
            this.lab_maskNO.TabIndex = 0;
            // 
            // lab_broadcastNO
            // 
            this.lab_broadcastNO.AutoSize = true;
            this.lab_broadcastNO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lab_broadcastNO.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_broadcastNO.Location = new System.Drawing.Point(184, 382);
            this.lab_broadcastNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_broadcastNO.Name = "lab_broadcastNO";
            this.lab_broadcastNO.Size = new System.Drawing.Size(0, 17);
            this.lab_broadcastNO.TabIndex = 0;
            // 
            // lab_firstNO
            // 
            this.lab_firstNO.AutoSize = true;
            this.lab_firstNO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lab_firstNO.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_firstNO.Location = new System.Drawing.Point(184, 414);
            this.lab_firstNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_firstNO.Name = "lab_firstNO";
            this.lab_firstNO.Size = new System.Drawing.Size(0, 17);
            this.lab_firstNO.TabIndex = 0;
            // 
            // lab_lastNO
            // 
            this.lab_lastNO.AutoSize = true;
            this.lab_lastNO.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lab_lastNO.ForeColor = System.Drawing.SystemColors.Window;
            this.lab_lastNO.Location = new System.Drawing.Point(184, 445);
            this.lab_lastNO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_lastNO.Name = "lab_lastNO";
            this.lab_lastNO.Size = new System.Drawing.Size(0, 17);
            this.lab_lastNO.TabIndex = 0;
            // 
            // btn_calc
            // 
            this.btn_calc.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_calc.Enabled = false;
            this.btn_calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calc.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_calc.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_calc.Location = new System.Drawing.Point(163, 500);
            this.btn_calc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(74, 28);
            this.btn_calc.TabIndex = 6;
            this.btn_calc.Text = "Caculate";
            this.btn_calc.UseVisualStyleBackColor = false;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // txt_ip1
            // 
            this.txt_ip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ip1.Location = new System.Drawing.Point(86, 246);
            this.txt_ip1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ip1.Mask = "000";
            this.txt_ip1.Name = "txt_ip1";
            this.txt_ip1.Size = new System.Drawing.Size(57, 27);
            this.txt_ip1.TabIndex = 1;
            this.txt_ip1.TextChanged += new System.EventHandler(this.txt_ip1_TextChanged);
            this.txt_ip1.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ip1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lab_error_1
            // 
            this.lab_error_1.AutoSize = true;
            this.lab_error_1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lab_error_1.Location = new System.Drawing.Point(122, 250);
            this.lab_error_1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_error_1.Name = "lab_error_1";
            this.lab_error_1.Size = new System.Drawing.Size(0, 19);
            this.lab_error_1.TabIndex = 7;
            // 
            // txt_ip2
            // 
            this.txt_ip2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ip2.Location = new System.Drawing.Point(158, 246);
            this.txt_ip2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ip2.Mask = "000";
            this.txt_ip2.Name = "txt_ip2";
            this.txt_ip2.Size = new System.Drawing.Size(57, 27);
            this.txt_ip2.TabIndex = 2;
            this.txt_ip2.TextChanged += new System.EventHandler(this.txt_ip2_TextChanged);
            this.txt_ip2.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ip2_Validating);
            // 
            // txt_ip3
            // 
            this.txt_ip3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ip3.Location = new System.Drawing.Point(230, 246);
            this.txt_ip3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ip3.Mask = "000";
            this.txt_ip3.Name = "txt_ip3";
            this.txt_ip3.Size = new System.Drawing.Size(57, 27);
            this.txt_ip3.TabIndex = 3;
            this.txt_ip3.TextChanged += new System.EventHandler(this.txt_ip3_TextChanged);
            this.txt_ip3.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ip3_Validating);
            // 
            // txt_ip4
            // 
            this.txt_ip4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_ip4.Location = new System.Drawing.Point(302, 246);
            this.txt_ip4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_ip4.Mask = "000";
            this.txt_ip4.Name = "txt_ip4";
            this.txt_ip4.Size = new System.Drawing.Size(57, 27);
            this.txt_ip4.TabIndex = 4;
            this.txt_ip4.TextChanged += new System.EventHandler(this.txt_ip4_TextChanged);
            this.txt_ip4.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ip4_Validating);
            // 
            // txt_prefix
            // 
            this.txt_prefix.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_prefix.Location = new System.Drawing.Point(380, 246);
            this.txt_prefix.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txt_prefix.Mask = "00";
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(46, 27);
            this.txt_prefix.TabIndex = 5;
            this.txt_prefix.TextChanged += new System.EventHandler(this.txt_prefix_TextChanged);
            this.txt_prefix.Validating += new System.ComponentModel.CancelEventHandler(this.txt_prefix_Validating);
            // 
            // lab_error2
            // 
            this.lab_error2.AutoSize = true;
            this.lab_error2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lab_error2.Location = new System.Drawing.Point(192, 250);
            this.lab_error2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_error2.Name = "lab_error2";
            this.lab_error2.Size = new System.Drawing.Size(0, 19);
            this.lab_error2.TabIndex = 9;
            // 
            // lab_error_3
            // 
            this.lab_error_3.AutoSize = true;
            this.lab_error_3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lab_error_3.Location = new System.Drawing.Point(268, 250);
            this.lab_error_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_error_3.Name = "lab_error_3";
            this.lab_error_3.Size = new System.Drawing.Size(0, 19);
            this.lab_error_3.TabIndex = 9;
            // 
            // lab_error4
            // 
            this.lab_error4.AutoSize = true;
            this.lab_error4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lab_error4.Location = new System.Drawing.Point(340, 250);
            this.lab_error4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_error4.Name = "lab_error4";
            this.lab_error4.Size = new System.Drawing.Size(0, 19);
            this.lab_error4.TabIndex = 9;
            // 
            // lab_error_5
            // 
            this.lab_error_5.AutoSize = true;
            this.lab_error_5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.lab_error_5.Location = new System.Drawing.Point(407, 250);
            this.lab_error_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lab_error_5.Name = "lab_error_5";
            this.lab_error_5.Size = new System.Drawing.Size(0, 19);
            this.lab_error_5.TabIndex = 9;
            // 
            // btn_exitP
            // 
            this.btn_exitP.BackColor = System.Drawing.Color.Red;
            this.btn_exitP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exitP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_exitP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exitP.Location = new System.Drawing.Point(449, 2);
            this.btn_exitP.Name = "btn_exitP";
            this.btn_exitP.Size = new System.Drawing.Size(25, 25);
            this.btn_exitP.TabIndex = 10;
            this.btn_exitP.Text = "X";
            this.btn_exitP.UseVisualStyleBackColor = false;
            this.btn_exitP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.Location = new System.Drawing.Point(452, 4);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(23, 22);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Tahoma", 5F, System.Drawing.FontStyle.Bold);
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_minimize.Location = new System.Drawing.Point(430, 4);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(20, 22);
            this.btn_minimize.TabIndex = 10;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 199);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(248, 500);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(476, 541);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lab_error_5);
            this.Controls.Add(this.lab_error4);
            this.Controls.Add(this.lab_error_3);
            this.Controls.Add(this.lab_error2);
            this.Controls.Add(this.txt_prefix);
            this.Controls.Add(this.txt_ip4);
            this.Controls.Add(this.txt_ip3);
            this.Controls.Add(this.txt_ip2);
            this.Controls.Add(this.lab_error_1);
            this.Controls.Add(this.txt_ip1);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_lastNO);
            this.Controls.Add(this.lab_firstNO);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab_broadcastNO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lab_maskNO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_networkNO);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MK Tik";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_networkNO;
        private System.Windows.Forms.Label lab_maskNO;
        private System.Windows.Forms.Label lab_broadcastNO;
        private System.Windows.Forms.Label lab_firstNO;
        private System.Windows.Forms.Label lab_lastNO;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.MaskedTextBox txt_ip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lab_error_1;
        private System.Windows.Forms.Label lab_error2;
        private System.Windows.Forms.MaskedTextBox txt_prefix;
        private System.Windows.Forms.MaskedTextBox txt_ip4;
        private System.Windows.Forms.MaskedTextBox txt_ip3;
        private System.Windows.Forms.MaskedTextBox txt_ip2;
        private System.Windows.Forms.Label lab_error_5;
        private System.Windows.Forms.Label lab_error4;
        private System.Windows.Forms.Label lab_error_3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_exitP;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

