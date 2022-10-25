
realizarCompras();

void realizarCompras()
{
    string codigo = "";
    double total = 0;
    while (codigo != "FIN")
    {
        codigo = obtenerCodigo();
        if (esCodigoValido(codigo))
        {
            Console.WriteLine(obtenerNombreProducto(codigo));
            int precio = obtenerPrecio(codigo);
            int cantidadALlevar = obtenerCantidadALlevar();
            total += precio * cantidadALlevar;
        }
    }
    Console.WriteLine("Gracias por comprar en nuestra tienda");
    Console.WriteLine("Total gastado {0}", total);
}

bool esCodigoValido(string codigo)
{
    return codigo.Equals("JP") || codigo.Equals("DET") || codigo.Equals("DES");
}

string obtenerCodigo()
{
    Console.WriteLine("Ingresa el código del producto");
    string codigo = Console.ReadLine();
    return codigo.ToUpper();
}

int obtenerCantidadALlevar()
{
    Console.WriteLine("Ingresa la cantidad a llevar");
    string cantidad = Console.ReadLine();
    return int.Parse(cantidad);
}

string obtenerNombreProducto(string codigo)
{
    if (codigo == "DES")
    {
        return "Desodorante";
    }
    else if (codigo == "JP")
    {
        return "Jabón en Polvo";
    }
    else if (codigo == "DET")
    {
        return "Detergente";
    }
    return "Código inválido";
}

int obtenerPrecio(string codigo)
{
    if (codigo == "DES")
    {
        return 200;
    }
    else if (codigo == "JP")
    {
        return 300;
    }
    else if (codigo == "DET")
    {
        return 250;
    }
    return 0;
}
