using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class UsuarioDatos
    {
        public async Task<bool> LoginAsync(string correo, string contraseña)
        {
            bool validar = false;

            //sentencia para errores o excepciones
            try
            {
                //variable con la sencancia
                string sql = "SELECT 1 FROM usuario WHERE Correo=@Correo AND Contraseña=@Contraseña;";

                using (MySqlConnection _conexion_Ejercicio = new MySqlConnection(CadenaConexion.Cadena ))
                {
                   await _conexion_Ejercicio.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion_Ejercicio))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = correo;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar,50 ).Value = contraseña;
                        validar = Convert.ToBoolean(await comando.ExecuteScalarAsync());
                    }

                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
            return validar;
        }

        public async Task<DataTable> DevolverListaAsync()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM usuario;";

                using (MySqlConnection _conexion = new MySqlConnection(CadenaConexion.Cadena))
                {
                    await _conexion.OpenAsync();
                    using (MySqlCommand comando = new MySqlCommand(sql, _conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;
                        MySqlDataReader dr = (MySqlDataReader)await comando.ExecuteReaderAsync();
                        dt.Load(dr);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return dt;
        }
    }


}
