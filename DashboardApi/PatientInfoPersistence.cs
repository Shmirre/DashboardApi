using System;
using System.Collections;
using System.Configuration;
using DashboardApi.Models;

namespace DashboardApi
{
    public class PatientInfoPersistence
    {
        // Get All The Patients (Select *)
        public ArrayList GetPatients()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            //string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;
            string myConnectionString = "Server=localhost;uid=root;database=dashboard";
            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {

                conn.ConnectionString = myConnectionString;
                conn.Open();

                ArrayList patientArray = new ArrayList();

                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM patientinfo";

                // Prepare Statement
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                // Execute Statement
                mySQLReader = cmd.ExecuteReader();

                while (mySQLReader.Read())
                {
                    PatientInfo p = new PatientInfo
                    {
                        PatientId = mySQLReader.GetInt32(0),
                        Firstname = mySQLReader.GetString(1),
                        Lastname = mySQLReader.GetString(2),
                        PrimaryDoctor = mySQLReader.GetString(3),
                        SecondaryDoctor = mySQLReader.GetString(4),
                        PhoneNumber = mySQLReader.GetString(5),
                        Street = mySQLReader.GetString(6),
                        Number = mySQLReader.GetString(7),
                        PostalCode = mySQLReader.GetString(8),
                        City = mySQLReader.GetString(9),
                        EmergencyContact = mySQLReader.GetString(10),
                        EmergencyContactPhone = mySQLReader.GetString(11),
                        Sex = mySQLReader.GetString(12),
                        Weight = mySQLReader.GetString(13),
                        Height = mySQLReader.GetString(14),
                        Department = mySQLReader.GetString(15),
                    };

                    patientArray.Add(p);
                }

                return patientArray;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        // Get A Specific Patient
        public PatientInfo GetPatient(long id)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                PatientInfo p = new PatientInfo();
                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM patientinfo WHERE patientid = " + id.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    p.PatientId = mySQLReader.GetInt32(0);
                    p.Firstname = mySQLReader.GetString(1);
                    p.Lastname = mySQLReader.GetString(2);
                    p.PrimaryDoctor = mySQLReader.GetString(3);
                    p.SecondaryDoctor = mySQLReader.GetString(4);
                    p.PhoneNumber = mySQLReader.GetString(5);
                    p.Street = mySQLReader.GetString(6);
                    p.Number = mySQLReader.GetString(7);
                    p.PostalCode = mySQLReader.GetString(8);
                    p.City = mySQLReader.GetString(9);
                    p.EmergencyContact = mySQLReader.GetString(10);
                    p.EmergencyContactPhone = mySQLReader.GetString(11);
                    p.Sex = mySQLReader.GetString(12);
                    p.Weight = mySQLReader.GetString(13);
                    p.Height = mySQLReader.GetString(14);
                    p.Department = mySQLReader.GetString(15);

                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
        
        // Get A Specific Patient by Department
        public PatientInfo GetPatientByDepartment(string department)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                PatientInfo p = new PatientInfo();
                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM patientinfo WHERE department = " + department.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    p.PatientId = mySQLReader.GetInt32(0);
                    p.Firstname = mySQLReader.GetString(1);
                    p.Lastname = mySQLReader.GetString(2);
                    p.PrimaryDoctor = mySQLReader.GetString(3);
                    p.SecondaryDoctor = mySQLReader.GetString(4);
                    p.PhoneNumber = mySQLReader.GetString(5);
                    p.Street = mySQLReader.GetString(6);
                    p.Number = mySQLReader.GetString(7);
                    p.PostalCode = mySQLReader.GetString(8);
                    p.City = mySQLReader.GetString(9);
                    p.EmergencyContact = mySQLReader.GetString(10);
                    p.EmergencyContactPhone = mySQLReader.GetString(11);
                    p.Sex = mySQLReader.GetString(12);
                    p.Weight = mySQLReader.GetString(13);
                    p.Height = mySQLReader.GetString(14);
                    p.Department = mySQLReader.GetString(15);

                    return p;
                }
                else
                {
                    return null;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool DeletePatient(long id)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                PatientInfo p = new PatientInfo();
                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                //Get The Patient with that ID (For Deleting)
                String sqlString = "SELECT * FROM patientinfo WHERE patientid = " + id.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    mySQLReader.Close();

                    // Delete the Patient with the id that was found
                    sqlString = "DELETE FROM patientinfo WHERE patientid = " + id.ToString();
                    cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdatePatient(long id, PatientInfo patientToSave)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString; 

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            try
            {

                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                //Get The Patient with that ID (For Deleting)
                String sqlString = "SELECT * FROM patientinfo WHERE patientid = " + id.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    mySQLReader.Close();

                    // Delete the Patient with the id that was found
                    sqlString = "UPDATE patientinfo" +
                                " SET firstname='" + patientToSave.Firstname + "'," +
                                " lastname='" + patientToSave.Lastname + "'," +
                                " primarydoctor='" + patientToSave.PrimaryDoctor + "'," +
                                " secondarydoctor='" + patientToSave.SecondaryDoctor + "'," +
                                " phonenumber='" + patientToSave.PhoneNumber + "'," +
                                " street='" + patientToSave.Street + "'," +
                                " number='" + patientToSave.Number + "'," +
                                " postalcode='" + patientToSave.PostalCode + "'," +
                                " city='" + patientToSave.City + "'," +
                                " emergencycontact='" + patientToSave.EmergencyContact + "'," +
                                " emergencycontactphone='" + patientToSave.EmergencyContactPhone + "'," +
                                " sex='" + patientToSave.Sex + "'," +
                                " weight='" + patientToSave.Weight + "'," +
                                " height='" + patientToSave.Height + "'," +
                                " department='" + patientToSave.Department + "'" +
                                " WHERE patientid = " + id.ToString();

                    cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public long SavePatientInfo(PatientInfo patientToSave)
        {

            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                String sqlString = "INSERT INTO patientinfo (firstname, lastname, primarydoctor, secondarydoctor, phonenumber," +
                                   " street, number, postalcode, city, emergencycontact, emergencycontactphone, sex, weight, height, department) VALUES " +
                                   "('" + patientToSave.Firstname + "','"
                                   + patientToSave.Lastname + "','"
                                   + patientToSave.PrimaryDoctor + "','"
                                   + patientToSave.SecondaryDoctor + "','"
                                   + patientToSave.PhoneNumber + "','"
                                   + patientToSave.Street + "','"
                                   + patientToSave.Number + "','"
                                   + patientToSave.PostalCode + "','"
                                   + patientToSave.City + "','"
                                   + patientToSave.EmergencyContact + "','"
                                   + patientToSave.EmergencyContactPhone + "','"
                                   + patientToSave.Sex + "','"
                                   + patientToSave.Weight + "','"
                                   + patientToSave.Height + "','"
                                   + patientToSave.Department + "')";

                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
                long id = cmd.LastInsertedId;
                return id;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}