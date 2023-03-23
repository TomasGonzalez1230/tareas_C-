public class Personas
    {
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string FechaNacimiento { get; set; }
        
        public string LugarNacimiento { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string IDEstatus { get; set; }
        public string EstatusCedulaAzul { get; set; }
        public string CedulaAnterior { get; set; }
        public bool ok { get; set; }
        public string foto { get; set; }


        public string edad(){
          var fecha = DateTime.Parse(this.FechaNacimiento);
          var ahora = DateTime.Now;
          var edad = ahora.Year - fecha.Year;
          return edad.ToString();
        }
    }
