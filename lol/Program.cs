class Bil
{
  private string color = "Red";
  private string type = "Audi R8";
  static void Main(string[] args)
  {
    Bil minBil1 = new Bil();
    Bil minBil2 = new Bil();
    Console.WriteLine(minBil1.color);
    Console.WriteLine(minBil2.type);
  }
}