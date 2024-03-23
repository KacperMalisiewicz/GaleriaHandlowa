using GaleriaHandlowa;

namespace Galerie
{
    internal class Europa
    {
        static void Main(string[] args)
        {
            Kontynent europa = new Kontynent();

            Kraj niemcy = new Kraj("D");
            europa.addKraj(niemcy);

            Miasto miasto1 = new Miasto("Frankfurt", niemcy);
            Miasto miasto2 = new Miasto("Dortmund", niemcy);

            niemcy.addMiast(miasto1);
            niemcy.addMiast(miasto2);

            Galeria galeria1 = new Galeria(miasto1);
            miasto1.addGaleria(galeria1);

            Sklep sklep = new Sklep(10, 7, galeria1);
            galeria1.addSklep(sklep);

            galeria1.addSklep(new Sklep(8, 4, galeria1));
            

            Galeria galeria2 = new Galeria(miasto2);
            miasto2.addGaleria(galeria2);
            galeria2.addSklep(new Sklep(11, 12, galeria2));
            galeria2.addSklep(new Sklep(7, 8, galeria2));
            galeria2.addSklep(new Sklep(4, 5, galeria2));

            Console.WriteLine("Ala ma kota");



        }
    }

}
