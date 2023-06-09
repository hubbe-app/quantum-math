using Microsoft.AspNetCore.Mvc;
using Quantum.Math.Api.Services;

namespace Quantum.Math.Api.Controllers;


[Route("api")]
[ApiController]
public class MathController : ControllerBase
{
   private readonly IMathService mathService;

   public MathController(IMathService mathService)
   {
      this.mathService = mathService;
   }

   [HttpGet("/api/sum")]
   public ActionResult<double> Sum(double x, double y) => mathService.Sum(x, y);
   
   [HttpGet("/api/division")]
   public ActionResult<double> Division(double x, double y) => mathService.Division(x, y);
}