using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Npgsql;
using SneexDesings.Server.Data;
using System.Data;

namespace SneexDesings.Server.Controllers
{
    [ApiController]
    [Route("design")]
    public class DesignController : ControllerBase
    {
        [HttpGet]
        [Route("lista")]
        public async Task<IActionResult> GetDesignList()
        {
            try
            {
                var dataTable = new DataTable();
                using (var acceso = new NpgsqlConnection(ConexionDB.GetConnection()))
                {
                    acceso.Open();
                    var comando = new NpgsqlDataAdapter("select * from pa_DesignList();", acceso);
                    comando.Fill(dataTable);
                }
                var respuesta = JsonConvert.SerializeObject(dataTable);

                return Ok(respuesta);
            }
            catch (Exception)
            {
                return BadRequest("Error al cargar los diseños");
            } 
        }
    }
}
