using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class studentRegistration : Form
    {
        public studentRegistration()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Show a confirmation message box with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If the user clicks Yes, close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();  // Exits the application
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if a valid item is selected in ComboBox
            if (cbRegNo.SelectedItem is Student selectedStudent)
            {
                // Populate fields with selected student's details
                tbFName.Text = selectedStudent.firstName;
                tbLName.Text = selectedStudent.lastName;
                dpDOB.Value = selectedStudent.dateOfBirth;

                // Set gender radio button
                if (selectedStudent.gender == "Male")
                {
                    rbMale.Checked = true;
                    rbFemale.Checked = false;
                }
                else if (selectedStudent.gender == "Female")
                {
                    rbMale.Checked = false;
                    rbFemale.Checked = true;
                }

                tbAddress.Text = selectedStudent.address;
                tbEmail.Text = selectedStudent.email;
                tbMPhone.Text = selectedStudent.mPhone.ToString();
                tbHPhone.Text = selectedStudent.hPhone.ToString();
                tbParentName.Text = selectedStudent.parentName;
                tbNIC.Text = selectedStudent.nic;
                tbContactNo.Text = selectedStudent.contactNo.ToString();
            }
            else
            {
                ClearFormFields();
            }
        }

        // Helper method to clear all form fields
        private void ClearFormFields()
        {
            cbRegNo.Text = "";
            tbFName.Text = "";
            tbLName.Text = "";
            dpDOB.Value = DateTime.Now;  // Reset to today's date or default date
            rbMale.Checked = false;
            rbFemale.Checked = false;
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbMPhone.Text = "";
            tbHPhone.Text = "";
            tbParentName.Text = "";
            tbNIC.Text = "";
            tbContactNo.Text = "";
            cbRegNo.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string query = "INSERT INTO Registration (regNo,firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo) VALUES (@regNo,@firstName,@lastName,@dateOfBirth,@gender,@address,@email,@mobilePhone,@homePhone,@parentName,@nic,@contactNo)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@regNo", cbRegNo.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@firstName", tbFName.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@lastName", tbLName.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@dateOfBirth", dpDOB.Text ?? String.Empty);
                if (rbMale.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", rbMale.Text ?? String.Empty);
                }
                if (rbFemale.Checked)
                {
                    cmd.Parameters.AddWithValue("@gender", rbFemale.Text ?? String.Empty);
                }
                cmd.Parameters.AddWithValue("@address", tbAddress.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@mobilePhone", tbMPhone.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@homePhone", tbHPhone.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@parentName", tbParentName.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@nic", tbNIC.Text ?? String.Empty);
                cmd.Parameters.AddWithValue("@contactNo", tbContactNo.Text ?? String.Empty);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Record Added Succesfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentDetails();
                }
                else
                {
                    MessageBox.Show("Please Enter All fields", "Invalid Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid details", "Invalid Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFormFields();
        }

        private void studentRegistration_Load(object sender, EventArgs e)
        {
            LoadStudentDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void LoadStudentDetails()
        {
            var std = new List<Student>();
            SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT regNo,firstName,lastName,dateOfBirth,gender,address,email,mobilePhone,homePhone,parentName,nic,contactNo from Registration";
            SqlCommand cmd = new SqlCommand(query, con);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var student = new Student
                    {
                        regNo = reader.GetInt32(0),
                        firstName = reader.GetString(1),
                        lastName = reader.GetString(2),
                        dateOfBirth = reader.GetDateTime(3),
                        gender = reader.GetString(4),
                        address = reader.GetString(5),
                        email = reader.GetString(6),
                        mPhone = reader.GetInt32(7),
                        hPhone = reader.GetInt32(8),
                        parentName = reader.GetString(9),
                        nic = reader.GetString(10),
                        contactNo = reader.GetInt32(11)
                    };
                    std.Add(student);
                }
            }
            con.Close();

            cbRegNo.DataSource = std;
            cbRegNo.DisplayMember = "regNo";
            cbRegNo.ValueMember = "regNo";
            cbRegNo.Text = "";
            ClearFormFields();
        }

        private void UpdateRecord()
        {
            if (cbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a student record to update.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        string query = "UPDATE Registration SET firstName = @firstName, lastName = @lastName, dateOfBirth = @dateOfBirth, gender = @gender, address = @address, email = @email, mobilePhone = @mobilePhone, homePhone = @homePhone, parentName = @parentName, nic = @nic, contactNo = @contactNo WHERE regNo = @regNo";
                        SqlCommand cmd = new SqlCommand(query, con);

                        // Add parameters with values from form fields
                        cmd.Parameters.AddWithValue("@regNo", cbRegNo.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@firstName", tbFName.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@lastName", tbLName.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@dateOfBirth", dpDOB.Value);

                        string gender = rbMale.Checked ? "Male" : rbFemale.Checked ? "Female" : "";
                        cmd.Parameters.AddWithValue("@gender", gender);

                        cmd.Parameters.AddWithValue("@address", tbAddress.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@email", tbEmail.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@mobilePhone", tbMPhone.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@homePhone", tbHPhone.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@parentName", tbParentName.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@nic", tbNIC.Text ?? string.Empty);
                        cmd.Parameters.AddWithValue("@contactNo", tbContactNo.Text ?? string.Empty);

                        // Execute update command and show a message on success
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentDetails  ();
                        }
                        else
                        {
                            MessageBox.Show("Update Failed. Please check details", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteRecord()
        {
            // Check if a record is selected
            if (cbRegNo.SelectedItem == null)
            {
                MessageBox.Show("Please select a student record to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Show confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True"))
                    {
                        con.Open();
                        string query = "DELETE FROM Registration WHERE regNo = @regNo";
                        SqlCommand cmd = new SqlCommand(query, con);

                        // Add regNo parameter
                        cmd.Parameters.AddWithValue("@regNo", cbRegNo.SelectedValue);

                        // Execute delete command and show success message if record deleted
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Record deleted successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudentDetails();  // Refresh ComboBox data
                        }
                        else
                        {
                            MessageBox.Show("Delete failed. Please try again.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void dpDOB_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class Student
    {
        public int regNo { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public int mPhone { get; set; }
        public int hPhone { get; set; }
        public string parentName { get; set; }
        public string nic { get; set; }
        public int contactNo { get; set; }
    }
}
