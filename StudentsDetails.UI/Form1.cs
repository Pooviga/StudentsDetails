using StudentDetails.Model;
using StudentDetails.Rules;

namespace StudentsDetails.UI
{
    public partial class frmStudentDetails : Form
    {
        // choose the form mode (Insert or update)

        public frmStudentDetails()
        {
            InitializeComponent();
            gdvDetails.DataSource = ad.FetchDetails();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        public int id = 0;
        bool rowsaffected;
        clsDetailsTracker ad = new clsDetailsTracker();
        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateAttributes c = new CreateAttributes();

            c.Name = txtName.Text;

            c.Number = txtNumber.Text;

            c.Mail = txtMail.Text;



            c.Amount = Convert.ToDecimal(txtAmount.Text);

            c.City = txtCity.Text;

            rowsaffected = ad.AddDetails(c);
            
            if (rowsaffected == true)
            {
                gdvDetails.DataSource = ad.FetchDetails();
                MessageBox.Show("Inserted Values");
            }
            else
            {
                MessageBox.Show("Not Inserted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rowsaffected = ad.DeleteDetails(this.id);
            if (rowsaffected == true)
            {
                gdvDetails.DataSource = ad.FetchDetails();
                MessageBox.Show("Details Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
        }

        private void grpDetails_Enter(object sender, EventArgs e)
        {

        }

        private void gdvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // user has chosen a record -> update mode
            // track which row has been clicked

            //var selectedRow = e.RowIndex;

            //[Id],[Name],Number,Mail,City,Amount
            this.id = Convert.ToInt32(gdvDetails[0, e.RowIndex].Value);
            txtId.Text = gdvDetails[0, e.RowIndex].Value.ToString();
            txtName.Text = gdvDetails[1, e.RowIndex].Value.ToString();
            txtNumber.Text = gdvDetails[2, e.RowIndex].Value.ToString();
            txtMail.Text = gdvDetails[3, e.RowIndex].Value.ToString();
            txtCity.Text = gdvDetails[4, e.RowIndex].Value.ToString();
            txtAmount.Text = gdvDetails[5, e.RowIndex].Value.ToString();
            // Id, Name, 
            //gdvDetails[e.RowIndex]
            // read that cell value


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateAttributes c = new CreateAttributes();

            c.Name = txtName.Text;

            c.Number = txtNumber.Text;

            c.Mail = txtMail.Text;

            c.Amount = Convert.ToDecimal(txtAmount.Text);

            c.City = txtCity.Text;

            
            c.Id = Convert.ToInt32(txtId.Text);
            rowsaffected = ad.UpDetails(c);
            if (rowsaffected == true)
            {
                gdvDetails.DataSource = ad.FetchDetails();
                MessageBox.Show("Updated the Values");
            }
            else
            {
                MessageBox.Show("Values are not Updated");
            }

        }
    }
}