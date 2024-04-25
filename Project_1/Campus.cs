using System;
namespace Project_1
{
	 public  class Campus
    {
        

        private int[] _nomEleve;


        public abstract void CreerNoveau();

        public void   ListerEleves()
        {

            Console.WriteLine(_eleves);
        }


        public void AfficherUnEleve()
        {
            SaisieUtilisateur saisieUtilisateurAfficheUnEleve = new SaisieUtilisateur();
            saisieUtilisateurAfficheUnEleve.SaisieUtilisateurAfficherUnEleve();


        }

       
    }
}

