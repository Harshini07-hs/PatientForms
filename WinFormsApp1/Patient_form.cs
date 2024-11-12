using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinFormsApp1.Model;
using WinFormsApp1.Repo;
using WinFormsApp1;
using WinFormsApp1.Properties;



namespace WinFormsApp1
{
    public partial class Patient_form : Form
    {
        //private DataGridView dataGridView1;

        public Patient_form()
        {
            InitializeComponent();


            this.DialogResult = DialogResult.Cancel;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }





        private void button2_Click(object sender, EventArgs e)
        {

            PatientRepo patientRepo = new PatientRepo();
            //var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            //  Patient patient = patientRepo.GetPatient(patientId);
            Patient? patient;
            if (patientId == 0)
            {
                patient = new Patient();
            }
            else
            {
                patient = patientRepo.GetPatient(patientId);
            }



            patient.firstName = this.txtfirstname.Text;
            patient.lastName = this.txtlastname.Text;
            patient.email = this.txtemail.Text;
            patient.contactNumber = this.txtcontactnumber.Text;
            patient.address = this.txtaddress.Text;
            //patient.height= this.textBox4.Text;
            //patient.weight= this.textBox3.Text;
            patient.height = decimal.Parse(this.txtweight.Text);
            patient.weight = decimal.Parse(this.txtheight.Text);
            patient.gender = this.cmbsex.Text;
            patient.city = this.txtcity.Text;
            patient.state = this.txtstate.Text;
            patient.postalCode = this.txtpostalcode.Text;
            patient.maritalStatus = this.cmbmaritalstatus.Text;
            patient.dob = this.dtdob.Value;




            var repo = new PatientRepo();
            if (patient.id == 0)
            {
                repo.CreatePatient(patient);
            }
            else
            {
                //patient = patientRepo.GetPatient(patientId);
                repo.UpdatePatient(patient);
            }


            this.DialogResult = DialogResult.OK;


        }

        private int patientId = 0;
        public void EditPatient(Patient patient)
        {

            this.txtfirstname.Text = patient.firstName;
            this.txtlastname.Text = patient.lastName;
            this.txtemail.Text = patient.email;
            this.txtcontactnumber.Text = patient.contactNumber;
            this.txtaddress.Text = patient.address;
            //this.textBox4.Text = patient.height ;
            //this.textBox3.Text = patient.weight ;
            this.txtweight.Text = patient.height.ToString();
            this.txtheight.Text = patient.weight.ToString();
            this.cmbsex.Text = patient.gender;
            this.txtcity.Text = patient.city;
            this.txtstate.Text = patient.state;
            this.txtpostalcode.Text = patient.postalCode;
            this.cmbmaritalstatus.Text = patient.postalCode;
            // this.dateTimePicker1.Text = patient.dob;
            this.dtdob.Text = patient.dob.ToString("dd/MM/yyyy"); // Formatted date

            this.patientId = patient.id;






        }





        private void button1_Click(object sender, EventArgs e)
        {
            //Patient patient = new Patient();

            //patient.id = this.patientId; 
            //patient.firstName = this.textBox1.Text;
            //patient.lastName = this.textBox8.Text;
            //patient.email = this.textBox6.Text;
            //patient.contactNumber = this.textBox2.Text;
            //patient.address = this.textBox5.Text;
            //patient.height = decimal.Parse(this.textBox4.Text);
            //patient.weight = decimal.Parse(this.textBox3.Text);
            //patient.gender = this.comboBox1.Text;
            //patient.city = this.textBox7.Text;
            //patient.state = this.textBox9.Text; ;
            //patient.postalCode = this.textBox10.Text;
            //patient.maritalStatus = this.comboBox2.Text;
            //patient.dob = this.dateTimePicker1.Value;


            //var repo = new PatientRepo();
            //if(patient.id==0)
            //{
            //    repo.CreatePatient(patient);
            //}
            //else
            //{
            //    repo.UpdatePatient(patient);
            //}


            this.DialogResult = DialogResult.OK;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
            this.Close();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


