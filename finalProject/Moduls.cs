using Microsoft.EntityFrameworkCore;

class Moduls
{
    public static void manage()
    {
        bool continuar = true; 
        var db = new animeContext();

        while (continuar)
        {
            Console.WriteLine(@"

                1.Agregar
                2.Editar
                3.Elimanar
                4.Regressar
            ");

            string op = Utils.Input("ingrese la opvion>... ");

            switch (op)
            {
                case "1":
                    funcions.agregar();
                break;
                
                case "2":
                    funcions.modificar();
                break;
                
                case "3":
                    funcions.eliminar();
                break;
                
                case "4":
                    continuar = false;
                break;
                
                default:
                break;
            }
        }
    
    }

    public static void settings()
    {
        bool continuar = true;
        while (continuar)
        {
            var db = new animeContext();
            Console.WriteLine(@"
                1.Serie
                2.Estados
                3.Sexos
                4.Regresar
            ");
            var opcion = Utils.Input("ingrese la opcion: ");
            switch (opcion)
            {
                case "1":
                    Settings.Series();
                break;
                case "2":
                    Settings.Estados();
                break;
                case "3":
                    Settings.Sexos();
                break;
                case "4":
                    continuar = false;
                break;
                
                default:
                break;
            }
            
        }
        

    }

    public static void reports()
    {
        bool continuar = true;
        while(continuar)
        {   
            Console.WriteLine(@"
                1. listado De Personajes,
                2. Listado De personajes por signo zodiacal.
                3. Reportes de Cumpleaño.
                4. Mapas De Personajes.
                5. Exportar Personajes.
                6. Lista De Personajes Por Serie.
            ");
            var opcion = Utils.Input("ingrese la opcion Deseado: ");

            switch (opcion)
            {
                case "1":
                    Reports.ListadoPersonajes();
                break;
                case "2":
                    Reports.ListadoZodiaco();
                break;
                case "3":
                    Reports.ListadoCumple();
                break;
                case "4":
                    Reports.Mapas();
                break;
                case "5":
                    Reports.Exportar();
                break;
                case "6":
                    Reports.ListadoSerie();
                break;
                default:
                break;
            }
        } 
    }

    public static void about()
    {
        Console.WriteLine(@"
            Nombre: Tomas Gonzalez
            Matricula: 2022-0742
            Correo: Tongonzalez1230@outlook.com
        "); 
        
        var uri = "https://youtu.be/YBD6MCfYkIw";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);
    }
}