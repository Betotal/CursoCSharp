using System;
using Aula121_StringBuilder.Entities;

namespace Aula121_StringBuilder {
    class Program {
        static void Main(string[] args) {

            Comment C1 = new Comment("Tenha uma ótima viagem!");
            Comment C2 = new Comment("Ai Sim. que da hora!");

            Post P1 = new Post(
                DateTime.Parse("07/03/2019 15:00"),
                "Viagem para Nova Zelancia",
                "Estou indo conhecer este maravilhoso país",
                35);
            P1.addComment(C1);
            P1.addComment(C2);

            Comment C3 = new Comment("Boa Noite!");
            Comment C4 = new Comment("Vou fazer o mesmo!");

            Post P2 = new Post(
                DateTime.Parse("07/04/2019 23:15"),
                "Boa noite pessoal",
                "Vejo vcs amanhã",
                03);
            P2.addComment(C3);
            P2.addComment(C4);

            Console.WriteLine(P1);
            Console.WriteLine();
            Console.WriteLine(P2);


            Console.WriteLine("Hello World!");
        }
    }
}
