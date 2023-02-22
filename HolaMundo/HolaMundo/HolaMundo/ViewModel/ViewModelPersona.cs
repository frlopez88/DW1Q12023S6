using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using HolaMundo.Models;

namespace HolaMundo.ViewModel

{
    public class ViewModelPersona : INotifyPropertyChanged
    {

        public ViewModelPersona() {

            crearPersona = new Command(() => {

                Persona p = new Persona() {
                    nombre = this.nombre, 
                    fechaNacimiento = this.fechaNacimiento,
                    estaturaMts = this.estatura, 
                    identidad = this.identidad
                };

                Mensaje = p.ToString();



            });


        }

        string mensaje;
        public string Mensaje {

            get => mensaje;
            set {
                mensaje = value;
                var args = new PropertyChangedEventArgs(nameof(Mensaje));
                PropertyChanged?.Invoke(this, args);
            
            }
        
        }


        string nombre;

        public string Nombre {

            get => nombre;
            set {

                nombre = value;
                var args = new PropertyChangedEventArgs(nameof(Nombre));
                PropertyChanged?.Invoke(this, args);

            }
            
       }


        DateTime fechaNacimiento;

        public DateTime FechaNacimiento {

            get => fechaNacimiento;
            set {
                fechaNacimiento = value;
                var args = new PropertyChangedEventArgs(nameof(FechaNacimiento));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string identidad;

        public string Identidad { 
            get => identidad;
            set { 
            
                identidad = value;
                var args = new PropertyChangedEventArgs(nameof(Identidad));
                PropertyChanged?.Invoke(this, args);
                
            }
        }

        double estatura;
        public double Estatura { 
            get=> estatura;
            set { 
                estatura = value;
                var args = new PropertyChangedEventArgs(nameof(Estatura));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command crearPersona { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
