using Pokedex;
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
    public PokemonClass ObtenerPokemonPorId(int id)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
            SELECT p.*, c.Nombre AS NombreCategoria, h.Nombre AS NombreHabitat
            FROM Pokemon p
            JOIN Categoria c ON p.idCategoria = c.idCategoria
            JOIN Habitat h ON p.idHabitat = h.idHabitat
            WHERE p.IdPokemon = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new PokemonClass
                {
                    IdPokemon = reader.GetInt32(reader.GetOrdinal("IdPokemon")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    Descripcion = reader.GetString(reader.GetOrdinal("Descripcion")),
                    Tipo = string.Join(", ", ObtenerTiposPokemon(id)),
                    Altura = reader.GetDecimal(reader.GetOrdinal("Altura")).ToString(),

                    Peso = reader.GetDecimal(reader.GetOrdinal("Peso")).ToString(),

                    Salud = reader.GetInt32(reader.GetOrdinal("Salud")),
                    Ataque = reader.GetInt32(reader.GetOrdinal("Ataque")),
                    Defensa = reader.GetInt32(reader.GetOrdinal("Defensa")),
                    Habitat = reader.GetString(reader.GetOrdinal("NombreHabitat")),
                    Generacion = reader.GetInt32(reader.GetOrdinal("idGeneracion")),
                    // Agrega más propiedades según lo necesites
                };
            }
        }

        return null; // Retornar null si no se encuentra el Pokémon
    }

    private List<string> ObtenerTiposPokemon(int idPokemon)
    {
        List<string> tipos = new List<string>();

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
            SELECT t.Nombre
            FROM Tipo t
            JOIN Tipo_Pokemones tp ON t.idTipo = tp.idTipo
            WHERE tp.idPokemon = @IdPokemon";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IdPokemon", idPokemon);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tipos.Add(reader.GetString(reader.GetOrdinal("Nombre")));
            }
        }

        return tipos;
    }


}
