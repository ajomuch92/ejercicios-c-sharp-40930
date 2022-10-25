// const string contraseniaCorrecta = "usSystem-2022";
const short CANTIDAD_MAX_INTENTOS = 5;
short intentos = 0;

do
{
    string contraseniaIngresada = ingresarContrasenia();
    if (validar(contraseniaIngresada))
    {
        imprimirContraseniaCorrecta(contraseniaIngresada);
        break;
    }
    else
    {
        intentos++;
        Console.WriteLine($"Contraseña incorrecta, tienes {CANTIDAD_MAX_INTENTOS - intentos} intentos");
    }
} while (intentos < CANTIDAD_MAX_INTENTOS);



string ingresarContrasenia()
{
    Console.WriteLine("Ingresa la contraseña");
    string contraseniaIngresada = Console.ReadLine();
    return contraseniaIngresada;
}


bool validar(string contraseniaIngresada) 
{
    const string contraseniaCorrecta = "usSystem-2022";
    return contraseniaIngresada.Equals(contraseniaCorrecta);
}

void imprimirContraseniaCorrecta(string contraseniaCorrecta)
{
    string mensaje = "";
    for (int i = 0; i < contraseniaCorrecta.Length; i++)
    {
        mensaje += "*"; // mensaje = mensaje + "*"
    }
    Console.WriteLine(mensaje + " es correcta");

}
