namespace courseDataBase
{
    partial class UserPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BUT_BuyTicket = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_route = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_SEARCH_WHERE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SEARCH_FROM = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BUT_Refresh = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_control = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_route)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_control)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(967, 882);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(959, 856);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расписание";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.BUT_BuyTicket);
            this.panel3.Location = new System.Drawing.Point(0, 543);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(953, 80);
            this.panel3.TabIndex = 9;
            // 
            // BUT_BuyTicket
            // 
            this.BUT_BuyTicket.BackColor = System.Drawing.SystemColors.Info;
            this.BUT_BuyTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BUT_BuyTicket.Location = new System.Drawing.Point(750, 16);
            this.BUT_BuyTicket.Name = "BUT_BuyTicket";
            this.BUT_BuyTicket.Size = new System.Drawing.Size(194, 49);
            this.BUT_BuyTicket.TabIndex = 12;
            this.BUT_BuyTicket.Text = "Купить Билет";
            this.BUT_BuyTicket.UseVisualStyleBackColor = false;
            this.BUT_BuyTicket.Click += new System.EventHandler(this.BUT_BuyTicket_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.dataGridView_route);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 456);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView_route
            // 
            this.dataGridView_route.AllowUserToAddRows = false;
            this.dataGridView_route.AllowUserToDeleteRows = false;
            this.dataGridView_route.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_route.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_route.Location = new System.Drawing.Point(8, 14);
            this.dataGridView_route.Name = "dataGridView_route";
            this.dataGridView_route.ReadOnly = true;
            this.dataGridView_route.Size = new System.Drawing.Size(937, 428);
            this.dataGridView_route.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.textBox_SEARCH_WHERE);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_SEARCH_FROM);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BUT_Refresh);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 75);
            this.panel1.TabIndex = 7;
            // 
            // textBox_SEARCH_WHERE
            // 
            this.textBox_SEARCH_WHERE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SEARCH_WHERE.Location = new System.Drawing.Point(414, 14);
            this.textBox_SEARCH_WHERE.Multiline = true;
            this.textBox_SEARCH_WHERE.Name = "textBox_SEARCH_WHERE";
            this.textBox_SEARCH_WHERE.Size = new System.Drawing.Size(237, 49);
            this.textBox_SEARCH_WHERE.TabIndex = 15;
            this.textBox_SEARCH_WHERE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SEARCH_WHERE.TextChanged += new System.EventHandler(this.textBox_SEARCH_WHERE_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Откуда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(350, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Куда";
            // 
            // textBox_SEARCH_FROM
            // 
            this.textBox_SEARCH_FROM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_SEARCH_FROM.Location = new System.Drawing.Point(99, 14);
            this.textBox_SEARCH_FROM.Multiline = true;
            this.textBox_SEARCH_FROM.Name = "textBox_SEARCH_FROM";
            this.textBox_SEARCH_FROM.Size = new System.Drawing.Size(237, 49);
            this.textBox_SEARCH_FROM.TabIndex = 12;
            this.textBox_SEARCH_FROM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_SEARCH_FROM.TextChanged += new System.EventHandler(this.textBox_SEARCH_FROM_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::courseDataBase.Properties.Resources.magnifier_1_icon_icons_com_56924__1_;
            this.pictureBox1.Location = new System.Drawing.Point(657, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // BUT_Refresh
            // 
            this.BUT_Refresh.BackColor = System.Drawing.SystemColors.Info;
            this.BUT_Refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BUT_Refresh.Location = new System.Drawing.Point(750, 14);
            this.BUT_Refresh.Name = "BUT_Refresh";
            this.BUT_Refresh.Size = new System.Drawing.Size(194, 49);
            this.BUT_Refresh.TabIndex = 10;
            this.BUT_Refresh.Text = "Обновить Данные";
            this.BUT_Refresh.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(959, 856);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Профиль";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.dataGridView_control);
            this.panel4.Location = new System.Drawing.Point(0, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(959, 217);
            this.panel4.TabIndex = 11;
            // 
            // dataGridView_control
            // 
            this.dataGridView_control.AllowUserToAddRows = false;
            this.dataGridView_control.AllowUserToDeleteRows = false;
            this.dataGridView_control.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView_control.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_control.Location = new System.Drawing.Point(8, 14);
            this.dataGridView_control.Name = "dataGridView_control";
            this.dataGridView_control.ReadOnly = true;
            this.dataGridView_control.Size = new System.Drawing.Size(937, 189);
            this.dataGridView_control.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(956, 75);
            this.panel5.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(750, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обновить Данные";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Location = new System.Drawing.Point(0, 543);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(959, 80);
            this.panel6.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Location = new System.Drawing.Point(0, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(959, 233);
            this.panel7.TabIndex = 13;
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 881);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.UserPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_route)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_control)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_route;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BUT_Refresh;
        private System.Windows.Forms.Button BUT_BuyTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SEARCH_FROM;
        private System.Windows.Forms.TextBox textBox_SEARCH_WHERE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_control;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}