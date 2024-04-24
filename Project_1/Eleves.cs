using System;
namespace Project_1
{
	public class Eleves : Campus
	{


        private string _prenom;
        private string _dateDeNaissance;
        private List<double> _notes = new List<double>();
        private string[] _listeEleves { get; set; }

      


        public string GetPrenom()
		{
			return _prenom;
		}

		public string GetDateDeNaissance()
		{

			return _dateDeNaissance;
            
        }

		public void   GetNotes()
		{
            
		}


        public void ConsulterEleve()
        {

        }


        public void AddNotes()
        {
            Console.WriteLine("Entrer une note: ");
            string note = Console.ReadLine();
            double saisirUtilisateur = Convert.ToDouble(note);
            Console.WriteLine("Laissez une appréciation : ");
            string appreciation = Console.ReadLine();


            for (int i = 0; i>=0; i++)
            {
                saisirUtilisateur = _notes[i];
               
             }


        }




        public override void CreerNoveau()
        {
            Console.WriteLine("Entrez le Nom de l'élève:");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez le Prenom de l'élève :");
            string prenom = Console.ReadLine();
            Console.WriteLine("Entrez sa date de naissance de l'élève:");
            string dateDeNaissance = Console.ReadLine();



            for (int i = 0; i < _listeEleves.Length; i++)
            {
                string noveauEleve = nom + prenom + dateDeNaissance;
                noveauEleve = _listeEleves[i];
                Identification = i;
            }
        }



        public override void Lister()
        {
            foreach (double note in _notes)
            {
                Console.WriteLine(note);
            }
            

        }
    }
}

