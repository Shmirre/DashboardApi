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
                        Id = mySQLReader.GetInt32(0),
                        Afdeling = mySQLReader.GetString(1),
                        PatientId = mySQLReader.GetInt32(2),
                        Observationdate = mySQLReader.GetDateTime(3),
                        Ewsprocedure = mySQLReader.GetString(4),
                        Ews_total = mySQLReader.GetInt32(5),
                        Sbp = mySQLReader.GetFloat(6),
                        Sbp_score = mySQLReader.GetInt32(7),
                        Loc = mySQLReader.GetString(8),
                        Loc_score = mySQLReader.GetInt32(9),
                        Spo2 = mySQLReader.GetFloat(10),
                        Spo2_score = mySQLReader.GetInt32(11),
                        Add_o2 = mySQLReader.GetString(12),
                        Add_o2_score = mySQLReader.GetInt32(13),
                        Hr = mySQLReader.GetInt32(14),
                        Hr_score = mySQLReader.GetInt32(15),
                        Rr = mySQLReader.GetInt32(16),
                        Rr_score = mySQLReader.GetInt32(17),
                        Temp = mySQLReader.GetFloat(18),
                        Temp_score = mySQLReader.GetInt32(19),
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
        public Observations GetObservation(long id)
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
                        Id = mySQLReader.GetInt32(0),
                        Afdeling = mySQLReader.GetString(1),
                        PatientId = mySQLReader.GetInt32(2),
                        Observationdate = mySQLReader.GetDateTime(3),
                        Ewsprocedure = mySQLReader.GetString(4),
                        Ews_total = mySQLReader.GetInt32(5),
                        Sbp = mySQLReader.GetFloat(6),
                        Sbp_score = mySQLReader.GetInt32(7),
                        Loc = mySQLReader.GetString(8),
                        Loc_score = mySQLReader.GetInt32(9),
                        Spo2 = mySQLReader.GetFloat(10),
                        Spo2_score = mySQLReader.GetInt32(11),
                        Add_o2 = mySQLReader.GetString(12),
                        Add_o2_score = mySQLReader.GetInt32(13),
                        Hr = mySQLReader.GetInt32(14),
                        Hr_score = mySQLReader.GetInt32(15),
                        Rr = mySQLReader.GetInt32(16),
                        Rr_score = mySQLReader.GetInt32(17),
                        Temp = mySQLReader.GetFloat(18),
                        Temp_score = mySQLReader.GetInt32(19),
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
                        Id = mySQLReader.GetInt32(0),
                        Afdeling = mySQLReader.GetString(1),
                        PatientId = mySQLReader.GetInt32(2),
                        Observationdate = mySQLReader.GetDateTime(3),
                        Ewsprocedure = mySQLReader.GetString(4),
                        Ews_total = mySQLReader.GetInt32(5),
                        Sbp = mySQLReader.GetFloat(6),
                        Sbp_score = mySQLReader.GetInt32(7),
                        Loc = mySQLReader.GetString(8),
                        Loc_score = mySQLReader.GetInt32(9),
                        Spo2 = mySQLReader.GetFloat(10),
                        Spo2_score = mySQLReader.GetInt32(11),
                        Add_o2 = mySQLReader.GetString(12),
                        Add_o2_score = mySQLReader.GetInt32(13),
                        Hr = mySQLReader.GetInt32(14),
                        Hr_score = mySQLReader.GetInt32(15),
                        Rr = mySQLReader.GetInt32(16),
                        Rr_score = mySQLReader.GetInt32(17),
                        Temp = mySQLReader.GetFloat(18),
                        Temp_score = mySQLReader.GetInt32(19),
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