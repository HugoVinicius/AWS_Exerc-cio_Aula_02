using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WebApplicationLivraria.Models;

namespace WebApplicationLivraria.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CategoriasApiController : Controller
    { 
        /// <summary>
        /// Adicionar categoria
        /// </summary>
        /// <remarks>Adiciona uma categoria ao sistema</remarks>
        /// <param name="categoria">Adiciona uma categoria no sistema</param>
        /// <response code="201">Categoria Incluida</response>
        /// <response code="400">Entrada inválida, objeto inválido</response>
        /// <response code="409">Uma categoria já existente com o código informado</response>
        [HttpPost]
        [Route("/LivrariaEletronica/v1/Categoria")]

        public virtual IActionResult AddCategoria([FromBody]Categoria categoria)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletar uma categoria
        /// </summary>
        
        /// <param name="idCategoria">idCategoria a ser excluido</param>
        /// <response code="200">Categoria excluido com sucesso</response>
        /// <response code="400">Categoria a ser excluido inválido</response>
        /// <response code="404">Categoria não encontrado</response>
        [HttpDelete]
        [Route("/LivrariaEletronica/v1/Categoria/{idCategoria}")]

        public virtual IActionResult DeleteCategoria([FromRoute][Required]string idCategoria)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Atualiza uma categoria
        /// </summary>
        
        /// <param name="body">Categoria que precisa ser atualizado</param>
        /// <response code="400">Categoria inválido</response>
        /// <response code="404">Categoria não encontrado</response>
        [HttpPut]
        [Route("/LivrariaEletronica/v1/Categoria")]

        public virtual IActionResult UpdateCategoria([FromBody]Categoria body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista de Categorias
        /// </summary>
        /// <remarks>Esse método retorna uma lista de categorias</remarks>
        /// <param name="pular">número de registros para pular para paginação</param>
        /// <param name="limit">número máximo de registros para retornar</param>
        /// <response code="200">Array de categorias</response>
        /// <response code="400">Falha nos parâmtros de entrada</response>
        [HttpGet]
        [Route("/LivrariaEletronica/v1/Categoria")]
        public virtual IActionResult V1CategoriaGet([FromQuery]int? pular, [FromQuery][Range(0, 50)]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Categoria>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "[ {\n  \"idCategoria\" : 50,\n  \"descricao\" : \"Romance\"\n}, {\n  \"idCategoria\" : 50,\n  \"descricao\" : \"Romance\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Categoria>>(exampleJson)
            : default(List<Categoria>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
