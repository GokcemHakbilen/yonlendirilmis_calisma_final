namespace WindowsFormsApplication4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editbutton = new System.Windows.Forms.Button();
            this.tia_combobox = new System.Windows.Forms.ComboBox();
            this.registertable = new System.Windows.Forms.DataGridView();
            this.image_label = new System.Windows.Forms.Label();
            this.cpuversion_label = new System.Windows.Forms.Label();
            this.image_combobox = new System.Windows.Forms.ComboBox();
            this.CPUVersion_combobox = new System.Windows.Forms.ComboBox();
            this.CPU_combobox = new System.Windows.Forms.ComboBox();
            this.target_label = new System.Windows.Forms.Label();
            this.target_comboBox = new System.Windows.Forms.ComboBox();
            this.Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.Name_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.TIA_label = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jhjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kkkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ghgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.search_button = new System.Windows.Forms.Button();
            this.Label_cpu = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.add_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registertable)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // editbutton
            // 
            this.editbutton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.editbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.editbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(817, 659);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(145, 41);
            this.editbutton.TabIndex = 60;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = false;
            this.editbutton.Click += new System.EventHandler(this.button4_Click);
            // 
            // tia_combobox
            // 
            this.tia_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tia_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tia_combobox.BackColor = System.Drawing.SystemColors.Window;
            this.tia_combobox.FormattingEnabled = true;
            this.tia_combobox.Location = new System.Drawing.Point(311, 38);
            this.tia_combobox.Name = "tia_combobox";
            this.tia_combobox.Size = new System.Drawing.Size(121, 24);
            this.tia_combobox.Sorted = true;
            this.tia_combobox.TabIndex = 68;
            // 
            // registertable
            // 
            this.registertable.AllowDrop = true;
            this.registertable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.registertable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registertable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.registertable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registertable.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.registertable.DefaultCellStyle = dataGridViewCellStyle2;
            this.registertable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.registertable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.registertable.Location = new System.Drawing.Point(41, 293);
            this.registertable.MultiSelect = false;
            this.registertable.Name = "registertable";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.registertable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.registertable.RowTemplate.Height = 24;
            this.registertable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registertable.Size = new System.Drawing.Size(1074, 273);
            this.registertable.TabIndex = 59;
            this.registertable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registertable_CellContentClick);
            this.registertable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.registertable_CellContentClick);
            this.registertable.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.registertable_RowStateChanged);
            // 
            // image_label
            // 
            this.image_label.AutoSize = true;
            this.image_label.Location = new System.Drawing.Point(918, 18);
            this.image_label.Name = "image_label";
            this.image_label.Size = new System.Drawing.Size(46, 17);
            this.image_label.TabIndex = 58;
            this.image_label.Text = "Image";
            // 
            // cpuversion_label
            // 
            this.cpuversion_label.AutoSize = true;
            this.cpuversion_label.Location = new System.Drawing.Point(746, 18);
            this.cpuversion_label.Name = "cpuversion_label";
            this.cpuversion_label.Size = new System.Drawing.Size(84, 17);
            this.cpuversion_label.TabIndex = 57;
            this.cpuversion_label.Text = "CPUVersion";
            // 
            // image_combobox
            // 
            this.image_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.image_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.image_combobox.FormattingEnabled = true;
            this.image_combobox.Location = new System.Drawing.Point(906, 40);
            this.image_combobox.Name = "image_combobox";
            this.image_combobox.Size = new System.Drawing.Size(121, 24);
            this.image_combobox.Sorted = true;
            this.image_combobox.TabIndex = 56;
            // 
            // CPUVersion_combobox
            // 
            this.CPUVersion_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CPUVersion_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CPUVersion_combobox.FormattingEnabled = true;
            this.CPUVersion_combobox.Location = new System.Drawing.Point(749, 40);
            this.CPUVersion_combobox.Name = "CPUVersion_combobox";
            this.CPUVersion_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPUVersion_combobox.Sorted = true;
            this.CPUVersion_combobox.TabIndex = 55;
            // 
            // CPU_combobox
            // 
            this.CPU_combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CPU_combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CPU_combobox.FormattingEnabled = true;
            this.CPU_combobox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.CPU_combobox.Location = new System.Drawing.Point(600, 40);
            this.CPU_combobox.Name = "CPU_combobox";
            this.CPU_combobox.Size = new System.Drawing.Size(121, 24);
            this.CPU_combobox.Sorted = true;
            this.CPU_combobox.TabIndex = 54;
            // 
            // target_label
            // 
            this.target_label.AutoSize = true;
            this.target_label.Location = new System.Drawing.Point(479, 18);
            this.target_label.Name = "target_label";
            this.target_label.Size = new System.Drawing.Size(50, 17);
            this.target_label.TabIndex = 53;
            this.target_label.Text = "Target";
            // 
            // target_comboBox
            // 
            this.target_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.target_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.target_comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.target_comboBox.FormattingEnabled = true;
            this.target_comboBox.Location = new System.Drawing.Point(458, 38);
            this.target_comboBox.Name = "target_comboBox";
            this.target_comboBox.Size = new System.Drawing.Size(121, 24);
            this.target_comboBox.Sorted = true;
            this.target_comboBox.TabIndex = 51;
            // 
            // Name_ComboBox
            // 
            this.Name_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Name_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Name_ComboBox.FormattingEnabled = true;
            this.Name_ComboBox.Location = new System.Drawing.Point(161, 38);
            this.Name_ComboBox.Name = "Name_ComboBox";
            this.Name_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.Name_ComboBox.Sorted = true;
            this.Name_ComboBox.TabIndex = 49;
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(172, 18);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(45, 17);
            this.Name_label.TabIndex = 46;
            this.Name_label.Text = "Name";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(72, 10);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(38, 17);
            this.Date_label.TabIndex = 45;
            this.Date_label.Text = "Date";
            // 
            // TIA_label
            // 
            this.TIA_label.AutoSize = true;
            this.TIA_label.Location = new System.Drawing.Point(347, 15);
            this.TIA_label.Name = "TIA_label";
            this.TIA_label.Size = new System.Drawing.Size(29, 17);
            this.TIA_label.TabIndex = 44;
            this.TIA_label.Text = "TIA";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jhjToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(95, 28);
            // 
            // jhjToolStripMenuItem
            // 
            this.jhjToolStripMenuItem.Name = "jhjToolStripMenuItem";
            this.jhjToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.jhjToolStripMenuItem.Text = "jhj";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.AllowDrop = true;
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kkkToolStripMenuItem,
            this.hhToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(100, 52);
            // 
            // kkkToolStripMenuItem
            // 
            this.kkkToolStripMenuItem.Name = "kkkToolStripMenuItem";
            this.kkkToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.kkkToolStripMenuItem.Text = "kkk";
            // 
            // hhToolStripMenuItem
            // 
            this.hhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hjhToolStripMenuItem});
            this.hhToolStripMenuItem.Name = "hhToolStripMenuItem";
            this.hhToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.hhToolStripMenuItem.Text = "hh";
            // 
            // hjhToolStripMenuItem
            // 
            this.hjhToolStripMenuItem.Name = "hjhToolStripMenuItem";
            this.hjhToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.hjhToolStripMenuItem.Text = "hjh";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ghgToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1207, 28);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ghgToolStripMenuItem
            // 
            this.ghgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.editToolStripMenuItem,
            this.addNewToolStripMenuItem});
            this.ghgToolStripMenuItem.Name = "ghgToolStripMenuItem";
            this.ghgToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ghgToolStripMenuItem.Text = "Menu";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.adminToolStripMenuItem.Text = "Admin Page";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.button4_Click);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.addNewToolStripMenuItem.Text = "Add new";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker1.TabIndex = 73;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.search_button);
            this.groupBox1.Controls.Add(this.Label_cpu);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Name_label);
            this.groupBox1.Controls.Add(this.Name_ComboBox);
            this.groupBox1.Controls.Add(this.tia_combobox);
            this.groupBox1.Controls.Add(this.TIA_label);
            this.groupBox1.Controls.Add(this.target_comboBox);
            this.groupBox1.Controls.Add(this.target_label);
            this.groupBox1.Controls.Add(this.CPUVersion_combobox);
            this.groupBox1.Controls.Add(this.cpuversion_label);
            this.groupBox1.Controls.Add(this.CPU_combobox);
            this.groupBox1.Controls.Add(this.image_combobox);
            this.groupBox1.Controls.Add(this.image_label);
            this.groupBox1.Location = new System.Drawing.Point(35, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 127);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 84);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 77;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(30, 81);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 22);
            this.dateTimePicker2.TabIndex = 76;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(994, 79);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(101, 30);
            this.search_button.TabIndex = 75;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Label_cpu
            // 
            this.Label_cpu.AutoSize = true;
            this.Label_cpu.Location = new System.Drawing.Point(626, 15);
            this.Label_cpu.Name = "Label_cpu";
            this.Label_cpu.Size = new System.Drawing.Size(33, 17);
            this.Label_cpu.TabIndex = 75;
            this.Label_cpu.Text = "Cpu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 74;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.add_button.Location = new System.Drawing.Point(970, 659);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(145, 41);
            this.add_button.TabIndex = 60;
            this.add_button.Text = "Add new";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.delete_button.Enabled = false;
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.delete_button.Location = new System.Drawing.Point(664, 659);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(145, 41);
            this.delete_button.TabIndex = 60;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click_1);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 830);
            this.ContextMenuStrip = this.contextMenuStrip3;
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.registertable);
            this.Controls.Add(this.Date_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Test Register";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registertable)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        
      
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.ComboBox tia_combobox;
       
        public System.Windows.Forms.DataGridView registertable;
        private System.Windows.Forms.Label image_label;
        private System.Windows.Forms.Label cpuversion_label;
        private System.Windows.Forms.ComboBox image_combobox;
        private System.Windows.Forms.ComboBox CPUVersion_combobox;
        private System.Windows.Forms.ComboBox CPU_combobox;
        private System.Windows.Forms.Label target_label;
        private System.Windows.Forms.ComboBox target_comboBox;
        public System.Windows.Forms.ComboBox Name_ComboBox;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label TIA_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem jhjToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem kkkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjhToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ghgToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label Label_cpu;
        private System.Windows.Forms.Button search_button;
        public System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

