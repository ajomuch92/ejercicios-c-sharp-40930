// Cadenas
string mensaje = "Hola Mundo";

Console.WriteLine("Cadena original " + mensaje);

Console.WriteLine("Longitud " + mensaje.Length);

Console.WriteLine("Mayúscula " + mensaje.ToUpper());

Console.WriteLine("Minúscula " + mensaje.ToLower());

Console.WriteLine(mensaje.Equals("Hola"));

Console.WriteLine(mensaje.Contains("hola"));

Console.WriteLine("Primera letra " + mensaje[0]);

string vacio = ""; // string.Empty
string? nulo = null;

if (string.IsNullOrEmpty(vacio)) // if (vacio == "" || vacio == string.Empty || vacio == null)
{
    Console.WriteLine("Mi cadena está vacía");
}

if (vacio == nulo)
{
    Console.WriteLine("Mis cadenas son iguales");
}
else
{
    Console.WriteLine("Mis cadenas son distintas");
}

int numero = 1;
float flotante = 3.15f;
bool decision = true;

Console.WriteLine(numero.ToString());
Console.WriteLine(flotante.ToString());
Console.WriteLine(decision.ToString());

Console.WriteLine(Convert.ToBoolean("True"));