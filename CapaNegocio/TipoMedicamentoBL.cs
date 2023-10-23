using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class TipoMedicamentoBL
    {
        public List<TipoMedicamentoCLS> listarMedicamentos()
        {
            TipoMedicamentoDAL obj = new TipoMedicamentoDAL();

            return obj.ListarMedicamentos();
        }
    }
}