using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLLView
{
    public class View
    {
        public static void Interface()
        {
            object operation;
            do
            {
                operation = scanf();
                if (toInt(operation) == 1) 
                {
                    Assembly asm = null;
                    try
                    {
                        asm = Assembly.LoadFrom(@"C:\Users\Yaroslav\Desktop\DLLWorkingSysProgramming\DLLcount\bin\Debug\DLLcount.dll"); 

                        if (asm == null) return;
                    }
                    catch (FileNotFoundException ex)
                    {
                        return;
                    }
                    Type tp;
                    try
                    {
                      
                        tp = asm.GetType("DLLcount.Calculate");
                        object ob = Activator.CreateInstance(tp);


                        MethodInfo mi;
                        mi = tp.GetMethod("Array");
                        int[] a = new int[500];
                        Random rnd = new Random();

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            a[i] = rnd.Next(-100, 200);
                        }
                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            Console.Write(a[i] + " ");
                        }
                        Console.WriteLine();
                        object[] parametrs = new object[]{a, 0, 499};
                        int[] array;

                        array = (int[])mi.Invoke(ob, parametrs);

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            } while (toInt(operation) != 0);
        }
       public static void printf(string message)
       {
            Console.WriteLine(message);
       }
        public static void printf(string message, object smth)
        {
            Console.WriteLine(message + smth.ToString());
        }
        public static object scanf()
        {
            return Console.ReadLine();
        }
        public static double toDouble(object value)
        {
           return Convert.ToDouble(value);
        }
        public static int toInt(object value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
               return 0;
            }
        }
    }
}
