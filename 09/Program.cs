
//Desarrolle un programa que solicite la nota de un estudiante,
//validando que sea un número entre 0 y 100 antes de mostrar si aprueba o reprueba
int nota;   
bool NotaValida = false;
do
{
    Console.WriteLine("Ingrese la nota del estudiante (0-100): ");
    NotaValida = int.TryParse(Console.ReadLine(), out nota);
    if (NotaValida && nota >= 0 && nota <= 100)
    {
        if (nota >= 60)
        {
            Console.WriteLine("El estudiante aprueba.");
        }
        else
        {
            Console.WriteLine("El estudiante reprueba.");
        }
    }
    else
    {
        Console.WriteLine("La nota ingresada no es válida. Por favor, ingrese un número entre 0 y 100.");
        NotaValida = false;
    }
}while (!NotaValida);