using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form4 : Form
    {
        readonly DataBase db = new DataBase();
        readonly Form1 f1 = new Form1();
        string Id;
        string selected_person, selected_cpu, selected_cpuversion, selected_image;
        string selected_date, selected_tia, selected_target;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
            Id = f1.Id;
            editfillcombobox();
          
            FillAllComboboxes();
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.add_button.Enabled = true;
            f1.registertable.Enabled = true;
            f1.addNewToolStripMenuItem.Enabled = true;
            
        }

        private void Name_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Clearcombobobexes()
        {
            Name_ComboBox.Text = "";
            target_comboBox.Text = "";
            dateTimePicker1.Text = "";
            tia_combobox.Text = "";
            CPU_combobox.Text = "";
            CPUVersion_combobox.Text = "";
            image_combobox.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void editfillcombobox()
        {
           if(f1.Id != null)
            {
                Name_ComboBox.Text = db.select_asArray("register", "person", "id", Id);
                target_comboBox.Text = db.select_asArray("register", "target", "id", Id);
                CPUVersion_combobox.Text = db.select_asArray("register", "cpuversion", "id", Id);
                CPU_combobox.Text = db.select_asArray("register", "cpu", "id", Id);
                image_combobox.Text = db.select_asArray("register", "image", "id", Id);
                tia_combobox.Text = db.select_asArray("register", "tia", "id", Id);
                dateTimePicker1.Text = db.select_asArray("register", "date", "id", Id);
            }
        }
        public void FillAllComboboxes()
        {
            f1.Fillcombobox("person", Name_ComboBox);
            f1.Fillcombobox("target", target_comboBox);
            f1.Fillcombobox("tia", tia_combobox);
            f1.Fillcombobox("image", image_combobox);
            f1.Fillcombobox("cpu", CPU_combobox);
            f1.Fillcombobox("cpuversion", CPUVersion_combobox);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            if (Name_ComboBox.Text != "" && target_comboBox.Text != "" && image_combobox.Text != "" && CPU_combobox.Text != "" && CPUVersion_combobox.Text != "" &&
                tia_combobox.Text != "" && dateTimePicker1.Text != "")
            {
                selected_date = textInfo.ToTitleCase(dateTimePicker1.Text);
                selected_person = Name_ComboBox.Text;
                if (Name_ComboBox.Items.Contains(selected_person) == false)
                {
                    db.insert_toDatabase("person", "person", "'" + Name_ComboBox.Text + "'");
                    Name_ComboBox.Items.Clear();
                    f1.Fillcombobox("person", Name_ComboBox);
                }

                selected_image = image_combobox.Text;
                if (image_combobox.Items.Contains(selected_image) == false)
                {
                    db.insert_toDatabase("image", "image", "'" + image_combobox.Text + "'");
                    image_combobox.Items.Clear();
                    f1.Fillcombobox("image", image_combobox);
                }

                selected_cpuversion = CPUVersion_combobox.Text;
                if (CPUVersion_combobox.Items.Contains(selected_cpuversion) == false)
                {
                    db.insert_toDatabase("cpuversion", "cpuversion", "'" + CPUVersion_combobox.Text + "'");
                    CPUVersion_combobox.Items.Clear();
                    f1.Fillcombobox("cpuversion", CPUVersion_combobox);

                }

                selected_cpu = CPU_combobox.Text;
                if (CPU_combobox.Items.Contains(selected_cpu) == false)
                {
                    db.insert_toDatabase("cpu", "cpu", "'" + CPU_combobox.Text + "'");
                    CPU_combobox.Items.Clear();
                    f1.Fillcombobox("cpu", CPU_combobox);
                }

                selected_target = target_comboBox.Text;
                if (target_comboBox.Items.Contains(selected_target) == false)
                {
                    db.insert_toDatabase("target", "target", "'" + target_comboBox.Text + "'");
                    target_comboBox.Items.Clear();
                    f1.Fillcombobox("target", target_comboBox);

                }

                selected_tia = tia_combobox.Text;
                if (tia_combobox.Items.Contains(selected_tia) == false)
                {
                    db.insert_toDatabase("tia", "tia", "'" + selected_tia + "'");
                    tia_combobox.Items.Clear();
                    f1.Fillcombobox("tia", tia_combobox);
                }
                
                if (f1.Id != null)
                {
                    
                  
                        Id = f1.Id;
                        db.update_ApplytoDatabase("register", "person", Name_ComboBox.Text, Id);
                        db.update_ApplytoDatabase("register", "date", dateTimePicker1.Text, Id);
                        db.update_ApplytoDatabase("register", "image", image_combobox.Text, Id);
                        db.update_ApplytoDatabase("register", "cpu", CPU_combobox.Text, Id);
                        db.update_ApplytoDatabase("register", "cpuversion", CPUVersion_combobox.Text, Id);
                        db.update_ApplytoDatabase("register", "target", target_comboBox.Text, Id);
                        db.update_ApplytoDatabase("register", "tia", tia_combobox.Text, Id);
                        db.Showtable(f1.registertable, "register");
                        f1.Clear();
                        Id = null;
                }
                else
                {
                    db.insert_toDatabase("register", "date, person, target, tia, cpu, cpuversion, image"
             , "'" + selected_date + "', '" + selected_person + "', '" + selected_target + "', '" + selected_tia + "', '" + selected_cpu + "', '" + selected_cpuversion + "', '" + selected_image + "'");
                    db.Showtable(f1.registertable, "register");
                }
        

            }
        else
            {
                MessageBox.Show(" Lütfen tüm alanları doldurunuz ");
            }
            Clearcombobobexes();
            
        }

        
    }
}
