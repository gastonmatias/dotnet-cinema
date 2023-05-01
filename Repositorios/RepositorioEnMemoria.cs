using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.entidades;

//! Un repositorio comunica la app con la bd
//  en este caso, este repositorio es de tipo provisorio,
//  para trabajar con data en memoria

namespace back_end.Repositorios
{
    public class RepositorioEnMemoria: IRepositorio
    {
        private List<Genero> _generos;
    
        // costructor que inicializa un listado de generos
        public RepositorioEnMemoria() {
            _generos = new List<Genero>(){
                new Genero(){Id = 1, Nombre = "Comedia"},
                new Genero(){Id = 2, Nombre = "Acción"}
            };
        }

        // metodo qe devuelve listado de generos
        public List<Genero> obtenerTodosLosGeneros(){
            return _generos;
        }
        
        public Genero obtenerGeneroPorId(int Id){
            return _generos.FirstOrDefault(x => x.Id == Id);
        }
    }
}