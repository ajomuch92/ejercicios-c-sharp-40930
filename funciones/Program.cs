Console.WriteLine("------------");
saludar("Lucas");
saludar("Pablo");
Console.WriteLine("****************");

double numero1 = double.Parse(Console.ReadLine());
double numero2 = double.Parse(Console.ReadLine());

double resultado = sumaNumeros(numero1, numero2);

Console.WriteLine("La suma es " + resultado);

void saludar(String nombre)
{
    Console.WriteLine("Hola " + nombre); // 'a' "asdfasdf"
}

double sumaNumeros(double numero1, double numero2)
{
    return numero1 + numero2;
}
