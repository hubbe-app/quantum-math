using Microsoft.AspNetCore.Mvc;
using Quantum.Math.Api.Services;

namespace Quantum.Math.Api.Controllers;

[ApiController]
[Route("api")]
public class MathController : ControllerBase
{
   private readonly IMathService mathService;

   public MathController(IMathService mathService)
   {
      this.mathService = mathService;
   }

   [HttpGet("/sum")]
   public ActionResult<double> Sum(double x, double y) => mathService.Sum(x, y);
   
   [HttpGet("/division")]
   public ActionResult<double> Division(double x, double y) => mathService.Division(x, y);
}