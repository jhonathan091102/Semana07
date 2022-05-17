using Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Semana05.ViewModel
{
    public class ListaCategoriaViewModel : ViewModelBase
    {
        ObservableCollection<Categoria> _Categorias;
        public ObservableCollection<Categoria> Categorias
        {
            get { return _Categorias; }
            set
            {
                if (_Categorias != value)
                {
                    _Categorias = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand NuevoCommand { set; get; }
        public ICommand ConsultarCommand { set; get; }
        public ICommand VerCommand { set; get; }
        public ListaCategoriaViewModel()
        {
            Categorias = new Model.CategoriaModel().Categorias;

            NuevoCommand = new RelayCommand<Window>(param => Abrir());
            ConsultarCommand = new RelayCommand<object>(o => {
                Categorias = new Model.CategoriaModel().Categorias;
            });
            VerCommand = new RelayCommand<Window>(param => Abrir());

            void Abrir()
            {
                View.ManCategoria window = new View.ManCategoria();
                window.ShowDialog();
            }
        }
    }
}
