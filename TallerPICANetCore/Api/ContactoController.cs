using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TallerPICANetCore.ApiResult;
using TallerPICANetCore.Models;

namespace TallerPICANetCore.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController :  ControllerBase
    {

        // POST: api/Contacto
        [HttpPost]
        public ResultApi Post([FromBody] Contacto contacto)
        {
            return new ResultApi()
            {
                Id = 1,
                resultado = true,
                Nombre = contacto.Nombre,
                Apellido = contacto.Apellido,
                Email = contacto.Email,
                Telefono = contacto.Telefono,
                Descripcion = contacto.Descripcion
            };
        }

       
    }
}
