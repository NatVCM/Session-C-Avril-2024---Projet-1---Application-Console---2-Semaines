using System;
namespace Project_1
{
	public class Menu1
	{

		public void Menu_1()
		{

            Console.Clear();
            
            Console.WriteLine((" ").PadRight(100, '*'));
            Console.WriteLine("");
            Console.WriteLine(" Choisissez une des option en tappant son numero correspondent :\n" +
             " 1 - Eleves\n" +
             " 2 - Cours\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();
            int saisirUtilisateur = Convert.ToInt32(option);

            if (saisirUtilisateur == 1)
            {
                Console.WriteLine("Eleves");
            }
            if (saisirUtilisateur == 2)
            {
                Console.WriteLine("Cours");
            }
        }



    
	}
}

