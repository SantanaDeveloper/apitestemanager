using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apimanager.Helpers;
using Apimanager.Implementations;
using Apimanager.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Apimanager.Controllers
{
    public class DiffController : Controller
    {
        private readonly ILeftService _leftService;
        private readonly IRightService _rightService;
        private readonly IJsonService _jsonService;

        public DiffController(ILeftService leftService, IRightService rightService, IJsonService jsonService)
        {
            _leftService = leftService;
            _rightService = rightService;
            _jsonService = jsonService;
        }

        /// <summary>
        /// Endpoint HTTP que lista todos os conjuntos de Json inseridos.
        /// </summary>
        [HttpGet("/v1/diff")]
        public IActionResult Index()
        {
            return Json(_jsonService.GetAllAsync().Result);
        }

        /// <summary>
        /// Endpoint HTTP que faz a comparação os conjuntos de Json com o ID de controle informado.
        /// </summary>
        [HttpGet("/v1/diff/{id}")]
        public IActionResult Index(int id)
        {
            if (id != 0)
            {
                var response = _jsonService.GetDiffsById(id).Result;
                var lista = new List<string>();
                foreach (var res in response)
                {
                    var a = res.LeftJson;
                    var b = res.RightJson;
                    var jsoncompare = new StringHelper();
                    lista.Add(jsoncompare.Compare(a, b));
                }
                return Json(lista);
            }
            else
                return Json(_jsonService.GetAllAsync().Result);
        }

        /// <summary>
        /// Endpoint HTTP que recebe o Json para o campo da esquerda.
        /// </summary>
        [HttpPost("/v1/diff/left")]
        public async Task<IActionResult> Left([FromBody] dynamic requestData)
        {
            var jsonserialized = JsonConvert.SerializeObject(requestData);

            try
            {
                return Ok(await _leftService.InsertAsync(new LeftModel()
                {
                    Json = jsonserialized
                }
                    ));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>   
        /// Endpoint HTTP que recebe o Json para o campo da direita.
        /// </summary>
        [HttpPost("/v1/diff/right")]
        public async Task<IActionResult> Right(int id, [FromBody] dynamic requestData)
        {
            var jsonserialized = JsonConvert.SerializeObject(requestData);
            try
            {
                return Ok(await _rightService.InsertAsync(new RightModel()
                {
                    Json = jsonserialized,
                    IdLeft = id
                }
                    ));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}