using System;
using System.IO;

namespace Entidades
{
    public static class GestorDeArchivo
    {
        static string rutaBase;
        static GestorDeArchivo()
        {
            GestorDeArchivo.rutaBase = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        public static void ApuntesYMetodosVistoEnClase()
        {
            /*
            Clases importantes:

            OperatingSystem:
            Console.WriteLine($"{OperatingSystem.IsWindows()}");
            Console.WriteLine($"{OperatingSystem.IsAndroid()}");

            Enviroment:
            Environment.GetFolderPath -> me permite acceder a la ruta del sistema operativo a través de SpecialFolder
            SpecialFolder es un enumerado
            */

            Environment.GetFolderPath(Environment.SpecialFolder.Desktop);//Esto me devuelve la ruta donde esta mi escritorio

            //Directorios: un directorio es una coleccion de archivos. 

            //Ruta absoluta: me dice la ubicacion exacta de un archivo
            //Ruta relativa: señala la ubicacion del archivo en relacion a la posicion actual
            // Se usa un punto contrabarra
            // . posicion actual donde estamos ubicacdos        .\miArchivo.txt
            // .. nos mueve al directorio padre de la ubicacion actual      ..\..\miArchivo.txt

            //Vamos a usar enviroment para usar esto:

            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += "\\misArchivos\\"; 
            //uso doble contrabarra pq una sola es una secuencia de escape o resuelvo con @\misArchivos

            //Clase Path puedo usar distintos metodos
            ruta += Path.Join(ruta, "misArchivos");
            Path.GetFullPath(ruta);
            Path.GetExtension(ruta);

            //CLASES PARA MANEJAR ARCHIVOS:
            //StreamWriter y StreamReader
        }

        //Metodo para escribir
        public static void Escribir(string ruta, string contenido)
        {
            StreamWriter sw = null;
            // StreamWriter tiene 3 sobrecargas que vamos a usar,
            // una recibe 1 solo parametro que es la ruta
            // otro, un segundo parametro para determinar si se puede appendear
            // y otro que recibe un tercer parametro para determinar el tipo de encodeo
            try
            {
                string nuevaRuta =$"{GestorDeArchivo.rutaBase}\\{ruta}";
                sw = new StreamWriter(nuevaRuta);
                //como puede devolver varias excepciones conviene hacer esto siempre dentro de un trycatch
                sw.WriteLine(contenido); // aca es donde escribo
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
            finally
            {
                //cerrar el archivo antes cualquier caso
                if(sw != null) //debo fijarme q sea distinto a null pq lo tengo inicializado y se me puede producir una excepcion
                    sw.Close();                
            }
        }
        //sobreCarga con append
        public static void Escribir(string ruta, string contenido, bool append)
        {
            StreamWriter sw = null;
            try
            {
                string nuevaRuta = $"{GestorDeArchivo.rutaBase}\\{ruta}";
                sw = new StreamWriter(nuevaRuta, append);
                sw.WriteLine(contenido);
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }
        //utilizando USING
        //StreamWriter hereda de TextWriter que implementa la interfaz IDisposable que tiene el metodo Dispose que destruye al objeto
        public static void Escribir2(string ruta, string contenido)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter($"{GestorDeArchivo.rutaBase}\\{ruta}",true))//en este caso no me tengo q preocupar por cerrar el archivo
                {
                    sw.WriteLine(contenido);//con el write line meto una enter, con el write apendea de corrido
                }
            }
            catch(Exception ex)
            {
                throw new ArchivoException("Error al escribir", ex);
            }
        }
        public static string Leer(string ruta)
        {
            string retorno = String.Empty;
            // StreamReader tiene 2 sobrecargas que vamos a usar,
            // una recibe 1 solo parametro que es la ruta,
            // y otro que recibe un segundo parametro para determinar el tipo de encodeo
            try
            {
                using(StreamReader sr = new StreamReader($"{GestorDeArchivo.rutaBase}\\{ruta}"))
                {
                    retorno = sr.ReadToEnd();//lee todo el archivo

                    //retorno = sr.ReadLine();//lee una linea nada mas
                    /*while(!sr.EndOfStream) OTRA FORMA DE LEER HASTA EL FINAL CON READLINE
                    {
                       retorno += sr.ReadLine() + "\n";
                    }*/

                    //retorno = char.ConvertFromUtf32(sr.Read());//de esta forma solo leo el primer caracter
                    /*for (int i = 0; i < 20; i++) PUEDO IR VIENDO CUANTOS CARACTERES LEER
                    {
                        retorno += char.ConvertFromUtf32(sr.Read());
                    }*/
                }
            }
            catch(Exception ex)
            { 
                throw new ArchivoException("Error al leer",ex);
            }
            return retorno;
        }
    }
}
