using System;
namespace Project_1
{
	public class Cours :Campus
	{
        private string [] _cours { get; set; }



        public override void CreerNoveau()
        {
            Console.WriteLine("Entrez le Nom de l'élève:");
            string nom = Console.ReadLine();

            for (int i = 0; i < _cours.Length; i++)
            {
                nom = _cours[i];
            }



        }

        public override void Lister()
        {
            throw new NotImplementedException();
        }
    }
}

