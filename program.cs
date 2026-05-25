using System;
namespace pro_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;
            while (continuar) // Bucle principal para permitir múltiples cálculos
            {
                Console.WriteLine("\n»——•——«»——•——«»——•——«CALCULADORA DE ÁREAS Y PERIMETROS»——•——«»——•——«»——•——«"); //portada
                Console.WriteLine("____________________________________________________________________________");
                Console.WriteLine(" QUÉ DESEA CALCULAR?");//menú
                Console.WriteLine("1-ÁREA: ");
                Console.WriteLine("2-PERIMETRO:");
                Console.WriteLine("3-SALIR");//te permite salir del programa
                Console.WriteLine("_________________________________________________________");


                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 3) //si la opcion es 3 
                {
                    continuar = false; //ya no se podra continuar con el programa

                    break;
                }
                //usamos el polimorfismo crear las figuras y cada una sepa que hacer para calcular su área y perímetro



                Console.WriteLine("¿QUÉ FIGURA DESEA CALCULAR?");
                Console.WriteLine("1-CÍRCULO");
                Console.WriteLine("2-TRIANGULO");
                Console.WriteLine("3-CUADRADO");
                Console.WriteLine("4-RECTÁNGULO");
                Console.WriteLine("5-ROMBO");
                Console.WriteLine("6-TRAPECIO");
                Console.WriteLine("_________________________________________________________");

                if (!int.TryParse(Console.ReadLine(), out int opcioncalcu))//validar que se ingrese un numero
                {
                    Console.WriteLine("Opción no válida.");//respuesta si no se ingresa

                }

                Figura figura = null; //en este momento no hay figura creada 

                switch (opcioncalcu) //segun la opcion se hacen los case 
                {
                    case 1:
                        double radio; //variable del circulo
                        Console.WriteLine("INGRESE EL RADIO DEL CÍRCULO: ");
                        radio = Convert.ToDouble(Console.ReadLine());
                        figura = new Circulo(radio); //se crear la figura 
                        break;
                    case 2:
                        double  lado1, lado2, lado3,bases,altura;
                        Console.WriteLine("INGRESE EL LADO 1 DEL TRIANGULO");
                        lado1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE EL LADO 2 DEL TRIANGULO");
                        lado2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE EL LADO 3 DEL TRIANGULO");
                        lado3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA BASE DEL TRIANGULO");
                        bases = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA ALTURA DEL TRIANGULO");
                        altura = Convert.ToDouble(Console.ReadLine());
                        
                       figura = new Triangulo(lado1, lado2, lado3,bases,altura);
                        break;
                    case 3:
                        double lado;
                        Console.WriteLine("INGRESE EL LADO DEL CUADRADO");
                        lado = Convert.ToDouble(Console.ReadLine());
                        figura = new Cuadrado(lado);
                        break;
                    case 4:
                        double baseR, alturaR;
                        Console.WriteLine("INGRESE LA BASE DEL RECTÁNGULO");
                        baseR = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA ALTURA DEL RECTÁNGULO");
                        alturaR = Convert.ToDouble(Console.ReadLine());
                        figura = new Rectangulo(baseR, alturaR);
                        break;
                    case 5:
                        double diagonalma, diagonalme;
                        Console.WriteLine("INGRESE LA DIAGONAL MAYOR DEL ROMBO");
                        diagonalma = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA DIAGONAL MENOR DEL ROMBO");
                        diagonalme = Convert.ToDouble(Console.ReadLine());
                        figura = new Rombo(diagonalma, diagonalme);
                        break;
                    case 6:
                        double Basemat, Alturat, Basemen, lado1t, lado2t;
                        Console.WriteLine(" INGRESE LA BASE MAYOR DEL TRAPECIO");
                        Basemat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA BASE MENOR DEL TRAPECIO");
                        Basemen = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE LA ALTURA DEL TRAPECIO");
                        Alturat = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE EL LADO 1 DEL TRAPECIO");
                        lado1t = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("INGRESE EL LADO 2 DEL TRAPECIO");
                        lado2t = Convert.ToDouble(Console.ReadLine());
                        figura = new Trapecio(Basemat, Basemen, Alturat, lado1t, lado2t);
                        break;


                }
                switch (opcion) //esta es para el primer menu, dependiendo si eligio area o perimetro
                {
                    case 1:
                        if (figura != null) //tienen que existir la figura
                        {
                            Console.WriteLine($"EL ÁREA DE LA FIGURA {figura.GetType().Name} ES: {figura.CalcularArea():F2}");
                            //se muestra el resultado con el get para que de el nombre y se declara el metodo correspondiente y F2 es
                            //para mostrar solo 2 decimales 
                        }
                        else
                        {
                            Console.WriteLine("No se pudo calcular el área de la figura.");//si la figura no existe se muestra esto
                        }
                        break;
                    case 2:
                        if (figura != null)
                        {
                            Console.WriteLine($"EL PERIMETRO DE LA FIGURA {figura.GetType().Name} ES: {figura.CalcularPerimetro():F2}");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo calcular el perímetro de la figura.");
                        }

                       break;
                }

              }
        }
    }
}
    


