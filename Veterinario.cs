using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClínicaVeterinaria
{
   public class Veterinario : IVeterinario
    {
        string nombre;
        string premioUsado ="";

        public Veterinario (string nombre)
        {
            this.nombre = nombre;
        }
        public void SetNombre(string n)
        {
            this.nombre = n;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public void SetpremioUsado(string premio)
        {
            this.premioUsado = premio;
        }
        public string GetpremioUsado()
        {
            return this.premioUsado;
        }

        //El método PonerVacuna recibe un objeto (mascota) y una cadena (vacuna), y devuelve true o false
        //dependiendo de si la mascota se ha podido vacunar.
        public bool PonerVacuna(IMascota m, string v)
        {
            while (!Premiar(m, this.premioUsado));
            try
            {
                m.Vacunar(v);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //El método Premiar recibe un objeto (mascota) y una cadena (premio)
        //Invoca al método SeRelaja de la mascota usando el premio y devuelve lo que devuelva dicho método
        private bool Premiar (IMascota m, string premio)
        {
            return m.SeRelaja(premio);
        }
    }
}
