using System;

namespace qwazaaarrrrrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroo heroo = new Heroo();
            Hopem1racle hopem1Racle = new Hopem1racle();
            while (heroo.hp > 0 && hopem1Racle.hp > 0)
            {
                Console.WriteLine("вы заходите в тронный зал...на троне сидит он...он воружен и готов нападать.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Готовьтесть к бою с ним");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"\tИнформация\tHopem1racle\tХепешка:{hopem1Racle.hp}\tАтака:{hopem1Racle.attack}");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"\tИнфромация\tHeroo\tХепешка:{heroo.hp}\tАтака:{heroo.attack}");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Атакуй подлеца");
                Console.WriteLine("1 - атаковать\n2 - убежать как можно дальше\n");
                string k = Console.ReadLine();
                int k1 = Convert.ToInt32(k);
                if (k1 == 1)
                {
                    hopem1Racle.Remaininghp();
                    Console.WriteLine($"\tУрона получено:{hopem1Racle.damage}\tХепешка:{hopem1Racle.hp}\tАттака:{hopem1Racle.attack}");
                    System.Threading.Thread.Sleep(1000);
                    heroo.Remaininghealth();
                    Console.WriteLine($"\tУрона получено:{heroo.damage}\tХепешка:{heroo.hp}\tАттака{heroo.attack}");
                }
                if (k1 == 2)
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Он вас съел- вы лопух");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine($"\tHopemiracle\tУрона получено:{hopem1Racle.notdamage}\tХепешка:{hopem1Racle.hp}\tАттака:{hopem1Racle.superattak}");
                    System.Threading.Thread.Sleep(1000);
                    heroo.Remaininghealth2();
                    Console.WriteLine($"\tHeroo\tУрона получено:{heroo.superdamage}\tХепешка:{heroo.hp}\tАттака:{heroo.notdamage}");//блять это идеально
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("GAME OVER");
                    System.Threading.Thread.Sleep(1000);

                }
                if (hopem1Racle.hp == 500)
                {
                    Console.WriteLine("Вы нашли супер крутой меч на 10 млн мощи,будете ли вы его брать?");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("1 - взять\n2 - не брать\n");
                    System.Threading.Thread.Sleep(1000);
                    string h = Console.ReadLine();
                    int h1 = Convert.ToInt32(h);
                    if (h1 == 1)
                    {
                        Console.WriteLine("вы взяли этот супер крутой меч,теперь вы супер пупер крутой");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine($"\tИнформация\tHopem1racle\tХепешка:{hopem1Racle.hp}\tАтака:{hopem1Racle.attack}");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine($"\tИнфромация\tHeroo\tХепешка:{heroo.hp}\tАтака:{heroo.supersupersuperattack}");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine($"\tHopemiracle\tУрона получено:{hopem1Racle.supersupersuperdamageee}\tХепешка:{hopem1Racle.hp}\tАттака:{hopem1Racle.attack}");
                        System.Threading.Thread.Sleep(1000);
                        heroo.Remaininghealth2();
                        Console.WriteLine($"\tHeroo\tУрона получено:{heroo.damage}\tХепешка:{heroo.hp}\tАттака:{heroo.supersupersuperattack}");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("ну вы ваще крассавчик,https://www.youtube.com/watch?v=dQw4w9WgXcQ");
                        System.Threading.Thread.Sleep(1000);
                        if (h1 == 2)

                        {
                            Console.WriteLine("вы что дурак?");
                        }

                    }
                }
             }        
                       
                    
                     
                     


                    
                
             
               

        }

    
        
    } 
}      
