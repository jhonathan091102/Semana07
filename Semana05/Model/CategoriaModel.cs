using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Business;
using System.Collections.ObjectModel;

public class CategoriaModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public bool Insertar(Categoria categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }
        public Categoria get(int id)
        {
            return (new BCategoria()).Listar(id)[0];
        }
        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            new BCategoria().Eliminar(id);
        }

        public CategoriaModel()
        {
            var lista = (new BCategoria()).Listar(0);
            Categorias = new ObservableCollection<Categoria>(lista);
        }
    }

namespace Semana05.Model
{
    public class CategoriaModel
    {
        public ObservableCollection<Categoria> Categorias { get; set; }
        public bool Insertar(Categoria categoria)
        {
            return (new BCategoria()).Insertar(categoria);
        }
        public Categoria get(int id)
        {
            return (new BCategoria()).Listar(id)[0];
        }
        public bool Actualizar(Categoria categoria)
        {
            return (new BCategoria()).Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            new BCategoria().Eliminar(id);
        }

        public CategoriaModel()
        {
            var lista = (new BCategoria()).Listar(0);
            Categorias = new ObservableCollection<Categoria>(lista);
        }
    }
}
