//Desarrolle un programa que solicite la edad de una persona, validando que el valor ingresado sea un número entero válido,
//repitiendo hasta que el dato sea correcto y mostrando la edad ingresada

int edad;
bool validaredad=false;
do
{
    Console.WriteLine("ingrese edad: ");validaredad= int.TryParse(Console.ReadLine(), out edad);
    if (validaredad&&edad>0)
    {
        Console.WriteLine("Edad ingresada: " + edad);        
    }
    else
    {
        Console.WriteLine("Valor ingresado no es un número entero válido. Intente nuevamente.");
        validaredad= false;
    }

    }
while (validaredad!=true);

