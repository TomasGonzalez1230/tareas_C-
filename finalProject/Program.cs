// See https://aka.ms/new-console-template for more information
bool continuar = true;
while (continuar)
{
    
    Console.WriteLine(@"

    Gestionar Personajes (A)
    Reportes (B)
    Configuracion (C)
    Acerca De (D)
    Salir (E)

    ");

    string opcion = Utils.Input("Elija la opcion... ");

    switch (opcion.ToUpper())
    {
        case "A":
            Moduls.manage();
        break;
        case "B":
            Moduls.reports();
        break;
        case "C":
            Moduls.settings();
        break;
        case "D":
            Moduls.about();
        break;
        case "E":
            continuar = false;
        break;
        default:
        break;
    }

}

