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
    public class EditorasApiController : Controller
    { 
        /// <summary>
        /// Adicionar editoras
        /// </summary>
        /// <remarks>Adiciona uma editora ao sistema</remarks>
        /// <param name="editora">Adiciona uma editora ao sistema</param>
        /// <response code="201">Editora Incluido</response>
        /// <response code="400">Entrada inválida, objeto inválido</response>
        /// <response code="409">Um autor já existente com o código informado</response>
        [HttpPost]
        [Route("/LivrariaEletronica/v1/Editoras")]

        public virtual IActionResult AddEditora([FromBody]Editora editora)
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
        /// Deletar editora por id
        /// </summary>
        
        /// <param name="idEditora">idEditora a ser excluido</param>
        /// <response code="200">Editora excluido com sucesso</response>
        /// <response code="400">Editora a ser excluido inválido</response>
        /// <response code="404">Editora não encontrado</response>
        [HttpDelete]
        [Route("/LivrariaEletronica/v1/Editoras/{idEditora}")]
        public virtual IActionResult DeleteEditoras([FromRoute][Required]string idEditora)
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
        /// Atualiza uma editora
        /// </summary>
        
        /// <param name="body">Editora que precisa ser atualizado</param>
        /// <response code="400">Editora inválido</response>
        /// <response code="404">editora não encontrado</response>
        [HttpPut]
        [Route("/LivrariaEletronica/v1/Editoras")]

        public virtual IActionResult UpdateEditora([FromBody]Editora body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);


            throw new NotImplementedException();
        }

        /// <summary>
        /// Lista de Editoras
        /// </summary>
        /// <remarks>Esse método retorna uma lista de editora</remarks>
        /// <param name="pular">número de registros para pular para paginação</param>
        /// <param name="limit">número máximo de registros para retornar</param>
        /// <response code="200">Array de editoras</response>
        /// <response code="400">Falha nos parâmtros de entrada</response>
        [HttpGet]
        [Route("/LivrariaEletronica/v1/Editoras")]

        public virtual IActionResult V1EditorasGet([FromQuery]int? pular, [FromQuery][Range(0, 50)]int? limit)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Editora>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            string exampleJson = null;
            exampleJson = "[ {\n  \"idCategoria\" : 100,\n  \"descricao\" : \"Companhia das Letra\"\n}, {\n  \"idCategoria\" : 100,\n  \"descricao\" : \"Companhia das Letra\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Editora>>(exampleJson)
            : default(List<Editora>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
