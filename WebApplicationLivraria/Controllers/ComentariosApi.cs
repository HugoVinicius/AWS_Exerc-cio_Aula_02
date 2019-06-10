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
    public class ComentariosApiController : Controller
    { 
        [HttpPost]
        [Route("/LivrariaEletronica/v1/Comentarios")]

        public virtual IActionResult AddLivros([FromBody]Comentario comentario)
        { 
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 409 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(409);


            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("/LivrariaEletronica/v1/Comentarios/{idComentario}")]
        public virtual IActionResult DeleteOrder([FromRoute][Required]string idComentario)
        { 
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("/LivrariaEletronica/v1/Comentarios")]

        public virtual IActionResult UpdateLivro([FromBody]Comentario body)
        { 
            throw new NotImplementedException();
        }
    }
}
