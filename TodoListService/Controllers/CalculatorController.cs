using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using TodoListService.Models;

namespace TodoListService.Controllers
{
   [Authorize]
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("Add")]
        public JsonResult Add(double value1, double value2)
        {
            return new JsonResult(value1 + value2);
        }

        [HttpGet]
        [Route("Subtract")]
        public JsonResult Subtract(double value1, double value2)
        {
            return new JsonResult(value1 - value2);
        }

        [HttpGet]
        [Route("Multiply")]
        public JsonResult Multiply(double value1, double value2)
        {
            return new JsonResult(value1 * value2);
        }

        [HttpGet]
        [Route("Divide")]
        public JsonResult Divide(double value1, double value2)
        {
            return new JsonResult(value1 / value2);
        }
    }
}
