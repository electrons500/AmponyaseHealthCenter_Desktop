
namespace AmponyaseHealthCenter_Desktop
{
    class DBConnection
    {
       

        public string GetConn()
        {
            string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=AHCDB;Integrated Security=True;Connect Timeout=15";

            return constring;
        }

    }
}
