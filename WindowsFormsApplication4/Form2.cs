using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
namespace WindowsFormsApplication4
{
    public partial class Form2 : Form
    {
        readonly DataBase db = new DataBase();
        string selected, Id;
        readonly Form1 f1 = new Form1();
       

        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
            
        }
        
        public void Filltable()
        {

            db.Showtable(dataGridView1, selected);
            
        }

    
        public void Filllabel()
        {
            label1.Text = ("Yeni bir " + selected + " eklemek için buraya yazınız");
        }
      
        private void Add_Click(object sender, EventArgs e)
        {
            
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            if (textBox1.Text != null)
            {

                List<string> list =  db.SelectItem(selected, selected);


                if (list.Count != 0)
                {
                    string text = textInfo.ToTitleCase(textBox1.Text);
                    
                    for (int i = 0; i < list.Count; i++)
                    {

                        if (list[i] == text)
                        {
                            MessageBox.Show("Bu öğe daha önceden eklenmiştir! ");
                            break;
                        }
                        else if (i == list.Count - 1)
                        {
                            
                            db.insert_toDatabase(selected, selected, "'" +text+ "'");
                            Filltable();
                            f1.ClearcombobboxItems();
                            f1.FillAllComboboxes();
                        }

                    }
                }
                else
                {
                    string text = textInfo.ToTitleCase(textBox1.Text);
                    db.insert_toDatabase(selected, selected, "'" +text+ "'");
                    Filltable();
                    f1.ClearcombobboxItems();
                    f1.FillAllComboboxes();
                }

              
                Id = null;
            }
            else
                MessageBox.Show("Bos öğe ekleyemezsiniz! ");
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (selected != null && Id != null)
            {
                db.delete_fromDatabase(selected, "id", Id);
                
                db.Showtable(dataGridView1, selected);
                Filltable();
                Id = null;
                f1.ClearcombobboxItems();
                f1.FillAllComboboxes();

            }
            else
            MessageBox.Show("Silinecek öğe seçmediniz!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Person_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = Person_button.Text;
            Filllabel();
            db.Showtable(dataGridView1, selected);
        }

        private void tia_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = tia_button.Text;
            Filllabel();
            db.Showtable(dataGridView1, selected);
        }

        private void target_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = target_button.Text;
            Filllabel();
            f1.Name_ComboBox.Items.Clear();
            db.Showtable(dataGridView1, selected);
        }

        private void cpu_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = cpu_button.Text;
            Filllabel();
            db.Showtable(dataGridView1, selected);
        }

        private void Cpuversion_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = Cpuversion_button.Text;
            Filllabel();
            db.Showtable(dataGridView1, selected);
        }

        private void image_button_Click(object sender, EventArgs e)
        {
            Add.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            textBox1.Text = "";
            selected = image_button.Text;
            Filllabel();
            db.Showtable(dataGridView1, selected);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.adminToolStripMenuItem.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Id = row.Cells["id"].Value.ToString();
               
            }
        }
    }
    
}
 