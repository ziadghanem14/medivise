﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS
{
    public partial class OverviewScreen : Form
    {
        public OverviewScreen()
        {
            InitializeComponent();
        }

        string email = UserSession.Email;

        // Checking if the user is logged in
        bool isLoggedIn = UserSession.IsLoggedIn;

        dbConnection functions = new dbConnection();

        private void OverviewScreen_Load(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {

                using (MySqlConnection connection = new MySqlConnection(functions.connectionString))
                {
                    using (MySqlCommand command = connection.CreateCommand())
                    {
                        try
                        {
                            // Open the connection
                            connection.Open();


                            // Get username for the Welcome message**********************
                            // Set the command text and parameters
                            command.CommandText = "SELECT fname, lname FROM userTable WHERE email = @email";
                            command.Parameters.AddWithValue("@email", email);

                            // Execute the command and retrieve the first name and last name
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string firstName = reader.GetString("fname");
                                    string lastName = reader.GetString("lname");

                                    // Display the first name in a label control
                                    usernamelabel.Text = "Welcome, " + firstName + " " + lastName +"!";
                                }
                                else
                                {
                                    // No rows returned
                                    MessageBox.Show("Invalid username");
                                }
                            }

                            // get total patient count***********************
                            command.CommandText = "SELECT COUNT(*) FROM patientTable";
                            int rowCount1 = Convert.ToInt32(command.ExecuteScalar());
                            Tpatientlbl.Text = rowCount1.ToString();



                            // get total patient count***********************
                           
                            command.CommandText = "SELECT COUNT(*) FROM appointmentTable";
                            int rowCount2 = Convert.ToInt32(command.ExecuteScalar());
                            Tappointmentlbl.Text = rowCount2.ToString();



                            // get total prescription count***********************

                            command.CommandText = "SELECT COUNT(*) FROM prescriptionTable";
                            int rowCount3 = Convert.ToInt32(command.ExecuteScalar());
                            Tprescriptionslbl.Text = rowCount3.ToString();



                            // get total revenue amount***********************
                            command.CommandText = "SELECT SUM(Bill) FROM prescriptionTable";

                            // Execute the command and retrieve the sum
                            object result = command.ExecuteScalar();
                            if (result != null && result != DBNull.Value)
                            {
                                int sum = Convert.ToInt32(result);

                                // Display the sum in the label control
                                Trevenuelbl.Text = sum.ToString();
                            }
                            else
                            {
                                // Handle the case when the sum is null or DBNull.Value
                                Trevenuelbl.Text = "0";
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error retrieving name: " + ex.Message);
                        }
                        finally
                        {
                            // Close the connection
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {


        }

        private void Tappointmentlbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
        }
    }
}
