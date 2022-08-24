using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Text;
using System.Threading;

namespace Program3
{
    class Program
    {
        static byte size = 30;
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                MemoryMappedFile mmf = MemoryMappedFile.OpenExisting("Numbers");
                Semaphore semaphore = Semaphore.OpenExisting("NumbSem");
                Console.WriteLine("Push space");
                while (Console.ReadKey().Key != ConsoleKey.Spacebar)
                {
                    Console.WriteLine("Error");
                }
                Console.Clear();

                var stream = mmf.CreateViewStream();
                var handle = stream.SafeMemoryMappedViewHandle;
                unsafe
                {
                    byte* pointer = null;
                    handle.AcquirePointer(ref pointer);

                    for (int i = 1; i < size; i++)
                    {
                        for (int j = 0; j < size - i; j++)
                        {
                            try
                            {
                                semaphore.WaitOne();

                                if (*(pointer + j) < *(pointer + j + 1))
                                {
                                    Swap(ref *(pointer + j), ref *(pointer + j + 1));
                                }
                            }
                            finally
                            {
                                semaphore.Release();
                            }
                            Thread.Sleep(100);
                        }
                    }
                }
                Console.WriteLine("Done");
                Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            catch (WaitHandleCannotBeOpenedException)
            {
                Console.ReadLine();
            }

        }
        static void Swap(ref byte a, ref byte b)
        {
            var t = a;
            a = b;
            b = t;
        }
    }
}