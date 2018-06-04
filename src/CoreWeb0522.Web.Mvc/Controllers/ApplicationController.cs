using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb0522.Controllers;
using CoreWeb0522.PhoneBooks;
using CoreWeb0522.PhoneBooks.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb0522.Web.Mvc.Controllers
{
    public class ApplicationController : CoreWeb0522ControllerBase
    {

        private readonly IPersonAppService _personAppService;

        public ApplicationController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetPersonInput input)
        {
            var dtos = await _personAppService.GetPagedPersonAsync(input);


            return View(dtos);
        }
    }
}