using System;
namespace Project_1
{
	public class SaisieUtilisateur
	{
        private Cours[] _cours;
        private Eleves[] _eleves; 

        public void ReturnMenu1()
        {
            Menu1 menu1 = new Menu1();
            menu1.Menu_1();

        }

        public void SaisieUtilisateurMenu1()
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






        public void SaisieUtilisateurMenu2Eleves()
        {
            Console.Clear();
            Console.WriteLine(("").PadRight(100, '*'));
            Console.WriteLine("*");
            Console.WriteLine("* Choisissez une des options en tappant son numero correspondent :\n" +
             "* 1 - Lister les élèves\n" +
             "* 2 - Créer un nouvel élève\n" +
             "* 3 - Consulter un élève existant\n" +
             "* 4 - Ajouter une note et une appréciation pour un cours sur un élève existant\n" +
             "* 5 - Revenir au menu principal\n");
            Console.WriteLine(("").PadRight(100, '*'));

            string option = Console.ReadLine();

            int saisirUtilisateur = Convert.ToInt32(option);



            if (saisirUtilisateur == 1)
            {
                Eleves eleves = new Eleves();
                eleves.Lister(); //pas encore cree

            }
            if (saisirUtilisateur == 2)
            {
                Console.Clear();

                Console.WriteLine((" ").PadRight(100, '*'));
                Console.WriteLine("");
                Console.WriteLine("*Entrez le Nom de l'élève:");
                string nom = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("*Entrez le Prenom de l'élève :");
                string prenom = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("*Entrez sa date de naissance de l'élève:");
                string dateDeNaissance = Console.ReadLine();

                Eleves eleves = new Eleves();
                nom = eleves.Nom;
                prenom = eleves.GetPrenom();
                dateDeNaissance = eleves.GetDateDeNaissance();
                eleves.GetListeEleves();


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
                ReturnMenu1();
            }
        }


        public void SaisieUtilisateurMenu3Cours()
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
                
                Console.WriteLine(_cours);
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
                ReturnMenu1();
            }
        }


        public void SaisieUtilisateurCreerCours()
        { 
            Console.WriteLine("Entrez le Nom du nouveau cours:");
            string nom = Console.ReadLine();


        }


        public void SaisieUtilisateurAfficherUnEleve(Eleves eleves)
        {
            Console.WriteLine("Entrez le Nom de l'élève à consulter:");
            string saisirUtilisateur = Console.ReadLine();
            bool nomTrouve == 
            int i = 0;
            while (saisirUtilisateur!!)
            {

            }
            
             
            

        }
    }

}

