using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tarea2
{
    class LeeArchivo
    {


        static void Main()
        {


            String line;
            string[] frases;
            try
            {
                
				
                StreamReader sr = new StreamReader("frases.txt");
                Console.WriteLine("Ingrese algunas frases");
               
                // Lee los valores almacenados en el archivo
                line = sr.ReadLine();


                while (line != null)
                {
             
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

 
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }


    }
}
