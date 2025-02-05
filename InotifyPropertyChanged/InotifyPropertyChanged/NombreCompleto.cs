﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InotifyPropertyChanged
{
    public class NombreCompleto : INotifyPropertyChanged
    {

        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler? PropertyChanged;


        private void onPropertyChanged(string property)
        {

            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(property)); 
            }

        }


        public string Nombre {
            get { return nombre; }
            set {
                nombre = value;
                onPropertyChanged("Nombre_completo");
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set { 
                apellido = value;
                onPropertyChanged("Nombre_completo");
            }
        }

        public string Nombre_completo
        {
            get 
            { 
                nombre_completo=Nombre + " " + Apellido;
                return nombre_completo;
            }
            set { apellido = value; }
        }

    }
}
