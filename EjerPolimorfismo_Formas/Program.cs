using EjerPolimorfismo_Formas;

Circulo circulo = new Circulo(5.0);
Rectangulo rectangulo = new Rectangulo(4.0, 6.0);

List<Forma> formas = new List<Forma>();
formas.Add(circulo);
formas.Add(rectangulo);

foreach (Forma forma in formas)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("***** Resultados *****");
    Console.WriteLine($"Forma: {forma.Nombre} - Área: {forma.CalcularArea():F2}");
}
Console.WriteLine();
