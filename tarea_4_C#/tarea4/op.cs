class op
{
    public static void op1(){
        
        int n1,n2,n3;
        Console.WriteLine("Programa que acepte 3 lados de un triangulo, indique si este es equilatero, Isósceles, Escaleno.");
        n1 = InputNumer("ingresa el Primer lado");
        n2 = InputNumer("ingrese el segundo lado");
        n3 = InputNumer("ingrese el tercer lado");

        if (n1 == n2 && n2 == n3)
        {
            Console.WriteLine("es un triangulo equilatero");  
        }else if(n1 == n2 || n1 == n3 || n2 == n3){
            Console.WriteLine("es Isosceles");
        }else{
            Console.WriteLine("es un trianglo escaleno");
        }
    }
    
    public static void op2(){
        double n1,n2,n3;
        double mayor = 0;
        double menor1 = 0;
        double menor2 = 0;
        Console.WriteLine("2.Programa que acepte 3 angulos de un triangulo: Rectángulo, Acutángulo u Obtusángulo.");
        n1 = InputNumer("ingrese el primer lado: ");
        n2 = InputNumer("ingrese el segundo lado: ");
        n3 = InputNumer("ingrese el tercero lado: ");
        if(n1 >= n2 && n1 >= n3){
            mayor = n1;
            menor1 = n2;
            menor2 = n3;
        }else if (n2 >= n1 && n2 >= n3){
            mayor = n2;
            menor1 = n1;
            menor2 = n3;
        }else if (n3 >= n1 && n3 >= n2){
            mayor = n3;
            menor1 = n1;
            menor2 = n2;
        }
        
        if (Math.Pow(mayor, 2) == (Math.Pow(menor1,2) + Math.Pow(menor2,2)))
        {
            Console.WriteLine("el triangulo es Rectangulo");
        }
        else if (Math.Pow(mayor, 2) < (Math.Pow(menor1,2) + Math.Pow(menor2,2)))
        {
            Console.WriteLine("el triangulo es Acutanguno");
        }
        else if (Math.Pow(mayor, 2) > (Math.Pow(menor1,2) + Math.Pow(menor2,2)))
        {
            Console.WriteLine("el triangulo es Obtusánguno");
        }
        Console.ReadKey();
    }
    
    public static void op3(){
        int n1,n2,n3,n4;
        Console.WriteLine("3.Programa que acepte la medida de los cuatro ángulos de una figura: Determinar si esta es un cuadrado.");
        n1 = InputNumer("ingrese el primer angulo: ");
        n2 = InputNumer("ingrese el segundo angulo: ");
        n3 = InputNumer("ingrese el tecero angulo: ");
        n4 = InputNumer("ingrese el cuarto angulo: ");
        if ((n1 + n2 + n3 + n4) == 360)
        {
            Console.WriteLine("es un cuadrado");
        }else{
            Console.WriteLine("no es un cuadrado :(");
        }
    }
    
    public static void op4(){
        int n1;
        n1 = InputNumer("ingrese el numero de la tabla que decea ver: ");
        for (int i = 0; i <= 13; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", n1 , i,(n1 * i));
        }
        Console.ReadKey();
    }
    public static int InputNumer(String msm){
        int n = 0;
        try
        {
            Console.Write(msm);
            int.TryParse(Console.ReadLine(), out n);
        }
        catch (System.Exception e)
        {
            Console.WriteLine("la funcion InputNumer esta esperando un parametro y recivio 0 {0}", e);
        }
        return n;
    }
}