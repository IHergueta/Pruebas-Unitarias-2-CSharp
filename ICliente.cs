using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public interface ICliente
    {
        void SetNombre(string nombre);
        void SetApellidos(string apellidos);
        void Setdni(string dni);
        void SetMascotas(List<IMascota> mascotas);
        void Adoptar(IMascota m);
        string getNombre();
        string getApellidos();
        string getDni();
        List<IMascota> getMascotas();
        void EjercitarMascota(IMascota m, string juego);
        void VacunarMascota(IMascota m, string v, IVeterinario e);
        void Premiar(IMascota m, string premio);
    }
}
