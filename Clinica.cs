using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public class Clinica : IClinica
    {

       
        public List<ICliente> clientes = new List<ICliente>();
        private List<IVeterinario> veterinarios = new List<IVeterinario>();

        public Clinica(List<ICliente> clientes, List<IVeterinario> veterinarios)
        {
            this.clientes = clientes;
            this.veterinarios = veterinarios;
        }

        public Clinica()
        {
            
        }

        public List<ICliente> getClientes()
        {
            return clientes;
        }

        public List<IVeterinario> getVeterinario()
        {
            return veterinarios;
        }
        public void AltaCliente(ICliente c)
        {
            
            clientes.Add (c);
        }
        public void AltaVeterinario(IVeterinario v)
        {
            veterinarios.Add(v);
        }
    }
}
