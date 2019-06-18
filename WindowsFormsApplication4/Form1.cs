using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        readonly DataBase _db = new DataBase();
        string selected_person, selected_cpu, selected_cpuversion, selected_image;
        string selected_date, selected_date2, selected_tia, selected_target, ab;
        public string Id = null;
        List<string> a = new List<string>();
        
        string selected, selectedItem;
      

        public Form1()
        {
            InitializeComponent();
            FillAllComboboxes();
            _db.Showtable(registertable,"register");
            contextMenuStrip1.Enabled = false;
            editbutton.Enabled = false;
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";



            //richTextBox1.AppendText( db.selectidfromDatabase("register").ToString());

        }

     

        /* public int idgenerator()
{
    id1 = db.selectidfromDatabase("register");
    id1 =+ id1;
    return id1;
}*/
 

        public void Fillcombobox(string comboboxname, ComboBox cbx)
        {
            List<string> list = _db.SelectItem(comboboxname, comboboxname);
            for (int i = 0; i < list.Count; i++)
            {
                cbx.Items.Add(list[i]);

            }
        }

        public void FillAllComboboxes()
        {
            Fillcombobox("person", Name_ComboBox);
            Fillcombobox("target", target_comboBox);
            Fillcombobox("tia", tia_combobox);
            Fillcombobox("image", image_combobox);
            Fillcombobox("cpu", CPU_combobox);
            Fillcombobox("cpuversion", CPUVersion_combobox);
        }

       
        public void ClearcombobboxItems()
        {
            Name_ComboBox.Items.Clear();
            target_comboBox.Items.Clear();
            tia_combobox.Items.Clear();
            CPU_combobox.Items.Clear();
            CPUVersion_combobox.Items.Clear();
            image_combobox.Items.Clear();
        }
        public void Clear()
        {
            Name_ComboBox.Text = "";
            target_comboBox.Text = "";
            dateTimePicker1.Text = "";
            tia_combobox.Text = "";
            CPU_combobox.Text = "";
            CPUVersion_combobox.Text = "";
            image_combobox.Text = "";

        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Id = null;
            Form4 f4 = new Form4(this);
            f4.Show();
            add_button.Enabled = false;
            addNewToolStripMenuItem.Enabled = false;
            
            
        }

        private void registertable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            editbutton.Enabled = false;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.Show();
            adminToolStripMenuItem.Enabled = false;
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                dateTimePicker2.Enabled = true;
            }
            else
                dateTimePicker2.Enabled = false;
        }

        private void delete_button_Click_1(object sender, EventArgs e)
        {
            if (Id != null)
            {
                _db.delete_fromDatabase("register", "id", Id);
                _db.Showtable(registertable, "register");
                Clear();
            }
            else MessageBox.Show("Silinecek öge seçmediniz! ");
            delete_button.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
                dateTimePicker1.Enabled = false;
        }

        private void registertable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            editbutton.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Enabled = true;
            delete_button.Enabled = true;
            if (e.RowIndex >= 0)
               
            {
                DataGridViewRow row = this.registertable.Rows[e.RowIndex];
                Id = row.Cells["id"].Value.ToString();
              
            }
           /* if (e.RowIndex >= 0)
                {
                    Apply_button.Enabled = false;
                    Edit_button.Enabled = true;
                    delete_button.Enabled = true;
                    contextMenuStrip1.Enabled = true;
                    DataGridViewRow row = this.registertable.Rows[e.RowIndex];
                    dateTimePicker1.Text = row.Cells["date"].Value.ToString();
                    Name_ComboBox.Text = row.Cells["person"].Value.ToString();
                    tia_combobox.Text = row.Cells["Tia"].Value.ToString();
                    target_comboBox.Text = row.Cells["target"].Value.ToString();
                    CPU_combobox.Text = row.Cells["cpu"].Value.ToString();
                    CPUVersion_combobox.Text = row.Cells["cpuversion"].Value.ToString();
                    image_combobox.Text = row.Cells["image"].Value.ToString();
                    id = row.Cells["id"].Value.ToString();

                }*/
                
        }

  
    

    

        private void search_button_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                selected_date = dateTimePicker1.Text;
            }
            else selected_date = "";
            if (checkBox2.Checked == true)
            {
                selected_date2 = dateTimePicker2.Text;
            }
            else selected_date2 = "";
            selected_person = Name_ComboBox.Text;
            selected_tia = tia_combobox.Text;
            selected_target = target_comboBox.Text;
            selected_image = image_combobox.Text;
            selected_cpu = CPU_combobox.Text;
            selected_cpuversion = CPUVersion_combobox.Text;
            _db.Filtertable(registertable, "register", selected_date,selected_date2, selected_person, selected_target, selected_cpu, selected_tia, selected_cpuversion, selected_image);
            Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
           
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

   
        /*private void Edit_button_Click(object sender, EventArgs e)
        {

            if (Name_ComboBox.Text != "" && target_comboBox.Text != "" && image_combobox.Text != "" && CPU_combobox.Text != "" && CPUVersion_combobox.Text != "" &&
                tia_combobox.Text != "" && DateText.Text != "")
            {

                db.update_ApplytoDatabase("register", "person", Name_ComboBox.Text, id);
                db.update_ApplytoDatabase("register", "date", DateText.Text, id);
                db.update_ApplytoDatabase("register", "image", image_combobox.Text, id);
                db.update_ApplytoDatabase("register", "cpu", CPU_combobox.Text, id);
                db.update_ApplytoDatabase("register", "cpuversion", CPUVersion_combobox.Text, id);
                db.update_ApplytoDatabase("register", "target", target_comboBox.Text, id);
                db.update_ApplytoDatabase("register", "tia", tia_combobox.Text, id);
                db.showtable(registertable, "register");
                clear();
                id = null;
                Apply_button.Enabled = true;
                Edit_button.Enabled = false;

            }
            else
            {
                MessageBox.Show(" Lütfen tüm alanları doldurunuz ");
            }

        }*/

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _db.delete_fromDatabase("register", "id", Id);
            _db.Showtable(registertable,"register");
            Clear();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4(this);
            f4.Show();
            editbutton.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            registertable.Enabled = false;
            
            
            //Form2 f2 = new Form2(this);
            //f2.Show(); 
        }

    }
}



          