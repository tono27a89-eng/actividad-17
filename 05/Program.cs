
//Desarrolle un programa que solicite un número entero y determine si es par o impar,
//validando previamente que el dato ingresado sea correcto
int numero;
bool validarNumero = false;
do
{
    Console.WriteLine("Ingrese un número: ");
    validarNumero = int.TryParse(Console.ReadLine(), out numero);
    if (validarNumero)
    {
        if (numero % 2 == 0)
        {
            Console.WriteLine($"El número {numero} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numero} es impar.");
        }
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número entero válido. Intente nuevamente.");
        validarNumero = false;
    }
}
while (validarNumero != true);
