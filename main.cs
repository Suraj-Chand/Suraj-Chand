
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace BTMS1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1LF5S1M;Initial Catalog=BTMS1;Integrated Security=True");
        private int tryobject;

        private void txtBus_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_Load(object sender, EventArgs e)
        {
           // getpassengerdetails();

        }

        private void getpassengerdetails()
        {
          /*  SqlCommand cmd = new SqlCommand("SELECT FROM ticket_creator", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            searchticketdgv.DataSource = dt;
          */






        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

       
        private void searchticketbtn_Click(object sender, EventArgs e)
        {

        }

        private void addpassengerbtn_Click(object sender, EventArgs e)
        {
           // this.Hide();
            Form1 ss = new Form1();
           
            if(IsValid())
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO TICKET CREATOR VALUES (@)Ticketno,@SourceStation,@DestinationStation,@BusNo,@TotalFareCost,@IssuedDate,@DepartureDate,@ArrivalTime,@DepartureTime,@PassergerName,@PassengerAddress,@PassengerAge,@PassengerPhoneNo,@PassengerGender",con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ticketno", ticketnotxtbox.Text);
                cmd.Parameters.AddWithValue("@SourceStation", sourcestationcomboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@DestinationStation", destinationstationcombobox.SelectedItem);
                cmd.Parameters.AddWithValue("@TotalFareCost", totalfarecosttxtbox.Text);
                cmd.Parameters.AddWithValue("@IssuedDate", issueddatetxtbox.Text);
                cmd.Parameters.AddWithValue("@DepartureDate", departuredatetxtbox.Text);
                cmd.Parameters.AddWithValue("@ArrivalTime", arrivaltimetxtbox.Text);
                cmd.Parameters.AddWithValue("@DepartureTime", arrivaltimetxtbox.Text);
                cmd.Parameters.AddWithValue("@PassergerName", passengernametxtbox.Text);
                cmd.Parameters.AddWithValue("@PassengerAddress", passengeraddresstxtbox.Text);
                cmd.Parameters.AddWithValue("@PassengerAge", passengeragetxtbox.Text);
                cmd.Parameters.AddWithValue("@PassengerPhoneNo", passengerphonenumber.Text);
                cmd.Parameters.AddWithValue("@PassengerAge", passengeragetxtbox.Text);
                cmd.Parameters.AddWithValue("@PassengerGender", passengergendercomboBox.SelectedItem);

                con.Open();
               // tryobject = (cmd.ExecuteNonQuery());

//                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Passenger Added Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ss.Show();



              //  searchticketdgv.Show();
               // getpassengerdetails();

                }
        }

        private bool IsValid()
        {
           if (passengernametxtbox.Text==string.Empty)
            {
                MessageBox.Show("passenger name cannot be empty.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void searchticketdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
