using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using back_end.entidades;
using back_end.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace back_end.Controllers
{
    [Route("api/generos")]
    public class GenerosController : ControllerBase
    {
        private readonly IRepositorio repositorio;

        public GenerosController( IRepositorio repositorio){
            this.repositorio = repositorio;
        }

        //! obtener Todos los generos -----------------------------
        // nota: tiene 2 rutas, ambas funcan
        [HttpGet] //api/generos
        [HttpGet("listado")] //api/generos/listado
        public List<Genero> Get(){
            return repositorio.obtenerTodosLosGeneros();        
        }
        
        //! obtener x id ------------------------------------------
        [HttpGet("{Id:int}")] // api/generos/id 
        public ActionResult<Genero> Get(int Id){
            var genero = repositorio.obtenerGeneroPorId(Id);     
            
            if(genero == null) return NotFound();

            return genero;
        }
        
        [HttpPost]
        public void  Post(){
            
        }
        
        [HttpPut]
        public void  Put(){
            
        }
        
        [HttpDelete]
        public void  Delete(){
            
        }
    

    
    
    
    }// end llaves GenerosController
}