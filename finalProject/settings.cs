class Settings
{
    public static void Series()
    {   
        bool continuar = true;
        while (continuar)
        {
            var db = new animeContext();
            Console.WriteLine(@"
                1.Agregar
                2.Editar
                3.Eliminar
                4.Regresar
            ");
            var opcion = Utils.Input("ingrese la opcion: ");
            switch (opcion)
            {
                case "1":
                    var serie = new Serie();

                    serie.nombre = Utils.Input("ingrese el Nombre de la serie: ");
                    db.series.Add(serie);
                    db.SaveChanges();
                break;
                case "2":
                    List<Serie> series = db.series.ToList();

                    Console.WriteLine("SERIES");
                    foreach (var items in series)
                    {
                        Console.WriteLine(@$"
                            {items.id} - {items.nombre}
                            _______________________________
                        ");
                    }
                    var id = Utils.InputInt("ingrese el id de la serie que decea Editar: ");
                    var s  = db.series.Find(id);
                    
                    s.nombre = Utils.Input("ingrese el nuevo nombre de la serie: ");
                    
                    db.SaveChanges();
                    
                break;
                case "3":
                    List<Serie> seriess = db.series.ToList();

                    Console.WriteLine("SERIES");
                    foreach (var items in seriess)
                    {
                        Console.WriteLine(@$"
                            {items.id} - {items.nombre}
                            _______________________________
                        ");
                    }
                    var idd = Utils.InputInt("ingrese el id de la serie que decea Editar: ");
                    var ss  = db.series.Find(idd);

                    db.series.Remove(ss);
                break;
                case "4":
                    continuar = false;
                break;
                
                default:
                break;
            }
        }
    }

    public static void Estados()
    {   
        bool continuar = true;
        while (continuar)
        {
            var db = new animeContext();

            List<Personaje> personajes = db.personajes.ToList();

            foreach (var items in personajes)
            {
                Console.WriteLine(@$"
                {items.id} - {items.nombre} - {items.estado}
                _______________________________________________________
                ");
            }

            var id = Utils.InputInt("ingrese el id del peronaje que decea Modificar: ");
            var p = db.personajes.Find(id);
            if ( p == null )
            {
                Console.WriteLine("personaje no encontrado :(");
            }
            else
            {
                p.estado = Utils.Input("ingrese le nuevoo estado del personaje: ");

                db.SaveChanges();
                continuar = false;
            }
            
        }
    }

    public static void Sexos()
    {
        bool continuar = true;
        while (continuar)
        {
            var db = new animeContext();

            List<Personaje> personajes = db.personajes.ToList();

            foreach (var items in personajes)
            {
                Console.WriteLine(@$"
                {items.id} - {items.nombre} - {items.sexo}
                _______________________________________________________
                ");
            }

            var id = Utils.InputInt("ingrese el id del peronaje que decea Modificar: ");
            var p = db.personajes.Find(id);
            if ( p == null )
            {
                Console.WriteLine("personaje no encontrado :(");
            }
            else
            {
                p.sexo = Utils.Input("ingrese le nuevoo sexo del personaje: ");

                db.SaveChanges();
                continuar = false;
            }   
            
        }
    }
}