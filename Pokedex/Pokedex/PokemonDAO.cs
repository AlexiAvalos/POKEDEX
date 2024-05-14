using System.Collections.Generic;
using System.Data.SqlClient;

public class PokemonDAO
{
    private string connectionString;

    public PokemonDAO(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<string> ObtenerNombresPokemon()
    {
        List<string> nombresPokemon = new List<string>();

        string query = "SELECT Nombre FROM Pokemon";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nombresPokemon.Add(reader["Nombre"].ToString());
            }
            reader.Close();
        }

        return nombresPokemon;
    }
    public List<string> ObtenerNombresRegiones()
    {
        List<string> nombresRegiones = new List<string>();

        string query = "SELECT Nombre FROM Regiones";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nombresRegiones.Add(reader["Nombre"].ToString());
            }
            reader.Close();
        }

        return nombresRegiones;
    }
    public List<string> ObtenerNombresObjetosEvolutivos()
    {
        List<string> nombresObjetosEvolutivos = new List<string>();

        string query = "SELECT Nombre FROM Objectos_Evolutivos"; // Ajusta la consulta según la estructura de tu base de datos

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string nombre = reader["Nombre"].ToString();
                nombresObjetosEvolutivos.Add(nombre);
            }
            reader.Close();
        }

        return nombresObjetosEvolutivos;
    }
    public List<string> ObtenerNombresTipos()
    {
        List<string> nombresTipos = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT Nombre FROM Tipos";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nombresTipos.Add(reader["Nombre"].ToString());
            }
        }

        return nombresTipos;
    }

}
