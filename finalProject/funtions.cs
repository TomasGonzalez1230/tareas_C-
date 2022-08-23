using Microsoft.EntityFrameworkCore;
class funcions
{
    public static void agregar()
    {
        var db = new animeContext();
        
        var personaje = new Personaje();
        List<Serie> serie = db.series.ToList();

        Console.WriteLine("SERIES");
        foreach (var items in serie)
        {
            Console.WriteLine(@$"
                {items.id} - {items.nombre}
                _______________________________
            ");
        }

        personaje.nombre = Utils.Input("ingrse el Nombre del personaje:");
        personaje.apellido = Utils.Input("ingrse el Apellido del personaje:");
        personaje.foto = Utils.Input("ingrse la url de la foto del personaje (puede buscar una imagen en google y pegar el link):");
        personaje.pronunciacion = Utils.Input("ingrese la pronunciacion del personajes");
            var s = serie.Find( s => s.id == Utils.InputInt("ingrese le id de la serie que pertenece el personaje: ")); 
            if ( s != null )
            {
                personaje.serie = s;
            }
            else
            {
                Console.WriteLine("serie no encontrada :(");
                return;
            }
        personaje.fecha_nacimiento = Utils.InputDate("ingrese la fecha de nacimiento YYYY/MM/DD: ");
        personaje.poder = Utils.Input("igrese el poder del personaje:");
        personaje.frase = Utils.Input("ingrese la frase del Personaje: ");
        personaje.descripcion = Utils.Input("ingrese la descripcion de vestimenta: ");
        personaje.altura = Utils.Input("Ingrese la altura del personaje: ");
        personaje.sexo = Utils.Input("ingrese el sexo del personaje: ");
        personaje.estado = Utils.Input("ingrese el estado del Personaje: ");
        personaje.direccin = Utils.Input("ingrese la direccion del personaje: ");
        personaje.latitud = Utils.InputFloat("ingrese la latitud del personaje: ");
        personaje.longitud = Utils.InputFloat("ingrese la longitud del personaje: ");

        db.personajes.Add(personaje);
        db.SaveChanges();
    }

    public static void modificar()
    {
        var db = new animeContext();
        
        var personaje = new Personaje();
        List<Personaje> personajes = db.personajes.ToList();
        List<Serie> serie = db.series.ToList();

        Console.WriteLine("PERSONAJES");
        foreach (var items in personajes)
        {
            Console.WriteLine(@$"
                {items.id} - {items.nombre}
                _______________________________
            ");
        }

        var opcion = Utils.InputInt("ingrese el id del peronaje que decea Modificar: ");
        var p = db.personajes.Find(opcion);
            if ( p == null )
            {
                Console.WriteLine("personaje no encontrado :(");
            }
            else
            {

                personaje.nombre = Utils.Input("ingrse el Nombre del personaje:");
                personaje.apellido = Utils.Input("ingrse el Apellido del personaje:");
                personaje.foto = Utils.Input("ingrse la url de la foto del personaje (puede buscar una imagen en google y pegar el link):");
                    foreach (var items in serie)
                    {
                        Console.WriteLine(@$"
                        {items.id} - {items.nombre}
                        _______________________________
                    ");
                    }
                    var s = serie.Find( s => s.id == Utils.InputInt("ingrese le id de la serie que pertenece el personaje: ")); 
                    if ( s != null )
                    {
                        personaje.serie = s;
                    }
                    else
                    {
                        Console.WriteLine("serie no encontrada :(");
                        return;
                    }
                personaje.fecha_nacimiento = Utils.InputDate("ingrese la fecha de nacimiento YYYY/MM/DD: ");
                personaje.poder = Utils.Input("igrese el poder del personaje:");
                personaje.frase = Utils.Input("ingrese la frase del Personaje: ");
                personaje.descripcion = Utils.Input("ingrese la descripcion de vestimenta: ");
                personaje.altura = Utils.Input("Ingrese la altura del personaje: ");
                personaje.sexo = Utils.Input("ingrese el sexo del personaje: ");
                personaje.estado = Utils.Input("ingrese el estado del Personaje: ");
                personaje.direccin = Utils.Input("ingrese la direccion del personaje: ");
                personaje.latitud = Utils.InputFloat("ingrese la latitud del personaje: ");
                personaje.longitud = Utils.InputFloat("ingrese la longitud del personaje: ");

                db.personajes.Add(personaje);
                db.SaveChanges();

                return;
            }

    }

    public static void eliminar()
    {
        var db = new animeContext();

        List<Personaje> personajes = db.personajes.ToList();

        Console.WriteLine("PERSONAJES");
        foreach (var items in personajes)
        {
            Console.WriteLine(@$"
                {items.id} - {items.nombre}
                _______________________________
            ");
        }

        var opcion = Utils.InputInt("ingrese el id del peronaje que decea eliminar: ");

        var p = db.personajes.Find(opcion);
            if ( p == null )
            {
                Console.WriteLine("personaje no encontrado :(");
            }
            else
            {

                db.personajes.Remove(p);

                return;
            }
    }
}