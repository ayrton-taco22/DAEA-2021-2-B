using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjLab01_1
{
    class Program
	{
        //Método para sumar
        static int Suma(int a, int b)
		{
			return a + b;
		}

        //Método para restar
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Método para multiplicar
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        //Método para Dividir
        static int Dividir(int a, int b)
        {
           return a / b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
		{
			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
			}
		}

        //10 primeros números primos
        static void Primos()
        {
            int contador = 0, n = 0, i = 1, j = 1;
            while (n < 10)
            {
                j = 1;
                contador = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                        contador++;
                    j++;
                }
                if (contador == 2)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    n++;
                }
                i++;
            }
        }

        //Conversor de temperatura 
        static void Conversion()
        {
            string opcion;
            Console.WriteLine("[1] Centigrados a Fahrenheit");
            Console.WriteLine("[2] Fahrenheit a Centigrados");
            opcion = Console.ReadLine();
            Console.WriteLine("Ingrese la temperatura");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            if (opcion.Equals("1"))
            {
                double faren = ((9 * temperatura) / 5) + 32;
                Console.WriteLine("La conversion de {0} grados centígrados es {1} grados fahrenheit", temperatura, faren);
            } else if (opcion.Equals("2"))
            {
                double centi = (5 * (temperatura - 32)) / 9;
                Console.WriteLine("La conversion de {0} grados fahrenheit es {1} grados centigrados", temperatura, centi);
            }
            else
            {
                Console.WriteLine("No es un opción válida");
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los primeros 10 números primos");
                Console.WriteLine("[7] Conversor de temperatura");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        if(c>d){
                            Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                            Console.ReadKey();
                            break;
                        }else{
                            Console.WriteLine("La resta de {0} y {1} es {2}", d, c, Resta(d, c));
                            Console.ReadKey();
                            break;
                        }
                        
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicar(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        bool invalid = false;
                        do
                        {
                            Console.WriteLine("Ingrese el segundo número");
                            int h = Convert.ToInt32(Console.ReadLine());
                            if (h == 0)
                            {
                                Console.WriteLine("No se puede efectuar una división entre 0");
                                invalid = true;
                            }
                            else
                            {
                                invalid = false;
                                if(g>h){
                                    Console.WriteLine("La división de {0} y {1} es {2}", g, h, Dividir(g, h));
                                }else{
                                    Console.WriteLine("La división de {0} y {1} es {2}", h, g, Dividir(h, g));
                                }
                            }
                        } while (invalid == true);
                        Console.ReadKey();
                        break;
                    case "6":
                        Primos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Conversion();
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        }
    }
}
