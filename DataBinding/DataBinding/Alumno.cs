using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DataBinding
{
    public class Alumno : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string nombre = string.Empty;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre == value)
                    return;
                nombre = value;
                OnPropertyChanged(nameof(Nombre));
                OnPropertyChanged(nameof(MostrarNombre));
            }
        }

        public string MostrarNombre => $"Nombre ingresado:{Nombre}";
        void OnPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
