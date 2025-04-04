// Clase que maneja la centralita
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;

public class Centralita
{
    private List<Llamada> llamadas;
    private readonly string connectionString = "Server=tcp:centralita-server.database.windows.net,1433;Initial Catalog=BD-Centralita;Persist Security Info=False;User ID=Admin-Centralita31;Password=Centralita-server;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

    public Centralita()
    {
        llamadas = new List<Llamada>();
        CargarLlamadasDesdeBD();
    }

    public void RegistrarLlamada(Llamada llamada)
    {
        llamadas.Add(llamada);
        GuardarLlamadaEnBD(llamada);
        MostrarLlamadas();
    }

    private void GuardarLlamadaEnBD(Llamada llamada)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Llamadas (NumeroOrigen, NumeroDestino, Duracion, Costo) VALUES (@origen, @destino, @duracion, @costo)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@origen", llamada.Origen);
                command.Parameters.AddWithValue("@destino", llamada.Destino);
                command.Parameters.AddWithValue("@duracion", llamada.Duracion);
                command.Parameters.AddWithValue("@costo", llamada.CalcularCosto());
                command.ExecuteNonQuery();
            }
        }
    }

    private void CargarLlamadasDesdeBD()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT NumeroOrigen, NumeroDestino, Duracion, Costo FROM Llamadas";
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Origen: {reader["NumeroOrigen"]}, Destino: {reader["NumeroDestino"]}, " +
                                      $"Duración: {reader["Duracion"]} seg, Costo: {reader["Costo"]:C}");
                }
            }
        }
    }

    public void MostrarLlamadas()
    {
        Console.WriteLine("Resumen de Llamadas:");
        CargarLlamadasDesdeBD();
    }
}