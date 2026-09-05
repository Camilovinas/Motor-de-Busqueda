using Services;

int opcion = -1;
string busca;
int buscaInt;
busquedaServices services = new busquedaServices();

static string isNull()
{
    string str;

    do
    {
        str = Console.ReadLine() ?? string.Empty; // Si es null, lo vuelve ""

        if (string.IsNullOrWhiteSpace(str))
        {
            Console.WriteLine("Vuelva a interntarlo.");
        }
    }
    while (string.IsNullOrWhiteSpace(str));


    return str;
}
static int tryParseInt()
{
    int numero = 0;
    bool convertion = false;

    while (!convertion)
    {
        if (int.TryParse(Console.ReadLine(), out numero))
        {
            convertion = true;
        }
        else
        {
            Console.WriteLine("Ingrese un numero valido.");
        }
    }



    return numero;
}

while (opcion != 0)
{
    Console.Clear();
    Console.WriteLine("Busqueda Alumno");
    Console.WriteLine("1- Buscar por Nombre y Apellido");
    Console.WriteLine("2- Buscar por Carrera");
    Console.WriteLine("3- Buscar por DNI");
    Console.Write("Opcion: ");
    opcion = tryParseInt();

    switch (opcion)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Búsqueda por nombre o apellido");
            Console.Write("Buscar: ");
            busca = isNull();
            var list = services.BuscarNombre(busca);
            Console.Clear();
            foreach (var a in list)
            {
                Console.WriteLine($"ID: {a.Id} | Nombre: {a.Name} | Apellido: {a.SurName} | DNI: {a.Dni} | Carrera: {a.Career} | Promedio: {a.Average}");
            }

            if (list.Count == 0)
            {
                Console.WriteLine("No existe ningun Alumno con la busqueda ingresada.");
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Búsqueda por carrera");
            Console.Write("Buscar: ");
            busca = isNull();
            var list2 = services.BuscarCarrera(busca);
            Console.Clear();
            foreach (var a in list2)
            {
                Console.WriteLine($"ID: {a.Id} | Nombre: {a.Name} | Apellido: {a.SurName} | DNI: {a.Dni} | Carrera: {a.Career} | Promedio: {a.Average}");
            }

            if (list2.Count == 0)
            {
                Console.WriteLine("No existe ningun Alumno con la busqueda ingresada.");
            }

            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Búsqueda por DNI");
            Console.Write("Buscar: ");
            buscaInt = tryParseInt();
            var student = services.BuscarDni(buscaInt);
            Console.Clear();
            if (student.Name != "empty")
            {
                Console.WriteLine($"ID: {student.Id} | Nombre: {student.Name} | Apellido: {student.SurName} | DNI: {student.Dni} | Carrera: {student.Career} | Promedio: {student.Average}");
            } else
            {
                Console.WriteLine("No existe ningun Alumno con la busqueda ingresada.");
            }
            Console.WriteLine();
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            break;
        default:
            if (opcion != 0)
            {
                Console.WriteLine($"El numero {opcion} no esta dentro de las opciones, vuelva a intentarlo.");
                opcion = -1;
                Console.ReadKey();
            }
            break;
    }
}