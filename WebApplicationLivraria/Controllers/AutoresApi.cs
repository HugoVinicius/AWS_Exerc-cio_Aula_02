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
    public class AutoresApiController : Controller
    { 
        /// <summary>
        /// Adicionar autor
        /// </summary>
        /// <remarks>Adiciona um autor ao sistema</remarks>
        /// <param name="autor">Adiciona um autor no sistema</param>
        /// <response code="201">Autor Incluido</response>
        /// <response code="400">Entrada inválida, objeto inválido</response>
        /// <response code="409">Um autor já existente com o código informado</response>
        [HttpPost]
        [Route("/LivrariaEletronica/v1/Autores")]
        public virtual IActionResult AddAutores([FromBody]Livro autor)
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
        /// Deletar autor por id
        /// </summary>
        
        /// <param name="idAutor">idAutor a ser excluido</param>
        /// <response code="200">Autor excluido com sucesso</response>
        /// <response code="400">Autor a ser excluido inválido</response>
        /// <response code="404">Autor não encontrado</response>
        [HttpDelete]
        [Route("/LivrariaEletronica/v1/Autores/{idAutor}")]
        public virtual IActionResult DeleteAutor([FromRoute][Required]string idAutor)
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
        /// Atualiza um autor
        /// </summary>
        
        /// <param name="body">Autor que precisa ser atualizado</param>
        /// <response code="400">Autor inválido</response>
        /// <response code="404">autor não encontrado</response>
        [HttpPut]
        [Route("/LivrariaEletronica/v1/Autores")]
        public virtual IActionResult UpdateAutor([FromBody]Autor body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista de Autores
        /// </summary>
        /// <remarks>Esse método retorna uma lista de autores</remarks>
        /// <param name="pular">número de registros para pular para paginação</param>
        /// <param name="limit">número máximo de registros para retornar</param>
        /// <response code="200">Array de autores</response>
        /// <response code="400">Falha nos parâmtros de entrada</response>
        [HttpGet]
        [Route("/LivrariaEletronica/v1/Autores")]

        public virtual IActionResult V1AutoresGet([FromQuery]int? pular, [FromQuery][Range(0, 50)]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Autor>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "[ {\n  \"idAutor\" : 1,\n  \"name\" : \"Amado Jorge\",\n  \"descricao\" : \"História do autor\"\n}, {\n  \"idAutor\" : 1,\n  \"name\" : \"Amado Jorge\",\n  \"descricao\" : \"História do autor\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Autor>>(exampleJson)
            : default(List<Autor>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
