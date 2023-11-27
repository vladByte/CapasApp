using CapaEntidad;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class TipoMedicamentoDAL : CadenaDAL
    {

        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {
            List<TipoMedicamentoCLS>? lista = null;

            using (SqlConnection cnx = new SqlConnection(CadenaCnx))
            {
                try
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT idtipomedicamento,nombre,descripcion FROM TipoMedicamento WHERE bhabilitado = 1;", cnx))
                    {
                        cmd.CommandType = CommandType.Text;
                        SqlDataReader sdr =  cmd.ExecuteReader(CommandBehavior.SingleResult);

                        if (sdr != null) 
                        {
                            TipoMedicamentoCLS oTipoMedicamentoCLS;
                            lista = new List<TipoMedicamentoCLS>();

                            int posId = sdr.GetOrdinal("idtipomedicamento");
                            int posNombre = sdr.GetOrdinal("nombre");
                            int posDescripcion = sdr.GetOrdinal("descripcion");

                            while (sdr.Read()) 
                            { 
                                oTipoMedicamentoCLS = new TipoMedicamentoCLS();
                                oTipoMedicamentoCLS.IdTipoMedicamento = sdr.IsDBNull(posId) ? 0 : sdr.GetInt32(posId);
                                oTipoMedicamentoCLS.Nombre = sdr.IsDBNull(posNombre) ? "" :  sdr.GetString(posNombre);
                                oTipoMedicamentoCLS.Descripcion = sdr.IsDBNull(posDescripcion) ? "" :  sdr.GetString(posDescripcion);
                                lista.Add(oTipoMedicamentoCLS);
                            }
                            cnx.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    cnx.Close();
                    Console.WriteLine($"Error en la Conexion: {ex}");
                    lista = null;
                    
                }
            }

            return lista;
        }


        //public List<TipoMedicamentoCLS> ListarMedicamentos()
        //{

        //    List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
        //    lista.Add(new TipoMedicamentoCLS { 
        //        IdTipoMedicamento = 1, 
        //        Nombre = "Analgesicos",
        //        Descripcion = "Alivia el dolor"

        //    }); 

        //    lista.Add(new TipoMedicamentoCLS { 
        //        IdTipoMedicamento = 2, 
        //        Nombre = "Anti Alergicos",
        //        Descripcion = "Alivia el resfriado comun"

        //    });

        //    lista.Add(new TipoMedicamentoCLS { 
        //        IdTipoMedicamento = 3, 
        //        Nombre = "Antibioticos",
        //        Descripcion = "Contra patogenos e infecciones"

        //    }); 

        //    return lista;
        //}
    }
}