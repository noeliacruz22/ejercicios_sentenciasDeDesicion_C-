//Algoritmo mayor edad

const int EDAD_ADULTO = 18;
//Solicitamos la edad del usuario
Console.WriteLine("Ingrese su edad: ");
var edadPersona = Convert.ToInt32(Console.ReadLine());
//revisamos si es mayor de edad
if (edadPersona >= EDAD_ADULTO)
{
    Console.WriteLine($"Persona con edad {edadPersona} es adulto");
}
else if(edadPersona < 0)
{
    Console.WriteLine($"Edad {edadPersona} erronea");
}
else
{
    Console.WriteLine($"Persona con edad {edadPersona} es menor de edad");
};

//Algoritmo Dias de la Semana

//pedimos al usuario que ingrese el dia de la semana
Console.WriteLine("Ingrese el dia de la semana: ");
var diaSemana = Convert.ToInt32(Console.ReadLine());
//revisamos que dia de la semana es
if(diaSemana == 1)
{
    Console.WriteLine("Lunes");
}
else if (diaSemana == 2)
{
    Console.WriteLine("Martes");
}
else if (diaSemana == 3)
{
    Console.WriteLine("Miercoles");
}
else if (diaSemana == 4)
{
    Console.WriteLine("Jueves");
}
else if (diaSemana == 5)
{
    Console.WriteLine("Viernes");
}
else if (diaSemana == 6)
{
    Console.WriteLine("Sabado");
}
else if (diaSemana == 7)
{
    Console.WriteLine("Domingo");
}
else
{
    Console.WriteLine("El dia ingresado no existe");
};

//Algoritmo dia de la semana con switch

//pedimos al usuario que ingrese el dia de la semana
Console.WriteLine("Ingrese el dia de la semana: ");
var diaDeSemana = Convert.ToInt32(Console.ReadLine());
//revisamos que dia de la semana es
switch (diaDeSemana)
{
    case 1:
        { Console.WriteLine("LUNES");
            break;
        }
    case 2: { Console.WriteLine("MARTES");
        break;  
        }
    case 3: { Console.WriteLine("MIERCOLES");
        break;
        }
    case 4: { Console.WriteLine("JUEVES");
        break;
        }
    case 5: { Console.WriteLine("VIERNES");
        break;
        }
    case 6: { Console.WriteLine("SABADO");
        break;
        }
    case 7: { Console.WriteLine("DOMINGO");
        break;
        }
    default: { Console.WriteLine("No ingresaste un dia valido");
        break;
        }
}