using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Net.PeerToPeer.Collaboration;
using System.Windows.Forms;

namespace CapaDatos
{
    public class CAPA_DATOS
    {

        SqlConnection Conn =
      new SqlConnection(ConfigurationManager.ConnectionStrings["Con"].ConnectionString);


        public DataTable D_listado()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_list", Conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                //llena la tabla de datos con los datos anteriormente recibidos
                da.Fill(dt);
                //retorna los datos ya almacenados en cada campo del dataTable
                return dt;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public DataTable BuscarEnAgenda(string Buscar)
        {
            DataTable resultados = new DataTable();

            using (SqlCommand command = new SqlCommand("sp_buscar", Conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@BUSCAR", Buscar);


                try
                {
                    Conn.Open();
                    
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultados);
                        }
                    
                    
                }
                catch (SqlException ex)
                {
                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close();
            return resultados;
        }
        //Metodo para Ingresar datos 
        public void AgregarDatos(CAPA_ENTIDAD Y)
        {
            //string query = "INSERT INTO agenda#2 (Titulo, Fecha, Categoria, Descripcion) VALUES (@Titulo, @Fecha, @Categoria, @Descripcion)";
            string query = "sp_Agregar22";
            using (SqlCommand command = new SqlCommand(query, Conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                //command.Parameters.AddWithValue("@ID", Y.ID);
                command.Parameters.AddWithValue("@Titulo", Y.Titulo);
                command.Parameters.AddWithValue("@Fecha", Y.Fecha);
                command.Parameters.AddWithValue("@Categoria", Y.Categoria);
                command.Parameters.AddWithValue("@Descripcion", Y.Descripcion);

                try
                {
                    Conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                    // Manejar la excepción aquí según tus necesidades
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            Conn.Close() ;
        }

        //metodo para actualizar datos
        public void Actualizar(CAPA_ENTIDAD Y)
        {
                string query = "sp_ActualizarAgenda2";

                using (SqlCommand command = new SqlCommand(query, Conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Y.ID);
                    command.Parameters.AddWithValue("@Titulo", Y.Titulo);
                    command.Parameters.AddWithValue("@Fecha", Y.Fecha);
                    command.Parameters.AddWithValue("@Categoria", Y.Categoria);
                    command.Parameters.AddWithValue("@Descripcion", Y.Descripcion);

                    try
                    {
                        Conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Manejar la excepción aquí según tus necesidades
                        Console.WriteLine("Error de base de datos: " + ex.Message);
                    }
                }
                Conn.Close();
        }


        public void Borrar(CAPA_ENTIDAD Y)
        {
            try
            {
                Conn.Open();

                using (SqlCommand command = new SqlCommand("sp_BorrarAgenda2", Conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID", Y.ID);
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                // Manejar la excepción aquí según tus necesidades
                Console.WriteLine("Error de base de datos: " + ex.Message);
            }
            Conn.Close ();
        }
    }
}
