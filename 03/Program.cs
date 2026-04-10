
//Desarrolle un programa que solicite la cantidad de estudiantes en un curso,
//validando que sea un número entero positivo, evitando valores negativos o letras
int cantidadEstudiantes;
bool validarCantidad = false;
do
{
    Console.WriteLine("ingrese cantidad de estudiantes: ");validarCantidad = int.TryParse(Console.ReadLine(), out cantidadEstudiantes);
    if (validarCantidad && cantidadEstudiantes > 0)
    {
        Console.WriteLine("Cantidad de estudiantes ingresada: " + cantidadEstudiantes);
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número entero válido. Intente nuevamente.");
        validarCantidad = false;
    }
}
while (validarCantidad!=true);