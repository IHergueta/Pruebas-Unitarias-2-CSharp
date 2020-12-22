using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
    public class Cliente : ICliente
    {
        private string nombre;
        private string apellidos;
        private string dni;
        private List<IMascota> mascotas;
            
        public Cliente(string nombre, string dni, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.mascotas = new List<IMascota>();
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }
        public void Setdni(string dni)
        {
            this.dni = dni;
        }
        public void SetMascotas(List<IMascota> mascotas)
        {
            this.mascotas = mascotas;
        }
        public void Adoptar (IMascota m)
        {
            this.mascotas.Add(m);
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellidos()
        {
            return this.apellidos;
        }
        public string getDni()
        {
            return this.dni;
        }
        public List<IMascota> getMascotas()
        {
            return this.mascotas;
        }

        //El método EjercitarMascota recibe un objeto mascota y una cadena (juego).
        //Invoca al método Jugar de la mascota (con el juego indicado) y devuelve una excepción con un mensaje
        //que indica si se ha ejercitado con el juego o no
        public void EjercitarMascota(IMascota m, string juego)
        {
            bool exito = m.Jugar(juego);
            if (exito)
            {
                throw new Exception("Se ha ejercitado");
            }
            else
            {
                throw new Exception("No se ha ejercitado");
            }
        }


        //El método VacunarMascota recibe dos objetos (veterinario y mascota) y una cadena (vacuna)
        //y llama al método PonerVacuna del veterinario con la mascota y la vacuna
        public void VacunarMascota(IMascota m, string v, IVeterinario e)
        {
            e.PonerVacuna(m, v);
        }

        //El método Premiar recibe un objeto mascota un una cadena, e invoca al método SeRelaja de 
        //la mascota con el premio (cadena recibida)
        public void Premiar(IMascota m, string premio)
        {
            m.SeRelaja(premio);
        }

    }
}
