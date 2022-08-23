class Reports
{
    public static void ListadoPersonajes()
    {
        var db = new animeContext();
        List<Personaje> personajes = db.personajes.ToList();
         
        Console.WriteLine("{0,-10} {1,-10} {2,-15} {3,-10} {4,-5}", "nombre", "Apellido", "Serie", "Genero", "Edad");
        Console.WriteLine("".PadLeft(54, '_'));
        foreach (var items in personajes)
        {

            var serie = db.series.Find( items.serieid );

            DateTime nacimiento = items.fecha_nacimiento; //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

            Console.WriteLine($"{items.nombre,-10} {items.apellido,-10} {serie.nombre,-15} {items.sexo,-10} {edad,-5}");
        }
    }

    public static void ListadoZodiaco()
    {
        var db = new  animeContext();
        
        List<Personaje> personajes = db.personajes.OrderBy(p => p.fecha_nacimiento.Month).ThenBy(p => p.fecha_nacimiento.Day).ToList();


        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Aries");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=21&&mes==3)||(dia<=20&&mes==4))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Libra");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 2)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Marzo");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 3)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Escorpio");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=24&&mes==10)||(dia<=22&&mes==11))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Geminis");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=22&&mes==5)||(dia<=21&&mes==6))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Sagitario");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=23&&mes==11)||(dia<=21&&mes==12))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Cancer");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=21&&mes==6)||(dia<=23&&mes==7))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Capricornio");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=22&&mes==12)||(dia<=20&&mes==1))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Leo");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=24&&mes==7)||(dia<=23&&mes==8))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Acuario");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=21&&mes==1)||(dia<=19&&mes==2))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Virgo");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=24&&mes==8)||(dia<=23&&mes==9))
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Piscis");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if((dia>=20&&mes==2)||(dia<=20&&mes==3))
                Console.WriteLine(@$"---{items.nombre}");
        }
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();

        
    }

    public static void ListadoCumple()
    {
        var db = new  animeContext();
        
        List<Personaje> personajes = db.personajes.OrderBy(p => p.fecha_nacimiento.Month).ThenBy(p => p.fecha_nacimiento.Day).ToList();


        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Enero");
        foreach (var items in personajes)
        {
            
            var mes = items.fecha_nacimiento.Month;

            if(mes == 1)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Febrero");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 2)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Marzo");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 3)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Abril");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 4)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Mayo");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 5)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Junio");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 6)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Julio");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes==7)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Agosto");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 8)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Septiembre");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 9)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Octubre");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 10)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Noviembre");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 11)
                Console.WriteLine(@$"---{items.nombre}");
        }
        Console.WriteLine("".PadLeft(20, '_'));
        Console.WriteLine("Diciembre");
        foreach (var items in personajes)
        {
            var dia = items.fecha_nacimiento.Day;
            var mes = items.fecha_nacimiento.Month;

            if(mes == 12)
                Console.WriteLine(@$"---{items.nombre}");
        }
            Console.Write("Presiona una tecla para terminar . . . ");
            Console.ReadKey();
    }

    public static void ListadoSerie()
    {
        var db = new animeContext();

        List<Serie> serie = db.series.ToList();

        foreach (var items in serie)
        {
            var peronaje = db.personajes.Where(p => p.serieid == items.id);
            Console.WriteLine("".PadLeft(20, '_'));
            Console.WriteLine(items.nombre);
            foreach (var itemss in peronaje)
            {
                Console.WriteLine(itemss.nombre);
            }
        }
    }


    public static void Mapas()
    {
        Console.WriteLine("ver mapa");

        var db = new animeContext();

        List<Personaje> personajes = db.personajes.ToList();


        var marcador = "";

        foreach (var items in personajes)
        {
            marcador += @$"
        
        var marker = L.marker([{items.latitud}, {items.longitud}]).addTo(map)
		.bindPopup(`
            Nombre: {items.nombre}
        `)

        ";
        }

        var plantilla = System.IO.File.ReadAllText("mapa.html");
        plantilla = plantilla.Replace("CODIGOC#", marcador);
        System.IO.File.WriteAllText("mapa1.html", plantilla);
        
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = "mapa1.html";
        System.Diagnostics.Process.Start(psi);


        
         
    }

    public static void Exportar()
    {
        var db = new animeContext();

        List<Personaje> personajes = db.personajes.ToList();

        
        var marcador = "";
        
        foreach (var items in personajes)
        {
            var serie = db.series.Find(items.serieid);
            marcador += @$"
            
                
                    <tr>
                        <td>{items.nombre}</td>
                        <td>{items.apellido}</td>
                        <td style='widtd: 100px;'>
                            <img src='{items.foto}' width=' 100px' >
                        </td>
                        <td>{items.pronunciacion}</td>
                        <td>{items.fecha_nacimiento}</td>
                        <td>{items.frase}</td>
                        <td>{items.poder}</td>
                        <td>{items.descripcion}</td>
                        <td>{items.altura}</td>
                        <td>{items.sexo}</td>
                        <td>{items.estado}</td>
                        <td>{items.descripcion}</td>
                        <td>{items.latitud}</td>
                        <td>{items.longitud}</td>
                        <td>{serie.nombre}</td>
                    </tr>
            
            ";

        }

        var plantilla = System.IO.File.ReadAllText("personajes.html");
        plantilla = plantilla.Replace("PERSONAJES", marcador);
        System.IO.File.WriteAllText("personajes1.html", plantilla);
        
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = "personajes1.html";
        System.Diagnostics.Process.Start(psi);
        



    }
}