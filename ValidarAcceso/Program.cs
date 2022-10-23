const string contraseniaCorrecta = "usSystem-2022";
const short CANTIDAD_MAX_INTENTOS = 5;
short intentos = 0;

do
{
    Console.WriteLine("Ingresa la contraseña");
    string contraseniaIngresada = Console.ReadLine();
    if (contraseniaIngresada == contraseniaCorrecta)
    {
        Console.WriteLine("Bienvenido al sistema");
        break;
    }
    else
    {
        intentos++;
        Console.WriteLine($"Contraseña incorrecta, tienes {CANTIDAD_MAX_INTENTOS - intentos} intentos");
    }
} while (intentos < CANTIDAD_MAX_INTENTOS);
