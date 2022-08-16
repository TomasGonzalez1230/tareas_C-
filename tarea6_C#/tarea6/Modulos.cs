using Microsoft.EntityFrameworkCore;
class Modulos
{
    public static void Configuracion(){
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"
            
                Configuracion
                P- provincias
                v- Vacunas
                r- Regresar
            ");
            string op = Utils.InputString("ingrese la opcion: ");
            switch (op)
            {
                case "p":
                    Console.WriteLine("Provincias");
                    Modulos.Conf_porvincioas();
                break;
                case "v":
                    Console.WriteLine("Vacunas");
                    Modulos.Conf_vacunas();
                break;
                case "r":
                    continuar = false;
                break;
                default:
                    Console.WriteLine("Opcion no valida");
                break;
            }
        }
    }


    public static void Conf_porvincioas(){
        bool continuar = true;
        var db = new covidContext();
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"
                Gestionar Porvincias

                1.Agregar
                2.Eliminasr
                3.Editar
                4.Regresar
            ");
            string op = Utils.InputString("ingrese la opcion: ");
            switch (op)
            {
                case "1":
                    Console.WriteLine("Agregar una provicina");
                    var p = new Provicnia();
                    p.Nombre = Utils.InputString("Ingrese el nombre de la provincia");

                    
                    
                        db.provicnias.Add(p);
                        db.SaveChanges();
                    
                break;
                case "2":
                    Console.WriteLine("Eliminar una provicina");
                    
                    List<Provicnia> provincia = db.provicnias.ToList();
                    
                    foreach (var item in provincia)
                    {
                        Console.WriteLine(@$"
                        
                                {item.id} - {item.Nombre}
                        ");
                    }
                    int id = Utils.InputInt("Ingrese el id de la provincia que decea eliminar: ");
                    var eliminar = db.provicnias.Find(id);
                    if (eliminar == null)
                    {
                        Console.WriteLine("No se encontro ningun id");
                        Utils.pausa();
                        break;
                    }else{
                       
                        db.Remove(eliminar);
                        db.SaveChanges();
                        Console.WriteLine("provincia eliminada");
                    } 
                break;
                case "3":
                    Console.WriteLine("Agregar una provicina");
                    var pro = new Provicnia();
                    List<Provicnia> provincias = db.provicnias.ToList();
                    
                    foreach (var item in provincias)
                    {
                        Console.WriteLine(@$"
                        
                                {item.id} - {item.Nombre}
                        ");
                    }
                    int idd = Utils.InputInt("Ingrese el id de la provincia que decea editar: ");
                    var editar = db.provicnias.Find(idd);
                    if (editar == null)
                    {
                        Console.WriteLine("No se encontro ningun id");
                        Utils.pausa();
                        break;
                    }else{
                        editar.Nombre = Utils.InputString("Ingrese el nuevo Nombre: ");
                        db.SaveChanges();
                        Console.WriteLine("provincia editada");
                    } 
                break;
                case "4":
                    continuar = false;
                break;
                default:
                    Console.WriteLine("opcion no valida");

                break;
            }
        }
    }

    public static void Conf_vacunas(){
        bool continuar = true;
        var db = new covidContext();
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine(@"

                gestor de vacunas

                1-Agregar
                2-ver vacunas agregadas
                3-editar
                4-eliminar
                x-salir

            ");
        string opcion = Utils.InputString("Ingrese la Opocio Deseada: ");

        switch (opcion)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("vamos agregar una vacuna: ");

                var vacuna = new Vacuna();
                
                vacuna.Nombre = Utils.InputString("Ingrese el nombre de la vacuna");
                db.vacunas.Add(vacuna);
                db.SaveChanges();
            break;  
            case "2":
                Console.Clear();
                Console.WriteLine("vamos eliminar una vacuna: ");

                List<Vacuna> v = db.vacunas.ToList();

                foreach (var item in v)
                {
                    Console.WriteLine(@$"
                        vacunas registradas:

                        {item.id}-{item.Nombre}
                        _____________________________________
                    ");
                }
                int id = Utils.InputInt("Introduce el id de la vacuna a eliminar");

                var eliminar = db.vacunas.Find(id);
                db.vacunas.Remove(eliminar);
                db.SaveChanges();

            break;
            case "3":
                Console.Clear();
                Console.WriteLine("vamos actualizar una vacuna: ");

                List<Vacuna> va = db.vacunas.ToList();

                foreach (var item in va)
                {
                    Console.WriteLine(@$"
                        vacunas registradas:

                        {item.id}-{item.Nombre}
                        _____________________________________
                    ");
                }

                int idd = Utils.InputInt("Ingrese el id de la vacuna que decea eliminar: ");

                var vas = db.vacunas.Find(idd);
                
                vas.Nombre = Utils.InputString("Ingrese el nuevo nombre: ");
                db.SaveChanges();
            break;
            case "4":
                Console.Clear();
                List<Vacuna> vacunas = db.vacunas.ToList();
                foreach (var item in vacunas)
                {
                    Console.WriteLine(@$"
                        Listado vacunas

                        {item.id}-{item.Nombre}
                        _____________________________________________
                    ");
                }
                Utils.pausa();
            break;
            case "x":
                continuar = false;
            break;
            
            default:
                Console.WriteLine("opcion no valida");
            break;
        }
        }
    }

    public static void Registar_vacunados(){
        var db = new covidContext();
        Console.Clear();
        Console.WriteLine("Registrar vacunados");
        
        var p = new Persona();
        var proceso = new Proceso();

        var cedula = Utils.InputString("ingrese la cedula sin guiones: ");
        p = db.personas.Where(x => x.cedula == cedula).FirstOrDefault();
        if (p == null)
        {
            p= new Persona();
            p.cedula = cedula;
            var personaCedula = new Persona_cedula();
            personaCedula.ok = false;
            try
            {
            var url = "https://api.adamix.net/apec/cedula/"+cedula;
            var client = new HttpClient();
            var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;

            personaCedula = Newtonsoft.Json.JsonConvert.DeserializeObject<Persona_cedula>(response);                
            }
            catch (System.Exception)
            {
                
                throw;
            }

            if (personaCedula.ok)
            {
                p.Nombre = personaCedula.Nombres;
                p.Apellido = personaCedula.Apellido1 + " " + personaCedula.Apellido2;
            }
            else{
                
                p.Nombre = Utils.InputString("Ingrese el nombre : ");
                p.Apellido = Utils.InputString("ingrese el apellido: ");
            }   
            p.telefono = Utils.InputInt("Digite el teléfono : ");
            db.personas.Add(p);
        }
        proceso.Persona = p;
        proceso.Fecha = DateTime.Now;
        
        
        var listadoVacunas = db.vacunas.ToList();
        foreach(var vac in listadoVacunas){
        Console.WriteLine($"{vac.id} - {vac.Nombre}");
        }
        while(proceso.Vacuna == null){
            int id = Utils.InputInt("Ingrese el id de la vacuna: ");
            var vacunas = db.vacunas.Find(id);
            if(vacunas == null){
                
                Console.WriteLine("Ha digitado un número inválido.");
                
                Utils.pausa();
            }
            else{
            proceso.Vacuna = vacunas;
            
            }
            
        }
        var listadoProvincias = db.provicnias.ToList();
        foreach(var prov in listadoProvincias){
        Console.WriteLine($"{prov.id} - {prov.Nombre}");
        }
        while(proceso.Provicnia == null){
            int idd = Utils.InputInt("ingrese el id de la provincia");
            var provincia = db.provicnias.Find(idd);
            if(provincia == null){
                       
                
                Console.WriteLine("Ha digitado un número inválido.");
                
    
            }
            else{
            proceso.Provicnia = provincia;
            
            }
        }
        db.procesos.Add(proceso);
        db.SaveChanges();
        Console.WriteLine("vacunado agregado");
        Utils.pausa();
    }
    
    public static void Exportar(){
        var db = new covidContext();
        Persona persona = null;
        while (persona == null)
        {
    
            var cedula = Utils.InputString("Ingrese la cédula sin guiones o (X) para ver el listado de los pacientes: ");
            if(cedula.ToLower().Trim() == "x"){
                var listadoPersonas = db.personas.ToList();
                foreach(var p in listadoPersonas){
                    Console.WriteLine($"{p.id} {p.cedula} {p.Nombre} {p.Apellido}");
                }
                cedula = Utils.InputString("Digite el id del paciente: ");
                persona = db.personas.Find(cedula);

            }else{
                persona = db.personas.Where(x => x.cedula == cedula).FirstOrDefault();
            }
        }
        var listadoProcesos = db.procesos.Where(x=> x.Persona.id == persona.id)
        .Include(x => x.Vacuna).Include(x => x.Provicnia).ToList();

        Console.WriteLine($"{persona.Nombre} {persona.Apellido}");
        var detalle = "";
        foreach(var proceso in listadoProcesos){
            Console.WriteLine($"{proceso.id} {proceso.Vacuna.Nombre} {proceso.Provicnia.Nombre} {proceso.Fecha.ToShortDateString()}");
            detalle += @$"
                <tr>
                    <td>{proceso.Fecha.ToShortDateString()}</td>
                    <td>{proceso.Vacuna.Nombre}</td>
                    <td>{proceso.Provicnia.Nombre}</td>
                </tr>
            ";
        }
        var html = @$"
        <html>
                <head>
                    <title>Tarjeta de vacunación de {persona.Nombre} {persona.Apellido} </title>
                </head>
                <body>
                    <div class= 'container'>
                    <img style = 'max-width: 200px' src= 'https://api.adamix.net/apec/foto2/{persona.cedula}' alt= 'logo' class= 'logo'>
                    <h1>Tarjeta de {persona.Nombre} {persona.Apellido}</h1>
                        <link rel='stylesheet' href'https://cdnjs.cloudflare.com/ajax/libs/materialize/1.0.0/css/materialize.min.css'>
                    <h3> Cédula {persona.cedula} </h3>
                    <h3> Teléfono {persona.telefono} </h3>
                        <h4> Procesos aplicados: </h4>
                        <table>
                        <thead>
                            <tr>
                                <th>Fecha</th>
                                <th>Vacuna</th>
                                <th>Provincia</th>
                                <th>Edad</th>
                            </tr>
                        </thead>
                        <tbody>
                        {detalle}
                            </tbody>
                        </table>
                    </div>
                </body>
                </html>



        ";
        System.IO.File.WriteAllText("tarjeta.html", html);
            

        Console.WriteLine("Tarjeta generada exitosamente");

        var uri = "tarjeta.html";
        var psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = true;
        psi.FileName = uri;
        System.Diagnostics.Process.Start(psi);
        Utils.pausa();

    }
}