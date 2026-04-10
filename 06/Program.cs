
//Desarrolle un programa que solicite una fecha,
//validando que el formato ingresado sea correcto, y luego mostrarla en formato corto
DateTime fecha;
bool validarFecha = false;
do
{
    Console.WriteLine("Ingrese una fecha (formato: dd/MM/yyyy): ");
    validarFecha = DateTime.TryParse(Console.ReadLine(), out fecha);
    if (validarFecha)
    {
        Console.WriteLine($"Fecha ingresada en formato corto: {fecha:d}");
    }
    else
    {
        Console.WriteLine("Valor ingresado no es una fecha válida. Intente nuevamente.");
        validarFecha = false;
    }
}
while (validarFecha != true);