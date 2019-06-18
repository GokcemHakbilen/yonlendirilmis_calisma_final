namespace WindowsFormsApplication4
{
    partial class Form4
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
            this.CPUVersion_combobox = new System.Windows.Forms.ComboBox();
            this.Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.tia_combobox = new System.Windows.Forms.ComboBox();
            this.target_comboBox = new System.Windows.Forms.ComboBox();
            this.CPU_combobox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.image_combobox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CPUVersion_combobox
            // 
            this.CPUVersion_combobox.FormattingEnabled = true;
            this.CPUVersion_combobox.Location = new System.Drawing.Point(221, 111);
            this.CPUVersion_combobox.Name = "CPUVersion_combobox";
            this.CPUVersion_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPUVersion_combobox.TabIndex = 0;
            // 
            // Name_ComboBox
            // 
            this.Name_ComboBox.FormattingEnabled = true;
            this.Name_ComboBox.Location = new System.Drawing.Point(28, 111);
            this.Name_ComboBox.Name = "Name_ComboBox";
            this.Name_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Name_ComboBox.TabIndex = 1;
            this.Name_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Name_ComboBox_SelectedIndexChanged);
            // 
            // tia_combobox
            // 
            this.tia_combobox.FormattingEnabled = true;
            this.tia_combobox.Location = new System.Drawing.Point(28, 178);
            this.tia_combobox.Name = "tia_combobox";
            this.tia_combobox.Size = new System.Drawing.Size(121, 24);
            this.tia_combobox.TabIndex = 2;
            // 
            // target_comboBox
            // 
            this.target_comboBox.FormattingEnabled = true;
            this.target_comboBox.Location = new System.Drawing.Point(28, 245);
            this.target_comboBox.Name = "target_comboBox";
            this.target_comboBox.Size = new System.Drawing.Size(121, 24);
            this.target_comboBox.TabIndex = 3;
            // 
            // CPU_combobox
            // 
            this.CPU_combobox.FormattingEnabled = true;
            this.CPU_combobox.Location = new System.Drawing.Point(221, 39);
            this.CPU_combobox.Name = "CPU_combobox";
            this.CPU_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPU_combobox.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "TIA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Target";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cpu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "CpuVersion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Image";
            // 
            // image_combobox
            // 
            this.image_combobox.FormattingEnabled = true;
            this.image_combobox.Location = new System.Drawing.Point(224, 176);
            this.image_combobox.Name = "image_combobox";
            this.image_combobox.Size = new System.Drawing.Size(121, 24);
            this.image_combobox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.image_combobox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CPU_combobox);
            this.Controls.Add(this.target_comboBox);
            this.Controls.Add(this.tia_combobox);
            this.Controls.Add(this.Name_ComboBox);
            this.Controls.Add(this.CPUVersion_combobox);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "Add/Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CPUVersion_combobox;
        private System.Windows.Forms.ComboBox Name_ComboBox;
        private System.Windows.Forms.ComboBox tia_combobox;
        private System.Windows.Forms.ComboBox target_comboBox;
        private System.Windows.Forms.ComboBox CPU_combobox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox image_combobox;
        private System.Windows.Forms.Button button1;
    }
}