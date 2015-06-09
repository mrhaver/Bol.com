using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.DataAccess;
using System.Configuration;
using System.Data;

namespace Bol_Applicatie
{
    public class DatabaseKoppeling
    {
        private OracleConnection conn;
        private OracleCommand command;
        string connectionstring;
        public DatabaseKoppeling()
        {
            string user = "BOL";
            string pw = "LOB";
            conn = new OracleConnection();
            command = conn.CreateCommand();
            conn.ConnectionString = "User Id=" + user + ";Password=" + pw + ";Data Source=" + " //localhost:1521/xe" + ";"; 
        }

        public void TestConnection()
        {           
            conn.Open();           
        }

        #region Inloggen
        public bool LogIn(string gebruikersNaam, string wachtWoord, out string error)
        {
            try
            {
                error = "";
                conn.Open();
                // query van alle plaatsen met de eventueel bijbehorende
                // hoofdboekers
                string query = "SELECT * FROM ACCOUNT";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                // dataReader gaat record voor record omlaag totdat 
                // er niets meer is.
                while (dataReader.Read())
                {
                    // getal tussen haakjes is de gewenste kolom :D
                    if(Convert.ToString(dataReader["GEBRUIKERSNAAM"]) == gebruikersNaam)
                    {
                        if(Convert.ToString(dataReader["WACHTWOORD"]) == wachtWoord)
                        {
                            error = "";
                            return true;
                        }
                        else
                        {
                            error = "Wachtwoord Ongeldig";
                            return false;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                error = ex.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }
            // er is niets gevonden
            error = "Gebruikersnaam niet gevonden";
            return false;
        }
        #endregion

        #region Aanmaken
        public bool MaakGebruiker(string voornaam, string achternaam, 
            string geslacht, string mailadres, string gebruikersnaam,
            string wachtwoord, int budget, out string error)
        {
            try
            {
                command = new OracleCommand("MAAKGEBRUIKER", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_VOORNAAM", OracleDbType.Varchar2).Value = voornaam;
                command.Parameters.Add("P_ACHTERNAAM", OracleDbType.Varchar2).Value = achternaam;
                command.Parameters.Add("P_GESLACHT", OracleDbType.Varchar2).Value = geslacht;
                command.Parameters.Add("P_MAILADRES", OracleDbType.Varchar2).Value = mailadres;
                command.Parameters.Add("P_GEBRUIKERSNAAM", OracleDbType.Varchar2).Value = gebruikersnaam;
                command.Parameters.Add("P_WACHTWOORD", OracleDbType.Varchar2).Value = wachtwoord;
                command.Parameters.Add("P_BUDGET", OracleDbType.Int32).Value = budget;

                conn.Open();
                OracleDataAdapter da = new OracleDataAdapter(command);
                command.ExecuteNonQuery();
                error = "";
                return true;
            }
            catch(Exception ex)
            {
                error = ex.ToString();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        public List<Categorie> GeefBovenCategorieen(out string error)
        {
            List<Categorie> categorieen = new List<Categorie>();
            error = "";
            try
            {
                conn.Open();
                string query = "SELECT * FROM CATEGORIE WHERE BOVENCATEGORIE_ID IS NULL";
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if(dataReader[1] is DBNull)
                    {
                        categorieen.Add(new Categorie(Convert.ToInt32(dataReader[0]), 0, Convert.ToString(dataReader[2])));
                    }
                    else
                    {                       
                        categorieen.Add(new Categorie(Convert.ToInt32(dataReader[0]), Convert.ToInt32(dataReader[1]), Convert.ToString(dataReader[2])));
                    }
                }
                return categorieen;
            }
            catch (Exception ex)
            {
                error = "Categorieën niet kunnen vinden";
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Categorie> GeefOnderCategorieen(string categorieNaam, out string error)
        {
            List<Categorie> categorieen = new List<Categorie>();
            error = "";
            try
            {
                conn.Open();
                string query = "SELECT * FROM CATEGORIE WHERE BOVENCATEGORIE_ID IN ( SELECT ID FROM CATEGORIE WHERE NAAM = '" + categorieNaam + "')";
                //command.Parameters.Add(new OracleParameter("@NAAM", categorieNaam));
                command = new OracleCommand(query, conn);
                OracleDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if (dataReader[1] is DBNull)
                    {
                        categorieen.Add(new Categorie(Convert.ToInt32(dataReader[0]), 0, Convert.ToString(dataReader[2])));
                    }
                    else
                    {
                        categorieen.Add(new Categorie(Convert.ToInt32(dataReader[0]), Convert.ToInt32(dataReader[1]), Convert.ToString(dataReader[2])));
                    }
                }
                return categorieen;
            }
            catch (Exception ex)
            {
                error = "Categorieën niet kunnen vinden";
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
        


}