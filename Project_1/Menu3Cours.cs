using System;
namespace Project_1
{
	public class Menu3Cours
	{
        public void ReturnMenu()
        {
            Menu1 menu1 = new Menu1();
            menu1.Menu_1();

        }


     


        public void Menu_2()
        {

            Console.Clear();
            Console.WriteLine(("").PadRight(100, '*'));
            Console.WriteLine("*");
            Console.WriteLine("* Choisissez une des options en tappant son numero correspondent :\n" +
             "* 1 - Lister les cours existants\n" +
             "* 2 - Ajouter un nouveau cours au programme\n" +
             "* 3 - Supprimer un cours par son identifiant\n" +
             "* 4 - Ajouter une note et une appréciation pour un cours sur un élève existant\n" +
             "* 5 - Revenir au menu principal\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();

            int saisirUtilisateur = Convert.ToInt32(option);



            if (saisirUtilisateur == 1)
            {
                Console.WriteLine("");
            }
            if (saisirUtilisateur == 2)
            {
               
            }
            if (saisirUtilisateur == 3)
            {
                Console.WriteLine("");
            }
            if (saisirUtilisateur == 4)
            {
                Console.WriteLine("");
            }
            if (saisirUtilisateur == 5)
            {
                ReturnMenu();
            }
        }

    }
}

