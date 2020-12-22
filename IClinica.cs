using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public interface IClinica
    {
        void AltaCliente(ICliente c);
        void AltaVeterinario(IVeterinario v);
        List<ICliente> getClientes();
        List<IVeterinario> getVeterinario();
    }
}
