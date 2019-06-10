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
    public class LivrosApiController : Controller
    { 
        /// <summary>
        /// Adicionar livros
        /// </summary>
        /// <remarks>Adiciona um item ao sistema</remarks>
        /// <param name="livro">Adiciona um livro no sistema</param>
        /// <response code="201">Livro Incluido</response>
        /// <response code="400">Entrada inválida, objeto inválido</response>
        /// <response code="409">Um livro já existente com esse ISBN</response>
        [HttpPost]
        [Route("/LivrariaEletronica/v1/Livros")]

        public virtual IActionResult AddLivros([FromBody]Livro livro)
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
        /// Deletar livros por ISBN
        /// </summary>
        
        /// <param name="ISBN">ISBN do livro para ser excluido</param>
        /// <response code="200">Livro excluido com sucesso</response>
        /// <response code="400">ISBN a ser excluido inválido</response>
        /// <response code="404">ISBN não encontrado</response>
        [HttpDelete]
        [Route("/LivrariaEletronica/v1/Livros/{ISBN}")]
        public virtual IActionResult DeleteOrder([FromRoute][Required]string ISBN)
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
        /// Atualiza um livro
        /// </summary>
        
        /// <param name="body">Livro que precisa ser atualizado</param>
        /// <response code="400">ISBN inválido</response>
        /// <response code="404">livro não encontrado</response>
        [HttpPut]
        [Route("/LivrariaEletronica/v1/Livros")]

        public virtual IActionResult UpdateLivro([FromBody]Livro body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista de livros
        /// </summary>
        /// <remarks>Esse método retorna uma lista de livros</remarks>
        /// <param name="pular">número de registros para pular para paginação</param>
        /// <param name="limit">número máximo de registros para retornar</param>
        /// <response code="200">Array de livros</response>
        /// <response code="400">Falha nos parâmtros de entrada</response>
        [HttpGet]
        [Route("/LivrariaEletronica/v1/Livros")]

        public virtual IActionResult V1LivrosGet([FromQuery]int? pular, [FromQuery][Range(0, 50)]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Livro>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "[ {\n  \"preco\" : 20.5,\n  \"ISBN\" : \"3687073\",\n  \"categora\" : {\n    \"idCategoria\" : 50,\n    \"descricao\" : \"Romance\"\n  },\n  \"nome\" : \"A Vida como ele é\",\n  \"editora\" : {\n    \"idCategoria\" : 100,\n    \"descricao\" : \"Companhia das Letra\"\n  },\n  \"autor\" : {\n    \"idAutor\" : 1,\n    \"name\" : \"Amado Jorge\",\n    \"descricao\" : \"História do autor\"\n  }\n}, {\n  \"preco\" : 20.5,\n  \"ISBN\" : \"3687073\",\n  \"categora\" : {\n    \"idCategoria\" : 50,\n    \"descricao\" : \"Romance\"\n  },\n  \"nome\" : \"A Vida como ele é\",\n  \"editora\" : {\n    \"idCategoria\" : 100,\n    \"descricao\" : \"Companhia das Letra\"\n  },\n  \"autor\" : {\n    \"idAutor\" : 1,\n    \"name\" : \"Amado Jorge\",\n    \"descricao\" : \"História do autor\"\n  }\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Livro>>(exampleJson)
            : default(List<Livro>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
