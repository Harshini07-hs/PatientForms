using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Reflection;
using WinFormsApp1.Repo;


namespace WinFormsApp1
{
    public partial class Menu : Form
    {
        // private dataGridView1 patientsTable;
        public Menu()
        {
            InitializeComponent();
            Display();

            // ReadPatient();
        }

        //private void ReadPatient()
        //{
        //    DataTable dataTable = new DataTable();

        //    dataTable.Columns.Add("ID");
        //    dataTable.Columns.Add("Name");
        //    dataTable.Columns.Add("Email");
        //    dataTable.Columns.Add("Contact");
        //    dataTable.Columns.Add("DOB");

        //    var repo = new PatientRepo();
        //    var patients = repo.GetPatients();

        //    foreach (var patient in patients)
        //    {
        //        var row = dataTable.NewRow();

        //        row[0] = patient.id;
        //        row["Name"] = patient.firstName + "" + patient.lastName;
        //        row["Email"] = patient.email;
        //        row["Contact"] = patient.contactNumber;
        //        row["DOB"] = patient.dob;

        //        dataTable.Rows.Add(row);
        //    }

        //    this.dataGridView1.DataSource = dataTable;


        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Patient_form form = new Patient_form();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // ReadPatient();
                Display();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


            if (val == null || val.Length == 0) return;

            int patientId = int.Parse(val);

            var repo = new PatientRepo();
            var patient =
                repo.GetPatient(patientId);

            if (patient == null)
            {
                return;
            }
            else
            {
                Patient_form form = new Patient_form();

                form.EditPatient(patient);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //ReadPatient();
                    Display();
                }
            }









        }


        private void button3_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int patientId = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure to delete ?", "Delete Patient", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new PatientRepo();
            repo.DeletePatient(patientId);
            //  ReadPatient();
            Display();
            // BindData();
        }



        private void Display()
        {


            using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PatientRegister;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM NewClient", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient_form form = new Patient_form();
            if (form.ShowDialog() == DialogResult.OK)
            {
                // ReadPatient();
                Display();
                this.Close();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();


            if (val == null || val.Length == 0) return;

            int patientId = int.Parse(val);

            var repo = new PatientRepo();
            var patient =
                repo.GetPatient(patientId);

            if (patient == null)
            {
                return;
            }
            else
            {
                this.Hide();
                Patient_form form = new Patient_form();

                form.EditPatient(patient);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    //ReadPatient();
                    Display();
                    this.Close();
                }
            }


        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var val = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int patientId = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show($"Are you sure to delete PatientID : {this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString()} ?", "Delete Patient", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else
            {
                var repo = new PatientRepo();
                repo.DeletePatient(patientId);
                //  ReadPatient();
                Display();
            }


            // BindData();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
