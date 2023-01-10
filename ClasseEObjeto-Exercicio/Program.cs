namespace ClasseEObjeto_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(100,"Rafael", 1000);
            c1.Sacar(1500);
            
            Console.WriteLine("SAldo: " + c1.ConsultaSaldo());

            
            Conta c2 = new Conta(200, "Felipe", 0);
            Conta c3 = new Conta(300, "Andrea", 3000);
            Conta c4 = new Conta(400, "Israel");
       
            Console.WriteLine(c3.Titular);
            Console.WriteLine(c3.Saldo);

            /*

            c1.Depositar(500);
            Console.WriteLine("Saldo: " + c1.ConsultaSaldo());
            c1.Transferir(500,c2);
            Console.WriteLine("Saldo: " + c1.ConsultaSaldo());
            Console.WriteLine("Saldo: " + c2.ConsultaSaldo());
            */

         



           

        }
    }
}