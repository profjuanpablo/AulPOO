namespace ClassesEObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciar objeto
            Aluno a1 = new Aluno();
            Aluno a2 = new Aluno();
            
            a1.NomeDoAluno = "Edilson Marques";
            a1.b1 = 8;
            a1.b2 = 9.5;
            a1.b3 = 8.9;
            a1.b4 = 10;
            a1.CalcularMediaFinal();
            //a1.media = (a1.b1 + a1.b2 + a1.b3 + a1.b4) / 4;

            a2.NomeDoAluno = "Hugo";
            a2.b1 = 7.8;
            a2.b2 = 6.5;
            a2.b3 = 4.9;
            a2.b4 = 8;
            a2.CalcularMediaFinal();



           // a2.media = (a2.b1 + a2.b2 + a2.b3 + a2.b4) / 4;
            Console.WriteLine("Aluno: " + a1.NomeDoAluno);
            Console.WriteLine("Média: " + a1.media);
            Console.WriteLine("-------------------");
            Console.WriteLine("Aluno: " + a2.NomeDoAluno);
            Console.WriteLine("Média: " + a2.media); 

        }

        
    }

   
}

