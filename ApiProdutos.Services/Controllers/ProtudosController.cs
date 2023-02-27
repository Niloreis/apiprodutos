using ApiProdutos.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtudosController : ControllerBase
    {
        /// <summary>
        /// serviço de cadastrar de produto na API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(ProdutosPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de edição de produto na API
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(ProdutosPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de exclução  de produto na API
        /// </summary>
        /// <returns></returns>
        [HttpDelete ("{id}")]
        public IActionResult Delete( Guid? id)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de consultar todos os produto na API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<ProdutosGetModel>),200)]
        public IActionResult GetAll()
        {
            return Ok();
        }
        /// <summary>
        /// serviço de consultar 1  produto na API
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProdutosGetModel), 200)]
        public IActionResult GetById()
        {
            return Ok();
        }
    }
}
