using System;

namespace EjemploIF
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ValorDeLaPrenda = 0.00M;
            Console.WriteLine("Ingrese el valor de la prenda");
            string ValorenPantalla = Console.ReadLine();
            
            ValorDeLaPrenda =  Convert.ToDecimal( ValorenPantalla);

            int descuento = 0;

            int HoraDeHoy = DateTime.Now.Hour;
            bool GerenteAutorizo = false;

            if( (HoraDeHoy >= 20 && ValorDeLaPrenda > 150) || GerenteAutorizo)
            {
              descuento = 12;   
            }
            else
            {
                descuento = 0;   
            }

            

            //int descuento = ValorDeLaPrenda > 150 ? 12 : 5;
            

            if(ValorDeLaPrenda > 150)
            {
                descuento = 12;
                Console.WriteLine("me gane un superdescuento");

            }
            else
            {
                descuento = 5;
                Console.WriteLine("el desuentoe es normal");
            }

            Console.WriteLine("Linea Anterior");

            Console.WriteLine("Ulitma linea");

        }
    }
}
