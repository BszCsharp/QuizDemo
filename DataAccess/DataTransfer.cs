using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;


namespace DataAccess
{
    /// <summary>
    /// Führt physische Datenzugriffe durch
    /// </summary>
    public class DataTransfer
    {
        OleDbConnection con = null;
        List<Kunde> lstKunde = null;
        private bool OpenConnection()
        {
            Boolean result = true;
            con = new OleDbConnection(Settings1.Default.ConString);

            try
            {
                con.Open();
            }
            catch 
            {

                result = false;
            }
            return result;
        }
        
        /// <summary>
        ///  Holt die Kundendaten aus der Datenquelle
        /// </summary>
        /// <returns>Gibt bei Erfolg eine gefüllte List mit Kundennobjekten zurück</returns>
        public List<Kunde> getAlleKunden()
        {
           
            
            if(con == null)
            {
                if(!OpenConnection())
                {
                    return null;
                }
            }
            try
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "Select * from Kunden";
                OleDbDataReader reader = cmd.ExecuteReader();
                lstKunde = new List<Kunde>();
                while(reader.Read())
                {
                    int i = 0;
                    Kunde k = new Kunde();
                    k.KundenID = (String)reader.GetValue(i++);
                    k.Name = (String)reader.GetValue(i++);
                    k.VName = (String)reader.GetValue(i++);
                    k.GebDat = (String)reader.GetValue(i++);
                    lstKunde.Add(k);
                }
                return lstKunde;
            }
            catch 
            {

                return null;
            }

        }
    }
}
