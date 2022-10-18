int miContrasenia = 11249200;
Console.WriteLine("Ingresa la contraseña");
int contraseniaIngresada = 0;

if (int.Parse(Console.ReadLine()) == miContrasenia)
{
    Console.WriteLine("Bienvenid@");
}
else
{
    Console.WriteLine("Ingresa la contraseña nuevamente");
    contraseniaIngresada = int.Parse(Console.ReadLine());
    if (contraseniaIngresada == miContrasenia)
    {
        Console.WriteLine("Bienvenid@");
    }
    else
    {
        Console.WriteLine("Reiniciar el sistema");
    }
}