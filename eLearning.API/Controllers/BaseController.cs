using eLearning.Domain;
using eLearning.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace eLearning.API.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private UnitOfWork _unit;

        public UnitOfWork Unit => _unit ?? (_unit = new UnitOfWork());

    } 
}
