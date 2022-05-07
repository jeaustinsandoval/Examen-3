using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WBL;
using Entity;
namespace WebAppLab.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IUsuariosServices usuariosServices;

        public LoginModel(IUsuariosServices usuariosServices)
        {
            this.usuariosServices = usuariosServices;
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
                var result = await usuariosServices.Login(Entity);


                if (result.CodeError==0)
                {
                    HttpContext.Session.Set<UsuariosEntity>(IApp.UsuarioSession,result);

                    return new JsonResult(result);
                }
                else
                {
                    return new JsonResult( result);
                }
            }
            catch (Exception ex)
            {

                return new JsonResult(new DBEntity { CodeError=ex.HResult,MsgError=ex.Message });
            }
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Clear();

            return Redirect("../Login");
        }

    }
}
