int entero = 0;

float floatante = 3f;

string cadena = "Esta es una cadena";

char caracter = 'a';

double numeroDecimal = 4.5;

bool booleano = true;

bool decision = entero == 0;

Console.WriteLine("Ingrese tu nombre:");
string miNombre = Console.ReadLine();

Console.WriteLine("Ingrese un edad (años): ");
short edad = short.Parse(Console.ReadLine());

Console.WriteLine("Ingresa tu altura(en mts):");
float altura = float.Parse(Console.ReadLine());

Console.WriteLine($"Bienvenido {miNombre}, tienes {edad} años y mides {altura} mts");
