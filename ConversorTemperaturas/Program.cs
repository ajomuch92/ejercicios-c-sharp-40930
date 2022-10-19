int opcion;
double resultado = 0, temperatura = 0;
Console.Write("Ingresa el valor de temperatura: ");
temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Selecciona el valor de opcion.");
Console.WriteLine("\t1.- Fahrenheit a Celsius");
Console.WriteLine("\t2.- Celsius a Fahrenheit");
Console.Write("\t: ");
opcion = int.Parse(Console.ReadLine());

if (opcion == 1)
{
    resultado = (temperatura - 32) / 1.8;
}
else if (opcion == 2)
{
    resultado = 1.8 * temperatura + 32;
}
else
{
    Console.WriteLine("Has ingresado una opción no válida");
    return;
}
Console.WriteLine("Resultado de la conversión: " + resultado);
