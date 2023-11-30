using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace dnd
{
    class DBConnection
    {
        //provate object to the class itself
        private static DBConnection instance;

        //Conection string
        private string connStr;

        //connection to the DB
        private SqlConnection connTOdb;

        ///constructor
        ///
        private DBConnection()
        {
            connStr = Properties.Settings.Default.dnddb;
        
        }

        public static DBConnection getInstanceOfDBConnection()
        {
            if (instance == null)
                instance = new DBConnection();
            return instance;
        }

      



        //Method to save a new campaing to the database
        public void saveNewCampaing(string sqlQuery, string name, string description)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("name",name));
                sqlCommand.Parameters.Add(new SqlParameter("description", description));

                sqlCommand.ExecuteNonQuery();
            }
        }


        //return a data set based on a SQL query
        public DataSet getDataSet(string sqlQuery)
        {
            DataSet dataset = new DataSet();

            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();

                //Create the object dataAdacter to send the query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery,connTOdb);

                dataAdapter.Fill(dataset);
            }

                return dataset;

        }


        public DataSet getDATAFromID(string sqlQuery,int id)
        {
            DataSet dataset = new DataSet();

            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                

                //Create the object dataAdacter to send the query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connTOdb);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id",id);
               
                dataAdapter.Fill(dataset);
            }

            return dataset;

        }

       

        public DataSet getDATAfromName(string sqlQuery, string name)
        {
            DataSet dataset = new DataSet();

            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();


                //Create the object dataAdacter to send the query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connTOdb);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@name", name);

                dataAdapter.Fill(dataset);
            }

            return dataset;

        }

        public void updatecampaing(string sqlQuery, string name, string description,int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("name", name));
                sqlCommand.Parameters.Add(new SqlParameter("description", description));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));

                sqlCommand.ExecuteNonQuery();
            }
        }

        //Connections for character management
       

        public void saveNewCharacter(string sqlQuery,string name,int AC,int IB,int HP, string Specie, int Campaing_ID)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Specie",Specie));
                sqlCommand.Parameters.Add(new SqlParameter("Campaing_ID", Campaing_ID));
                sqlCommand.Parameters.Add(new SqlParameter("AC", AC));
                sqlCommand.Parameters.Add(new SqlParameter("name", name));
                sqlCommand.Parameters.Add(new SqlParameter("HP", HP));
                sqlCommand.Parameters.Add(new SqlParameter("IB", IB));





                sqlCommand.ExecuteNonQuery();
            }
        }

        public void saveNewClass(string sqlQuery, string class_name , int class_level, int character_id, string subclass)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("class_name", class_name));
                sqlCommand.Parameters.Add(new SqlParameter("class_level", class_level));
                sqlCommand.Parameters.Add(new SqlParameter("Character_ID", character_id));
                sqlCommand.Parameters.Add(new SqlParameter("subclass", subclass));



                sqlCommand.ExecuteNonQuery();
            }
        }

        
        public void updatecharcter(string sqlQuery, string name, int HP, int AC, int IB,string Specie, int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("HP", HP));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.Parameters.Add(new SqlParameter("AC", AC));
                sqlCommand.Parameters.Add(new SqlParameter("IB", IB));
                sqlCommand.Parameters.Add(new SqlParameter("Specie", Specie));

                sqlCommand.ExecuteNonQuery();
            }
        }
        

        public void updateclass(string sqlQuery, string class_name, string subclass, int class_level,int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("class_level", class_level));
                sqlCommand.Parameters.Add(new SqlParameter("class_name", class_name));
                sqlCommand.Parameters.Add(new SqlParameter("subclass", subclass));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));


                sqlCommand.ExecuteNonQuery();
            }
        }

        public void saveNewMonster(string sqlQuery, string name, int AC, int IB, int HP, string CR, Image statblock)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("CR", CR));
                sqlCommand.Parameters.Add(new SqlParameter("AC", AC));
                sqlCommand.Parameters.Add(new SqlParameter("name", name));
                sqlCommand.Parameters.Add(new SqlParameter("HP", HP));
                sqlCommand.Parameters.Add(new SqlParameter("IB", IB));

                //Transform the image to the correct format
                //https://www.youtube.com/watch?v=Is7INDgHuX4
                using (MemoryStream ms = new MemoryStream())
                {
                    statblock.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    sqlCommand.Parameters.Add(new SqlParameter("statblock", ms.ToArray()));
                }
           
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void updatemonster(string sqlQuery, string name, int HP, int AC, int IB, string CR, int id,Image statblock)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Name", name));
                sqlCommand.Parameters.Add(new SqlParameter("HP", HP));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));
                sqlCommand.Parameters.Add(new SqlParameter("AC", AC));
                sqlCommand.Parameters.Add(new SqlParameter("IB", IB));
                sqlCommand.Parameters.Add(new SqlParameter("CR", CR));
                using (MemoryStream ms = new MemoryStream())
                {
                    statblock.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    sqlCommand.Parameters.Add(new SqlParameter("statblock", ms.ToArray()));
                }

                sqlCommand.ExecuteNonQuery();



                sqlCommand.ExecuteNonQuery();
            }
        }

        public void saveNewEncounter(string sqlQuery, string name, string description, int turn, int round, int campaing_id, string difficulty)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("turn", turn));
                sqlCommand.Parameters.Add(new SqlParameter("round", round));
                sqlCommand.Parameters.Add(new SqlParameter("name", name));
                sqlCommand.Parameters.Add(new SqlParameter("description", description));
                sqlCommand.Parameters.Add(new SqlParameter("campaing_id", campaing_id));
                sqlCommand.Parameters.Add(new SqlParameter("difficulty", difficulty));
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void saveNewMonsterList(string sqlQuery, int Encounter_ID, int Monster_ID)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Encounter_ID", Encounter_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Monster_ID", Monster_ID));
               
                sqlCommand.ExecuteNonQuery();
            }
        }
        public DataSet getDATAFromCampaingID(string sqlQuery, int id)
        {
            DataSet dataset = new DataSet();

            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();


                //Create the object dataAdacter to send the query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connTOdb);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@id", id);

                dataAdapter.Fill(dataset);
            }

            return dataset;

        }
        public void saveNewInitiativeCountCharacter(string sqlQuery, int Encounter_ID, int Character_Id,int initiative,int Current_HP)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Encounter_ID", Encounter_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Character_Id", Character_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Initiative", initiative));
                sqlCommand.Parameters.Add(new SqlParameter("Current_HP", Current_HP));

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void saveNewInitiativeCountMonster(string sqlQuery, int Encounter_ID, int Monster_Id, int initiative, int Current_HP)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Encounter_ID", Encounter_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Monster_Id", Monster_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Initiative", initiative));
                sqlCommand.Parameters.Add(new SqlParameter("Current_HP", Current_HP));

                sqlCommand.ExecuteNonQuery();
            }
        }
        public DataSet getDATAFromInitiativeAndEncounter_ID(string sqlQuery, int initiative,int Encounter_ID)
        {
            DataSet dataset = new DataSet();

            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();


                //Create the object dataAdacter to send the query to the DB
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, connTOdb);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Initiative", initiative);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@Encounter_ID", Encounter_ID);

                dataAdapter.Fill(dataset);
            }

            return dataset;

        }
       


       

       
        public void saveNewConditionMonster(string sqlQuery, int Encounter_ID, int Monster_Id, int Condition_Id, string Duration_Type,int Duration_Time)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Encounter_ID", Encounter_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Monster_Id", Monster_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Condition_ID", Condition_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Duration_Type", Duration_Type));
                sqlCommand.Parameters.Add(new SqlParameter("Duration_Time", Duration_Time));
              

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void updateCondition(string sqlQuery, string Duration_Type, int Duration_Time, int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command

                sqlCommand.Parameters.Add(new SqlParameter("Duration_Type", Duration_Type));
                sqlCommand.Parameters.Add(new SqlParameter("Duration_Time", Duration_Time));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void updateIni_Count(string sqlQuery, int Current_HP, int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command

               
                sqlCommand.Parameters.Add(new SqlParameter("Current_HP", Current_HP));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void update_Encounter(string sqlQuery, int turn,int round, int id)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command


                sqlCommand.Parameters.Add(new SqlParameter("turn", turn));
                sqlCommand.Parameters.Add(new SqlParameter("round", round));
                sqlCommand.Parameters.Add(new SqlParameter("id", id));

                sqlCommand.ExecuteNonQuery();
            }
        }
        public void saveNewConditionCharacter(string sqlQuery, int Encounter_ID, int Character_Id, int Condition_Id, string Duration_Type, int Duration_Time)
        {
            using (connTOdb = new SqlConnection(connStr))
            {
                //Open the connection
                connTOdb.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connTOdb);


                //set the sql command´s properties
                sqlCommand.CommandType = CommandType.Text;

                //add the parameters to the sql Command
                sqlCommand.Parameters.Add(new SqlParameter("Encounter_ID", Encounter_ID));
                sqlCommand.Parameters.Add(new SqlParameter("Character_Id", Character_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Condition_ID", Condition_Id));
                sqlCommand.Parameters.Add(new SqlParameter("Duration_Type", Duration_Type));
                sqlCommand.Parameters.Add(new SqlParameter("Duration_Time", Duration_Time));
                

                sqlCommand.ExecuteNonQuery();
            }
        }

        

    };
}

   

    
