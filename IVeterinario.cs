using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public interface IVeterinario
    {
        void SetNombre(string n);
        string GetNombre();
        void SetpremioUsado(string premio);
        string GetpremioUsado();
        bool PonerVacuna(IMascota m, string v);
    }
}

