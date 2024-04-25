using System;
namespace Project_1
{
	public class Cours :Campus
	{
        private string _nom;
        private int _identifiant;
        private string [] _cours { get; set; }



        public override void CreerNoveau()
        {
            SaisieUtilisateur saisieUtilisateurCreerCours = new SaisieUtilisateur();
            saisieUtilisateurCreerCours.SaisieUtilisateurCreerCours();

            for (int i = 0; i < _cours.Length; i++)
            {
                _nom += _cours[i];
                i = _identifiant;
            }



        }

        public override void Lister()
        {
            throw new NotImplementedException();
        }
    }
}

