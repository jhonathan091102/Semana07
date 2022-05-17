using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Semana05.ViewModel
{
    public class ManCategoriaViewModel : ViewModelBase
    {
        #region propiedades
        int _ID;
        public int ID
        {
            get { return _ID; }
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set
            {
                if (_Nombre != value)
                {
                    _Nombre = value;
                    OnPropertyChanged();
                }
            }
        }

        string _Descripcion;
        public string Descripcion
        {
            get { return _Descripcion; }
            set
            {
                if (_Descripcion != value)
                {
                    _Descripcion = value;
                    OnPropertyChanged();
                }
            }
        }

        #endregion

        public ICommand GrabarCommand { set; get; }
        public ICommand CerrarCommand { set; get; }
        public ICommand EliminarCommand { set; get; }

        public ManCategoriaViewModel()
        {
            GrabarCommand = new RelayCommand<object>(
                o => {
                    Console.WriteLine("MI ID: " + ID);
                    if (ID > 0)
                    {
                        new CategoriaModel().Actualizar(new Entity.Categoria
                        {
                            IdCategoria = ID,
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });
                        MessageBox.Show("Categoria actualizada con exito, ID: " + ID);
                    }
                    else
                    {
                        new CategoriaModel().Insertar(new Entity.Categoria
                        {
                            NombreCategoria = Nombre,
                            Descripcion = Descripcion
                        });
                        MessageBox.Show("Categoria guardada con exito");
                    }
                });

            CerrarCommand = new RelayCommand<Window>(
                param => Cerrar(param));
            EliminarCommand = new RelayCommand<object>(param => Eliminar(param));

        }

        void Cerrar(Window window)
        {
            window.Close();
        }
        void Eliminar(object param)
        {
            if (ID > 0)
            {
                new CategoriaModel().Eliminar(ID);

                MessageBox.Show("Categoria eliminada con el ID: " + ID);
                ID = 0;
                Nombre = "";
                Descripcion = "";

            }

        }
    }
}
