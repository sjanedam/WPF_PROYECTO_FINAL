using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL
{
    class User
    {
        public int id;
        public String nombre_usuario;
        public String contra;

        public String Usuario
        {
            get { return nombre_usuario; }
            set { nombre_usuario = value; }
        }

        public String Password
        {
            get { return contra; }
            set { contra = value; }
        }

        public User(int id, string nombre_usuario, string contra)
        {
            this.id = id;
            this.nombre_usuario = nombre_usuario;
            this.contra = contra;
        }
    }
}
