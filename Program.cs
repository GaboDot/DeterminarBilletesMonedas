using DeterminarBilletesMonedas;

Console.WriteLine("Introduce cantidad: ");
double cantidad = double.Parse(Console.ReadLine());
double nuevaCantidad = 0;
double[] billetes = new double[] { 20, 50, 100, 200, 500, 1000 };
double[] monedas = new double[] { 1, 2, 5, 10 };
List<double> denominaciones = new List<double>();
Denominaciones busqueda = new Denominaciones();

if (cantidad >= billetes[0])
{
    denominaciones = busqueda.buscarDenominaciones(cantidad, billetes, out cantidad);
    foreach (var number in denominaciones.GroupBy(x => x))
        Console.WriteLine($"Billete ${number.Key} : {number.Count()}");
    denominaciones.Clear();
}
if(cantidad > 0 )
{
    denominaciones = busqueda.buscarDenominaciones(cantidad, monedas, out cantidad);
    foreach (var number in denominaciones.GroupBy(x => x))
        Console.WriteLine($"Moneda \t${number.Key} : {number.Count()}");
}
Console.ReadKey();
