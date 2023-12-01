using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class SucursalDAL : CadenaDAL
    {
        public List<SucursalCLS> ListarSucursal() 
        {
            List<SucursalCLS>? lista = null;

            using (SqlConnection cnx = new SqlConnection(CadenaCnx))
            {
                try 
                {
                    cnx.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ListarSucursal",cnx))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                        if (sdr != null) 
                        {
                            SucursalCLS oSucursalCLS;
                            lista = new List<SucursalCLS>();

                            int posId = sdr.GetOrdinal("IdSucursal");
                            int posNombre = sdr.GetOrdinal("Nombre");
                            int posDireccion = sdr.GetOrdinal("Direccion");

                            while (sdr.Read()) 
                            {
                                oSucursalCLS = new SucursalCLS();
                                oSucursalCLS.IdSucursal = sdr.GetInt32(posId);
                                oSucursalCLS.Nombre = sdr.GetString(posNombre);
                                oSucursalCLS.Direccion = sdr.GetString(posDireccion);
                                lista.Add(oSucursalCLS);
                            }
                            cnx.Close();
                        }
                    }

                }catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                    cnx.Close(); 
                    lista = null; // null Significa error.
                }
            }

            return lista;
        }   

    }
}
