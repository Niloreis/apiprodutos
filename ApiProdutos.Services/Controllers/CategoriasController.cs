using ApiProdutos.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        /// <summary>
        /// serviço de cadastrar uma categotia na API
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(CategoriasPostModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de edição uma categotia na API
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put(CategoriasPutModel model)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de exclução uma categotia na API
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid? id)
        {
            return Ok();
        }

        /// <summary>
        /// serviço de consultar todas as categotia na API
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType( typeof(List<CategoriaGetModel>),200)]
        public IActionResult GetAll()
        {
            return Ok();
        }
        /// <summary>
        /// serviço de consultar 1 categotia na API
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(CategoriaGetModel), 200)]
        public IActionResult GetById(Guid? id)
        {
            return Ok();
        }
    }
}
