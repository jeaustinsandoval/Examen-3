using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;
namespace WebAppLab.Pages
{
    public class RegistrarseModel : PageModel
    {
        private readonly IUsuariosServices usuarioService;

        public RegistrarseModel(IUsuariosServices usuarioService)
        {

            this.usuarioService = usuarioService;
        }

        [FromBody]
        [BindProperty]

        public UsuariosEntity Entity { get; set; } = new UsuariosEntity();
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {

            try
            {
                var result = await usuarioService.Registrar(Entity);


                return new JsonResult(result);



            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });

                throw;
            }


        }
    }
}
