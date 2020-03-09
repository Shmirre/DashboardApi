using System;
using System.Collections;
using System.Configuration;
using DashboardApi.Models;

namespace DashboardApi
{
    public class ObservationPersistence
    {
        public ArrayList GetObservations()
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {

                conn.ConnectionString = myConnectionString;
                conn.Open();

                ArrayList observationArray = new ArrayList();

                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM observations";

                // Prepare Statement
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                // Execute Statement
                mySQLReader = cmd.ExecuteReader();

                while (mySQLReader.Read())
                {
                    Observations o = new Observations
                    {
                        PatientId = mySQLReader.GetInt32(0),
                        Observationdate = mySQLReader.GetDateTime(1),
                        Ews_total = mySQLReader.GetInt32(2),
                        Sbp = mySQLReader.GetFloat(3),
                        Sbp_score = mySQLReader.GetInt32(4),
                        Loc = mySQLReader.GetString(5),
                        Loc_score = mySQLReader.GetInt32(6),
                        Spo2 = mySQLReader.GetFloat(7),
                        Spo2_score = mySQLReader.GetInt32(8),
                        Add_o2 = mySQLReader.GetString(9),
                        Add_o2_score = mySQLReader.GetInt32(10),
                        Hr = mySQLReader.GetInt32(11),
                        Hr_score = mySQLReader.GetInt32(12),
                        Rr = mySQLReader.GetInt32(13),
                        Rr_score = mySQLReader.GetInt32(14),
                        Temp = mySQLReader.GetFloat(15),
                        Temp_score = mySQLReader.GetInt32(16),
                    };

                    observationArray.Add(o);
                }

                return observationArray;
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

        // Get A Specific Observation
        /*public Observations GetObservation(long id)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();
            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM observations WHERE id = " + id.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    Observations o = new Observations
                    {
                        PatientId = mySQLReader.GetInt32(0),
                        Observationdate = mySQLReader.GetDateTime(1),
                        Ews_total = mySQLReader.GetInt32(2),
                        Sbp = mySQLReader.GetFloat(3),
                        Sbp_score = mySQLReader.GetInt32(4),
                        Loc = mySQLReader.GetString(5),
                        Loc_score = mySQLReader.GetInt32(6),
                        Spo2 = mySQLReader.GetFloat(7),
                        Spo2_score = mySQLReader.GetInt32(8),
                        Add_o2 = mySQLReader.GetString(9),
                        Add_o2_score = mySQLReader.GetInt32(10),
                        Hr = mySQLReader.GetInt32(11),
                        Hr_score = mySQLReader.GetInt32(12),
                        Rr = mySQLReader.GetInt32(13),
                        Rr_score = mySQLReader.GetInt32(14),
                        Temp = mySQLReader.GetFloat(15),
                        Temp_score = mySQLReader.GetInt32(16),
                    };
                    return o;
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
        */
        // Get A Specific Observation by PatientId
        public ArrayList GetObservationByPatientId(long patientId)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                ArrayList observationArray = new ArrayList();

                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                String sqlString = "SELECT * FROM observations WHERE patientid = " + patientId.ToString();

                // Prepare Statement
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                // Execute Statement
                mySQLReader = cmd.ExecuteReader();

                while (mySQLReader.Read())
                {
                    Observations o = new Observations
                    {
                        PatientId = mySQLReader.GetInt32(0),
                        Observationdate = mySQLReader.GetDateTime(1),
                        Ews_total = mySQLReader.GetInt32(2),
                        Sbp = mySQLReader.GetFloat(3),
                        Sbp_score = mySQLReader.GetInt32(4),
                        Loc = mySQLReader.GetString(5),
                        Loc_score = mySQLReader.GetInt32(6),
                        Spo2 = mySQLReader.GetFloat(7),
                        Spo2_score = mySQLReader.GetInt32(8),
                        Add_o2 = mySQLReader.GetString(9),
                        Add_o2_score = mySQLReader.GetInt32(10),
                        Hr = mySQLReader.GetInt32(11),
                        Hr_score = mySQLReader.GetInt32(12),
                        Rr = mySQLReader.GetInt32(13),
                        Rr_score = mySQLReader.GetInt32(14),
                        Temp = mySQLReader.GetFloat(15),
                        Temp_score = mySQLReader.GetInt32(16),
                    };

                    observationArray.Add(o);
                }

                return observationArray;
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

        public bool deleteObservation(long id)
        {
            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString = ConfigurationManager.ConnectionStrings["AzureDB"].ConnectionString;

            conn = new MySql.Data.MySqlClient.MySqlConnection();

            try
            {
                conn.ConnectionString = myConnectionString;
                conn.Open();

                Observations o = new Observations();
                MySql.Data.MySqlClient.MySqlDataReader mySQLReader = null;

                // Get The Observation with that ID (For Deleting)
                String sqlString = "SELECT * FROM observations WHERE id = " + id.ToString();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sqlString, conn);

                mySQLReader = cmd.ExecuteReader();

                if (mySQLReader.Read())
                {
                    mySQLReader.Close();

                    // Delete the Observation with the id that was found
                    sqlString = "DELETE FROM observations WHERE id = " + id.ToString();
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
    }
}