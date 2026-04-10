
//Desarrolle un programa que solicite el año de nacimiento de una persona,
//validando que sea un número válido y que esté en un rango lógico (por ejemplo entre 1900 y el año actual)
DateTime nacimiento;
bool validarNacimiento = false;
do
{
    Console.WriteLine("Ingrese año de nacimiento (formato: dd/MM/yyyy): ");
    validarNacimiento = DateTime.TryParse(Console.ReadLine(),  out nacimiento);
    if (validarNacimiento && nacimiento.Year >= 1900 && nacimiento.Year <= DateTime.Now.Year)
    {
        Console.WriteLine($"Año de nacimiento ingresado: {nacimiento:dd/MM/yyyy}");
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un año de nacimiento válido. Intente nuevamente.");
        validarNacimiento = false;
    }
}
while (validarNacimiento!=true);