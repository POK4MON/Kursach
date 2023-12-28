namespace courseDataBase
{
    partial class Add_Data_Driver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_show = new System.Windows.Forms.PictureBox();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_PHONE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BUT_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(615, 62);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(18, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Создание Записи:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.pb_show);
            this.panel3.Controls.Add(this.textBox_FIO);
            this.panel3.Controls.Add(this.textBox_PHONE);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.BUT_Save);
            this.panel3.Location = new System.Drawing.Point(12, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 321);
            this.panel3.TabIndex = 7;
            // 
            // pb_show
            // 
            this.pb_show.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pb_show.Location = new System.Drawing.Point(96, 179);
            this.pb_show.Name = "pb_show";
            this.pb_show.Size = new System.Drawing.Size(198, 118);
            this.pb_show.TabIndex = 27;
            this.pb_show.TabStop = false;
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FIO.Location = new System.Drawing.Point(186, 30);
            this.textBox_FIO.Multiline = true;
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(338, 29);
            this.textBox_FIO.TabIndex = 17;
            this.textBox_FIO.TextChanged += new System.EventHandler(this.textBox_FIO_TextChanged);
            // 
            // textBox_PHONE
            // 
            this.textBox_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_PHONE.Location = new System.Drawing.Point(186, 65);
            this.textBox_PHONE.Multiline = true;
            this.textBox_PHONE.Name = "textBox_PHONE";
            this.textBox_PHONE.Size = new System.Drawing.Size(338, 29);
            this.textBox_PHONE.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(91, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(119, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "FIO:";
            // 
            // BUT_Save
            // 
            this.BUT_Save.Location = new System.Drawing.Point(422, 222);
            this.BUT_Save.Name = "BUT_Save";
            this.BUT_Save.Size = new System.Drawing.Size(172, 46);
            this.BUT_Save.TabIndex = 16;
            this.BUT_Save.Text = "Сохранить";
            this.BUT_Save.UseVisualStyleBackColor = true;
            this.BUT_Save.Click += new System.EventHandler(this.BUT_Save_Click);
            // 
            // Add_Data_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(654, 451);
            this.MinimumSize = new System.Drawing.Size(654, 451);
            this.Name = "Add_Data_Driver";
            this.Text = "Add_Data_Driver";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_PHONE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BUT_Save;
        private System.Windows.Forms.PictureBox pb_show;
    }
}