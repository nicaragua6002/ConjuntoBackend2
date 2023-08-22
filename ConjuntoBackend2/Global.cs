using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConjuntoBackend2
{
    public class Global
    {
        //Agregamos los valores
        public static List<Usuario> Usuarios = new List<Usuario>()
        {
            new Usuario(1,"juan@gmail.com","1234")
            , new Usuario(2,"marina@gmail.com","1234")
            , new Usuario(3,"mario@gmail.com","1234")
        };

        //Lista de Alumnos vacia
        public static List<Alumno> Alumnos = new List<Alumno>();

        //Estructura
        public class Usuario
        {
            //Campos
            int id;
            string username;
            string password;

            //Constructor
            public Usuario(int id, string username, string password)
            {
                this.id = id;
                this.username = username;
                this.password = password;
            }
            //Propiedades
            public int Id { get => id; set => id = value; }
            public string Username { get => username; set => username = value; }
            public string Password { get => password; set => password = value; }
        }

        public class Alumno
        {
            int id;
            string carnet;
            string nombre;
            string apellido;

            public Alumno(int id, string carnet, string nombre, string apellido)
            {
                this.id = id;
                this.carnet = carnet;
                this.nombre = nombre;
                this.apellido = apellido;
            }

            public int Id { get => id; set => id = value; }
            public string Carnet { get => carnet; set => carnet = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Apellido { get => apellido; set => apellido = value; }
        }
        public class Tutor
        {
            int id;
            string cedula;
            string fullname;
           decimal salario;
        }
    }
}