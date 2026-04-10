
//Desarrolle un programa que solicite el precio de un producto, validando que sea un número decimal mayor que 0,
//repitiendo hasta que el usuario ingrese correctamente el valor

decimal precio;
bool validarPrecio = false;
do
{
    Console.WriteLine("ingrese precio: ");validarPrecio = decimal.TryParse(Console.ReadLine(), out precio);
    if (validarPrecio && precio > 0)
    {
        Console.WriteLine($"Precio ingresado: {precio:F2}");
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número decimal válido. Intente nuevamente.");
        validarPrecio = false;
    }
}
while (validarPrecio!=true);