using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity;
using WBL;
namespace WebApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenciaController : ControllerBase
    {
        private readonly IAgenciaService agenciaService;

        public AgenciaController(IAgenciaService agenciaService)
        {
            this.agenciaService = agenciaService;
        }


        [HttpGet("Lista")]
        public async Task<IEnumerable<AgenciaEntity>> GetLista()
        {
            try
            {
                return await agenciaService.GetLista();
            }
            catch (Exception )
            {

                return new List<AgenciaEntity>();
            }
        }

        [HttpPost]
        public async Task<DBEntity> Create(AgenciaEntity entity)
        {
            try
            {
                return await agenciaService.Create(entity);
            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }



        }
        


        [HttpDelete("{id}")]
        public async Task<DBEntity> Delete(int id)
        {
            try
            {
                var result = await agenciaService.Delete(new AgenciaEntity { AgenciaId = id });
                result.MsgError = result.CodeError == 547
                    ? "El registro no se puede eliminar"
                    : result.CodeError == -1
                    ? "Mensaje 2"
                    : result.MsgError;

                return result;

            }
            catch (Exception ex)
            {

                return new DBEntity { CodeError = ex.HResult, MsgError = ex.Message };
            }



        }


    }
}
