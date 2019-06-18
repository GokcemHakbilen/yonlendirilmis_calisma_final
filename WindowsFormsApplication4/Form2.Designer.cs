namespace WindowsFormsApplication4
{
    partial class Form2
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
            this.Add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Person_button = new System.Windows.Forms.Button();
            this.tia_button = new System.Windows.Forms.Button();
            this.target_button = new System.Windows.Forms.Button();
            this.cpu_button = new System.Windows.Forms.Button();
            this.Cpuversion_button = new System.Windows.Forms.Button();
            this.image_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(221, 144);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 23);
            this.Add.TabIndex = 2;
            this.Add.Text = "Add new";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Visible = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Visible = false;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(466, 418);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 6;
            this.Delete_button.Text = "delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(31, 210);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(510, 202);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Person_button
            // 
            this.Person_button.Location = new System.Drawing.Point(31, 48);
            this.Person_button.Name = "Person_button";
            this.Person_button.Size = new System.Drawing.Size(75, 23);
            this.Person_button.TabIndex = 11;
            this.Person_button.Text = "Person";
            this.Person_button.UseVisualStyleBackColor = true;
            this.Person_button.Click += new System.EventHandler(this.Person_button_Click);
            // 
            // tia_button
            // 
            this.tia_button.Location = new System.Drawing.Point(128, 48);
            this.tia_button.Name = "tia_button";
            this.tia_button.Size = new System.Drawing.Size(75, 23);
            this.tia_button.TabIndex = 12;
            this.tia_button.Text = "TIA";
            this.tia_button.UseVisualStyleBackColor = true;
            this.tia_button.Click += new System.EventHandler(this.tia_button_Click);
            // 
            // target_button
            // 
            this.target_button.Location = new System.Drawing.Point(235, 48);
            this.target_button.Name = "target_button";
            this.target_button.Size = new System.Drawing.Size(75, 23);
            this.target_button.TabIndex = 13;
            this.target_button.Text = "Target";
            this.target_button.UseVisualStyleBackColor = true;
            this.target_button.Click += new System.EventHandler(this.target_button_Click);
            // 
            // cpu_button
            // 
            this.cpu_button.Location = new System.Drawing.Point(335, 48);
            this.cpu_button.Name = "cpu_button";
            this.cpu_button.Size = new System.Drawing.Size(75, 23);
            this.cpu_button.TabIndex = 14;
            this.cpu_button.Text = "CPU";
            this.cpu_button.UseVisualStyleBackColor = true;
            this.cpu_button.Click += new System.EventHandler(this.cpu_button_Click);
            // 
            // Cpuversion_button
            // 
            this.Cpuversion_button.Location = new System.Drawing.Point(434, 48);
            this.Cpuversion_button.Name = "Cpuversion_button";
            this.Cpuversion_button.Size = new System.Drawing.Size(91, 23);
            this.Cpuversion_button.TabIndex = 15;
            this.Cpuversion_button.Text = "CpuVersion";
            this.Cpuversion_button.UseVisualStyleBackColor = true;
            this.Cpuversion_button.Click += new System.EventHandler(this.Cpuversion_button_Click);
            // 
            // image_button
            // 
            this.image_button.Location = new System.Drawing.Point(558, 48);
            this.image_button.Name = "image_button";
            this.image_button.Size = new System.Drawing.Size(75, 23);
            this.image_button.TabIndex = 16;
            this.image_button.Text = "image";
            this.image_button.UseVisualStyleBackColor = true;
            this.image_button.Click += new System.EventHandler(this.image_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Değişiklik yapmak istediğiniz alana tıklayınız";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.image_button);
            this.Controls.Add(this.Cpuversion_button);
            this.Controls.Add(this.cpu_button);
            this.Controls.Add(this.target_button);
            this.Controls.Add(this.tia_button);
            this.Controls.Add(this.Person_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "AdminPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Delete_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
     
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Person_button;
        private System.Windows.Forms.Button tia_button;
        private System.Windows.Forms.Button target_button;
        private System.Windows.Forms.Button cpu_button;
        private System.Windows.Forms.Button Cpuversion_button;
        private System.Windows.Forms.Button image_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}