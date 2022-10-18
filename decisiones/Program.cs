Console.WriteLine("Ingresa tu inventario:");

int inventario = int.Parse(Console.ReadLine());

if (inventario < 10)
{
    Console.WriteLine("Debes pedir más productos");
    Console.WriteLine("¿Cuántos productos deseas agregar?");
    int productosASumar = int.Parse(Console.ReadLine());
    inventario += productosASumar;
    if (inventario > 100)
    {
        Console.WriteLine("Has pedido demasiado");
    }
}
else if (inventario > 100)
{
    Console.WriteLine("Has pedido demasiado");
}
else
{
    Console.WriteLine("Estamos bien :)");
}
