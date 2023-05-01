using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using back_end.entidades;

namespace back_end.Repositorios
{
    public interface IRepositorio
    {
        List<Genero> obtenerTodosLosGeneros();
        Genero obtenerGeneroPorId(int Id);
    }
}