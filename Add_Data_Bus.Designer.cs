﻿namespace courseDataBase
{
    partial class Add_Data_Bus
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
            this.textBox_tutor_FIO = new System.Windows.Forms.TextBox();
            this.textBox_tutor_PHONE = new System.Windows.Forms.TextBox();
            this.textBox_tutor_GRADE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BUT_Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.textBox_tutor_FIO);
            this.panel3.Controls.Add(this.textBox_tutor_PHONE);
            this.panel3.Controls.Add(this.textBox_tutor_GRADE);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.BUT_Save);
            this.panel3.Location = new System.Drawing.Point(12, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(615, 321);
            this.panel3.TabIndex = 7;
            // 
            // textBox_tutor_FIO
            // 
            this.textBox_tutor_FIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tutor_FIO.Location = new System.Drawing.Point(181, 84);
            this.textBox_tutor_FIO.Multiline = true;
            this.textBox_tutor_FIO.Name = "textBox_tutor_FIO";
            this.textBox_tutor_FIO.Size = new System.Drawing.Size(338, 29);
            this.textBox_tutor_FIO.TabIndex = 17;
            // 
            // textBox_tutor_PHONE
            // 
            this.textBox_tutor_PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tutor_PHONE.Location = new System.Drawing.Point(181, 119);
            this.textBox_tutor_PHONE.Multiline = true;
            this.textBox_tutor_PHONE.Name = "textBox_tutor_PHONE";
            this.textBox_tutor_PHONE.Size = new System.Drawing.Size(338, 29);
            this.textBox_tutor_PHONE.TabIndex = 18;
            // 
            // textBox_tutor_GRADE
            // 
            this.textBox_tutor_GRADE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_tutor_GRADE.Location = new System.Drawing.Point(181, 154);
            this.textBox_tutor_GRADE.Multiline = true;
            this.textBox_tutor_GRADE.Name = "textBox_tutor_GRADE";
            this.textBox_tutor_GRADE.Size = new System.Drawing.Size(338, 29);
            this.textBox_tutor_GRADE.TabIndex = 19;
            this.textBox_tutor_GRADE.TextChanged += new System.EventHandler(this.textBox_tutor_GRADE_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(87, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 29);
            this.label12.TabIndex = 22;
            this.label12.Text = "Grade:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(84, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 29);
            this.label13.TabIndex = 21;
            this.label13.Text = "Phone:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(114, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 29);
            this.label14.TabIndex = 20;
            this.label14.Text = "FIO:";
            // 
            // BUT_Save
            // 
            this.BUT_Save.Location = new System.Drawing.Point(261, 256);
            this.BUT_Save.Name = "BUT_Save";
            this.BUT_Save.Size = new System.Drawing.Size(172, 46);
            this.BUT_Save.TabIndex = 16;
            this.BUT_Save.Text = "Сохранить";
            this.BUT_Save.UseVisualStyleBackColor = true;
            this.BUT_Save.Click += new System.EventHandler(this.BUT_Save_Click);
            // 
            // Add_Data_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 412);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(654, 451);
            this.MinimumSize = new System.Drawing.Size(654, 451);
            this.Name = "Add_Data_Bus";
            this.Text = "Add_Data_Bus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BUT_Save;
        private System.Windows.Forms.TextBox textBox_tutor_FIO;
        private System.Windows.Forms.TextBox textBox_tutor_PHONE;
        private System.Windows.Forms.TextBox textBox_tutor_GRADE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}