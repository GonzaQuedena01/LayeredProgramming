using EntityLayer;

using System.Data;
using System.Data.SQLite;
using System.Configuration;

namespace DataLayer
{
    public class DEmployee
    {
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);
        
        //obteniendo la conexión a la base de datos.
        SQLiteConnection cn = new SQLiteConnection(
            ConfigurationManager.ConnectionStrings["sqliteconex"].ConnectionString
        );

        public DataTable List()
        {
            //realizando consulta
            string query = "SELECT * FROM employees";

            //creando instancia de ejecución
            using (SQLiteCommand cmd = new SQLiteCommand(query, cn)) 
            {
                //ejecutando query enviada
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                //creando instancia de un DataTable
                DataTable dt = new DataTable();

                //abriendo conexión
                cn.Open();
                //llenando datatable
                da.Fill(dt);
                //cerrando conexión
                cn.Close();

                return dt;
            }  
        }
    
    
    }
}
