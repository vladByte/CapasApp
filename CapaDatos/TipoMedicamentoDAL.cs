﻿using CapaEntidad;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {
        public List<TipoMedicamentoCLS> ListarMedicamentos()
        {

            List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
            lista.Add(new TipoMedicamentoCLS { 
                IdTipoMedicamento = 1, 
                Nombre = "Analgesicos",
                Descripcion = "Alivia el resfriado comun"
                
            }); 

            lista.Add(new TipoMedicamentoCLS { 
                IdTipoMedicamento = 2, 
                Nombre = "Anti Alergicos",
                Descripcion = "Alivia el resfriado comun"
                
            }); 

            return lista;
        }
    }
}