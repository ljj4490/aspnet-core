using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb0522.Controllers;
using CoreWeb0522.PhoneBooks.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CoreWeb0522.Web.Mvc.Controllers
{
    public class PersonsController : CoreWeb0522ControllerBase
    {
        private readonly IPersonAppServer _personAppServer;

        //public PersonsController(IPersonAppServer personAppServer)
        //{
        //    this._personAppServer = personAppServer;
        //}

        public IActionResult IndexAsync(GetPersonInput input )
        {
            //await _personAppServer


            return View();
        }
    }
}