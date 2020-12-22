using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public interface IMascota
    {
        void SetNombre(string n);
        void setFechaNacimiento(string fecha);
        string GetNombre();
        string GetFechaNacimiento();
        bool Jugar(string juego);
        void Vacunar(string v);
        bool SeRelaja(string premio);
        bool YaVacunado(string v);
    }
}
