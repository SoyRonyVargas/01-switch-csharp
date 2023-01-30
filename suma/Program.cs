// Alumno: Porraz Vargas Rony

// suma 5 numeros
// restar 2 numeros
// iva de una compra
// dolares a pesos
// area de un triangulo

using suma;

while (true)
{



    Programa programa = new Programa();

    Console.WriteLine("\n\n Menu \n\n");
    Console.WriteLine("1) Sumar 5 numeros");
    Console.WriteLine("2) Restar 2 numeros");
    Console.WriteLine("3) Iva de una compra");
    Console.WriteLine("4) Dolar a pesos");
    Console.WriteLine("5) Area de un triangulo");


    int entrada = int.Parse(Console.ReadLine());

    programa.Clear();

    switch (entrada)
    {
        case 1:
            programa.SumarNumeros();
        break;
        case 2:
            programa.RestarNumerosUI();
        break;
        case 3:
            programa.IVACompra();
            break;
        case 4:
            programa.DolarAPeso();
        break;
        case 5:
            programa.AreaTriangulo();
        break;
        default:
            Console.WriteLine("Opcion no valida");
        break;
    }

};




//int numero1 = int.Parse(Console.ReadLine());