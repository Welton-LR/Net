//ChatBot para criar personagem RPG
namespace Net
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Vamos criar o seu personagem!");
            Console.WriteLine("Digite seu primeiro nome");
            string? nome = Console.ReadLine();
            Console.WriteLine("Digite seu segundo nome");
            string? segundoNome = Console.ReadLine ();
            string nomeCompleto = nome + " " + segundoNome;
            Console.WriteLine($"Muito bem, {nomeCompleto}! Agora vamos escolher suas armas.");
            Console.WriteLine("Digite o número da sua arma: 1.Espada, 2.Arco e flecha, 3.Magia, 4.Tacape");
            int arma = Convert.ToInt32(Console.ReadLine());
        

                switch (arma)
                {
                    case 1:
                        Console.WriteLine($"Espada é sua arma, {nome}!");
                        break;
                    case 2:
                        Console.WriteLine($"Arco é sua arma, {nome}!");
                        break;
                    case 3:
                        Console.WriteLine($"Magia é sua arma, {nome}!");
                        break;
                    case 4:
                        Console.WriteLine($"Tacape é sua arma, {nome}!");
                        break;
                    default:
                        Console.WriteLine("Arma não disponível. Escolha uma da lista:");
                    break;
                }
        }
    }
}
