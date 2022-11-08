using System;

namespace caesar_cipher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Ввдите 1 для шивровки текста или 2 для дешифровки. " );
            int n = Convert.ToInt32(Console.ReadLine());

           Console.Write("ВВедите текст: ");
            string m = Console.ReadLine();

            int nomer; 
            int d; 
            string s; 
            int j; 

            char[] massage = m.ToCharArray(); 

            char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

            if (n == 1)
            {
                
                for (int i = 0; i < massage.Length; i++)
                {
                    
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (massage[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) 
                    {
                        nomer = j; 
                        d = nomer + 3; 

                        
                        if (d > 32)
                        {
                            d = d - 33;
                        }

                        massage[i] = alfavit[d]; 
                    }
                }
            }
            if (n == 2)
            { 
               
                for (int i = 0; i < massage.Length; i++)
                {
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (massage[i] == alfavit[j])
                        {
                            break;
                        }
                    }

                    if (j != 33) 
                    {
                        nomer = j; 
                        d = nomer - 3; 

                        
                        if (d > 32)
                        {
                            d = d - 33;
                        }

                        massage[i] = alfavit[d]; 
                    }
                }
            }
            s = new string(massage); 
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}