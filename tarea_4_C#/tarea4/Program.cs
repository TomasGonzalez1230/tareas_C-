// See https://aka.ms/new-console-template for more information
bool continuar = true;
while(continuar){
    Console.Clear();
    Console.WriteLine(@"
        1.Programa que acepte 3 lados de un triangulo, indique si este es equilatero, Isósceles, Escaleno.
        2.Programa que acepte 3 angulos de un triangulo: Rectángulo, Acutángulo u Obtusángulo.  
        3.Programa que acepte la medida de los cuatro ángulos de una figura: Determinar si esta es un cuadrado. 
        4.Programa que acepte un numero, mostrar en la consola la tabla de multiplicar de manera: 
        n x 1 = z
        n x 2 = z
        .......
        n x 13 = z
        5.Programa que solicite un numero, luego lea la siguiente url: https://randomuser.me/api/?results=10, cambiando el 10 por el numero que digito el usuario, luego mostrar en HTML el nombre, apellido y foto de cada persona. Indicar al final cuantas personas hay por genero. 
        Precione X para salir.

    !");
    Console.Write("Elije una opcion: ");
    var opcion = Console.ReadLine();
    if(opcion == "1")
    {
        Console.Clear();
        op.op1();
        Console.ReadKey();
    }
    else if(opcion == "2")
    {
        Console.Clear();
        op.op2();
    }
    else if(opcion == "3")
    {
        Console.Clear();    
        op.op3();
        Console.ReadKey();
    }
    else if(opcion == "4")
    {
        Console.Clear();
        op.op4();
    }
    else if(opcion == "5")
    {

    }
    else if(opcion == "x" || opcion == "X")
    {
        continuar = false;
    }
    else
    {
        Console.Write("opcion no valida!! ;(");
    }
}

// int[] arrayNumber = {12,32,53};

// for (int i = 0; i < arrayNumber.Length; i++)
// {
//     Console.WriteLine(arrayNumber[i]);
// }
