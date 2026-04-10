
//Desarrolle un programa que solicite la cantidad de productos a comprar,
//validando que sea un número entero positivo y luego simule el ingreso de esos productos
int cantidadProductos;
bool validarCantidad = false;
List<(string, double)> productos = new List<(string, double)>();
do
{
    Console.WriteLine("Ingrese la cantidad de productos a comprar: ");
    validarCantidad = int.TryParse(Console.ReadLine(), out cantidadProductos);
    if (validarCantidad && cantidadProductos > 0)
    {
        Console.WriteLine($"Cantidad de productos a comprar: {cantidadProductos}");
        for (int i = 1; i <= cantidadProductos; i++)
        {
            Console.WriteLine($"Ingrese el nombre del producto {i}: ");
            string nombreProducto = Console.ReadLine();
            Console.WriteLine($"Ingrese el precio del producto {i}: ");
            double precioProducto;
            while (!double.TryParse(Console.ReadLine(), out precioProducto) || precioProducto < 0)
            {
                Console.WriteLine("Precio inválido. Ingrese un número positivo.");
            }
            productos.Add((nombreProducto, precioProducto));
        }
        foreach (var item in productos)
        {
            Console.WriteLine($"{item.Item1}: {item.Item2:C}");
        }
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número entero válido. Intente nuevamente.");
        validarCantidad = false;
    }
}while (!validarCantidad);