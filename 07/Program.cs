

//Desarrolle un programa que solicite el salario de un empleado,
//validando que sea un número decimal válido mayor o igual a 0
decimal salario;
bool validarSalario = false;
do
{
    Console.WriteLine("Ingrese el salario del empleado: ");validarSalario = decimal.TryParse(Console.ReadLine(), out salario);
    if (validarSalario && salario >= 0)
    {
        Console.WriteLine($"Salario ingresado: {salario:F2}");
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número decimal válido. Intente nuevamente.");
        validarSalario = false;
    }
}
while (validarSalario!= true);