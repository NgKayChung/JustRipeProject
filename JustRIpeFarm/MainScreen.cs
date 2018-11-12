using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustRIpeFarm
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            main_panel.Dock = DockStyle.Fill;
            job_panel.Dock = DockStyle.Fill;
            stock_panel.Dock = DockStyle.Fill;
            labourer_panel.Dock = DockStyle.Fill;
            addLabour_panel.Visible = false;
            store_panel.Dock = DockStyle.Fill;
            machine_panel.Dock = DockStyle.Fill;
        }

        private void main_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = true;
            job_panel.Visible = false;
            stock_panel.Visible = false;
            labourer_panel.Visible = false;
            addLabour_panel.Visible = false;
            store_panel.Visible = false;
            machine_panel.Visible = false;
        }

        private void job_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            job_panel.Visible = true;
            stock_panel.Visible = false;
            labourer_panel.Visible = false;
            addLabour_panel.Visible = false;
            store_panel.Visible = false;
            machine_panel.Visible = false;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stock_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            job_panel.Visible = false;
            stock_panel.Visible = true;
            labourer_panel.Visible = false;
            addLabour_panel.Visible = false;
            store_panel.Visible = false;
            machine_panel.Visible = false;
        }

        private void labourer_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            job_panel.Visible = false;
            stock_panel.Visible = false;
            labourer_panel.Visible = true;
            addLabour_panel.Visible = false;
            store_panel.Visible = false;
            machine_panel.Visible = false;
        }

        private void machine_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            job_panel.Visible = false;
            stock_panel.Visible = false;
            labourer_panel.Visible = false;
            addLabour_panel.Visible = false;
            store_panel.Visible = false;
            machine_panel.Visible = true;
        }

        private void store_button_Click(object sender, EventArgs e)
        {
            main_panel.Visible = false;
            job_panel.Visible = false;
            stock_panel.Visible = false;
            labourer_panel.Visible = false;
            addLabour_panel.Visible = false;
            store_panel.Visible = true;
            machine_panel.Visible = false;
        }

        private void btnTestAdd_Click(object sender, EventArgs e)
        {
            addLabour_panel.Visible = true;
            //DbConnector dbcon = new DbConnector();
            //dbcon.connect();

            //Labourer labourer = new Labourer();
            //labourer.Name = "Adam";
            //labourer.Age = 30;
            //labourer.Gender = "MALE";

            //LabourerHandler labourerHandler = new LabourerHandler();
            //int recCount = labourerHandler.addNewLabourer(dbcon.getConn(), labourer);
            //MessageBox.Show(recCount + " record(s) has been inserted !");
        }

        private void submit_labourer_btn_Click(object sender, EventArgs e)
        {
            DbConnector dbcon = new DbConnector();
            dbcon.connect();

            string labourName = nameTextBox.Text;
            DateTime labourDob = dob_datePicker.Value;
            int labourAge = DateTime.Now.Year - labourDob.Year;
            string labourGender = (male_radioBtn.Checked ? "MALE" : "FEMALE");

            Labourer labourer = new Labourer();
            labourer.Name = labourName;
            labourer.Age = labourAge;
            labourer.Gender = labourGender;

            LabourerHandler labourerHandler = new LabourerHandler();
            int recCount = labourerHandler.addNewLabourer(dbcon.getConn(), labourer);
            MessageBox.Show(recCount + " record(s) has been inserted !");

            addLabour_panel.Visible = false;
        }

        private void search_labourer_btn_Click(object sender, EventArgs e)
        {
            labourerTable.Refresh();

            DbConnector dbcon = new DbConnector();
            dbcon.connect();
            
            LabourerHandler labourerHandler = new LabourerHandler();
            List<Labourer> labourersList = labourerHandler.getLabourers(dbcon.getConn());

            if (labourersList != null)
            {
                foreach (Labourer labourer in labourersList)
                {
                    labourerTable.RowCount++;
                    labourerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    int currentRow = labourerTable.RowCount;

                    Label idLabel = new Label();
                    idLabel.Text = labourer.Id.ToString();
                    idLabel.Dock = DockStyle.Fill;
                    idLabel.TextAlign = ContentAlignment.MiddleCenter;

                    Label nameLabel = new Label();
                    nameLabel.Text = labourer.Name;
                    nameLabel.Dock = DockStyle.Fill;
                    nameLabel.TextAlign = ContentAlignment.MiddleCenter;

                    Label ageLabel = new Label();
                    ageLabel.Text = labourer.Age.ToString();
                    ageLabel.Dock = DockStyle.Fill;
                    ageLabel.TextAlign = ContentAlignment.MiddleCenter;

                    Label genderLabel = new Label();
                    genderLabel.Text = labourer.Gender;
                    genderLabel.Dock = DockStyle.Fill;
                    genderLabel.TextAlign = ContentAlignment.MiddleCenter;

                    labourerTable.Controls.Add(idLabel, 0, currentRow - 1);
                    labourerTable.Controls.Add(nameLabel, 1, currentRow - 1);
                    labourerTable.Controls.Add(ageLabel, 2, currentRow - 1);
                    labourerTable.Controls.Add(genderLabel, 3, currentRow - 1);
                }
            }
            else
            {
                labourerTable.RowCount++;
                labourerTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                labourerTable.SetColumnSpan(new Label() { Text = "No Result Found" }, 4);
            }
        }
    }
}
