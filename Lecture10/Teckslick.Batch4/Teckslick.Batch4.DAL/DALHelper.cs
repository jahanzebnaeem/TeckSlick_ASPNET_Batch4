namespace Teckslick.Batch4.DAL
{
    using System.Data.SqlClient;

    public class DALHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            string conString = @"Data Source=.;Initial Catalog=SalesDemoBatch4;User ID=sa;Password=1234";
            return new SqlConnection(conString);
        }
    }
}
