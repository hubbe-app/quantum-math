namespace Quantum.Math.Api.Services;

public class MathService: IMathService
{
   public double Sum(double x, double y) => x + y;
   
   public double Division(double x, double y) => x / y;
}