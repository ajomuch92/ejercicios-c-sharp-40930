// Ciclos While

// while
int edad = 0;

while(true)
{
    Console.WriteLine("Dame tu edad");
    edad = int.Parse(Console.ReadLine());
    if (edad == 0)
    {
        break;
    }
}


// do while

double altura = 0;

do
{
    Console.WriteLine("Dame tu altura en mt");
    altura = double.Parse(Console.ReadLine());
} while (altura != 0);
