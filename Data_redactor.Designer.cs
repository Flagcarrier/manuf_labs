namespace Project
{
    partial class Data_redactor
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
            this.groupbox_dataparams = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_machine = new System.Windows.Forms.TextBox();
            this.textBox_detail = new System.Windows.Forms.TextBox();
            this.button_random = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_random_do = new System.Windows.Forms.TextBox();
            this.textBox_random_ot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_open_write = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.groupbox_dataparams.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_dataparams
            // 
            this.groupbox_dataparams.Controls.Add(this.textBox_detail);
            this.groupbox_dataparams.Controls.Add(this.textBox_machine);
            this.groupbox_dataparams.Controls.Add(this.label2);
            this.groupbox_dataparams.Controls.Add(this.label1);
            this.groupbox_dataparams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupbox_dataparams.Location = new System.Drawing.Point(13, 13);
            this.groupbox_dataparams.Name = "groupbox_dataparams";
            this.groupbox_dataparams.Size = new System.Drawing.Size(222, 92);
            this.groupbox_dataparams.TabIndex = 0;
            this.groupbox_dataparams.TabStop = false;
            this.groupbox_dataparams.Text = "Парметры данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество станков: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество деталей:";
            // 
            // textBox_machine
            // 
            this.textBox_machine.Location = new System.Drawing.Point(167, 19);
            this.textBox_machine.Name = "textBox_machine";
            this.textBox_machine.Size = new System.Drawing.Size(49, 26);
            this.textBox_machine.TabIndex = 2;
            this.textBox_machine.Text = "2";
            // 
            // textBox_detail
            // 
            this.textBox_detail.Location = new System.Drawing.Point(167, 49);
            this.textBox_detail.Name = "textBox_detail";
            this.textBox_detail.Size = new System.Drawing.Size(49, 26);
            this.textBox_detail.TabIndex = 3;
            this.textBox_detail.Text = "10";
            // 
            // button_random
            // 
            this.button_random.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_random.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_random.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_random.Location = new System.Drawing.Point(13, 123);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(222, 48);
            this.button_random.TabIndex = 1;
            this.button_random.Text = "Сгенерировать исходные данные";
            this.button_random.UseVisualStyleBackColor = false;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_random_do);
            this.groupBox1.Controls.Add(this.textBox_random_ot);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(241, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 92);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Парметры генератора случайных чисел";
            // 
            // textBox_random_do
            // 
            this.textBox_random_do.Location = new System.Drawing.Point(222, 37);
            this.textBox_random_do.Name = "textBox_random_do";
            this.textBox_random_do.Size = new System.Drawing.Size(49, 26);
            this.textBox_random_do.TabIndex = 3;
            this.textBox_random_do.Text = "10";
            // 
            // textBox_random_ot
            // 
            this.textBox_random_ot.Location = new System.Drawing.Point(127, 37);
            this.textBox_random_ot.Name = "textBox_random_ot";
            this.textBox_random_ot.Size = new System.Drawing.Size(49, 26);
            this.textBox_random_ot.TabIndex = 2;
            this.textBox_random_ot.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Интервал от";
            // 
            // button_open_write
            // 
            this.button_open_write.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_open_write.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_open_write.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_open_write.Location = new System.Drawing.Point(241, 123);
            this.button_open_write.Name = "button_open_write";
            this.button_open_write.Size = new System.Drawing.Size(292, 48);
            this.button_open_write.TabIndex = 3;
            this.button_open_write.Text = "Открыть файл с данными";
            this.button_open_write.UseVisualStyleBackColor = false;
            this.button_open_write.Click += new System.EventHandler(this.button_open_write_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Orange;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_save.Location = new System.Drawing.Point(125, 186);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(292, 48);
            this.button_save.TabIndex = 4;
            this.button_save.Text = "Загрузить данные в программу";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Data_redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(548, 250);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_open_write);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_random);
            this.Controls.Add(this.groupbox_dataparams);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Data_redactor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор исходных данных";
            this.Load += new System.EventHandler(this.Data_redactor_Load);
            this.groupbox_dataparams.ResumeLayout(false);
            this.groupbox_dataparams.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_dataparams;
        private System.Windows.Forms.TextBox textBox_detail;
        private System.Windows.Forms.TextBox textBox_machine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_random_do;
        private System.Windows.Forms.TextBox textBox_random_ot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_open_write;
        private System.Windows.Forms.Button button_save;
    }
}