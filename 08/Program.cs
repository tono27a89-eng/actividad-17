
//Desarrolle un programa que solicite un número y calcule su raíz cuadrada,
//validando que el valor ingresado sea numérico y no negativo
double numero;  
bool NumeroValido = false;
do
{
    Console.WriteLine("Ingrese un numero positivo: "); NumeroValido = double.TryParse(Console.ReadLine(), out numero);
    if (NumeroValido && numero > 0)
    {
        double raizCuadrada = Math.Sqrt(numero);
        Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada:F2}");

    }
    else
    {
        Console.WriteLine("El valor ingresado no es un número válido o es negativo. Por favor, intente nuevamente.");
        NumeroValido = false;
    }
}
while (NumeroValido!=true);