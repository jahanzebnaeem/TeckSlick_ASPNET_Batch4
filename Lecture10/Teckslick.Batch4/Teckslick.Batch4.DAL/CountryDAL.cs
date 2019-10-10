using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teckslick.Batch4.Common;

namespace Teckslick.Batch4.DAL
{
    public class CountryDAL
    {
        #region Queries
        private string selectAll = "Select * From Country";
        #endregion

        #region Functions
        /// <summary>
        /// This function is used to get all the values from Countries DB
        /// <para>No Parameters required</para>
        /// </summary>
        /// <returns>List of all the Countries present</returns>
        public List<Country> GetCountries()
        {
            // Complete logic to return countries
            SqlConnection connection = DALHelper.GetSqlConnection();
            SqlCommand command = new SqlCommand(selectAll, connection);
            SqlDataReader reader = null;
            List<Country> countries = null;
            connection.Open();
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    countries = new List<Country>();
                    while(reader.Read())
                    {
                        Country country = new Country(Convert.ToInt32(reader["ID"].ToString()), Convert.ToString(reader["Name"].ToString()));
                        countries.Add(country);
                    }
                }
            }
            finally
            {
                // close reader
                if (reader != null)
                { 
                    reader.Close();
                }
                connection.Close();
                if (countries != null)
                {
                    countries.TrimExcess();
                }
            }
            // Logic to get countries
            return countries;
        }
        #endregion
    }
}
