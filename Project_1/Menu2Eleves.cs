using System;
namespace Project_1
{
	public class Menu2Eleves
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
             "* 1 - Lister les élèves\n" +
             "* 2 - Créer un nouvel élève\n"+
             "* 3 - Consulter un élève existant\n" +
             "* 4 - Ajouter une note et une appréciation pour un cours sur un élève existant\n" +
             "* 5 - Revenir au menu principal\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();
            
            int saisirUtilisateur = Convert.ToInt32(option);

            

            if (saisirUtilisateur == 1)
            {
                Eleves eleves = new Eleves();
                eleves.Lister();

            }
            if (saisirUtilisateur == 2)
            {
                Eleves eleves = new Eleves();
                eleves.CreerNoveau();
            }
            if (saisirUtilisateur == 3)
            {
                Console.WriteLine("Consulter un élève existant");
            }
            if (saisirUtilisateur == 4)
            {
                Console.WriteLine("Ajouter une note et une appréciation pour un cours sur un élève existant");
            }
            if (saisirUtilisateur == 5)
            {
                ReturnMenu();
            }
        }




    }
}

