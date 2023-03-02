int total, votos;
int mateus, jose, maria, amanda;
double porcenmateus, porcenjose, porcenmaria, porcenamanda;

votos = 0;
mateus = 0;
jose = 0;
maria = 0;
amanda = 0;
total = 0;

while (votos != 5)
{
    Console.WriteLine("===============================================================");
    Console.WriteLine("|                         Votação                             |");
    Console.WriteLine("|                                                             |");
    Console.WriteLine("|           Para votar no candidato Mateus Pressione 1        |");
    Console.WriteLine("|           Para votar no candidato Jose Pressione 2          |");
    Console.WriteLine("|           Para votar na candidata Maria Pressione 3         |");
    Console.WriteLine("|           Para votar na candidata Amanda Pressione 4        |");
    Console.WriteLine("|                                                             |");
    Console.WriteLine("|             Para encerrar a votação pressione 5             |");
    Console.WriteLine("===============================================================");
    votos = int.Parse(Console.ReadLine());

    Console.Clear();

    switch (votos)
    {
        case 1:

            Console.WriteLine("Voto para candidato Mateus ");
            mateus++;

            break;

        case 2:
            Console.WriteLine("Voto para candidato Jose ");
            jose++;

            break;

        case 3:
            Console.WriteLine("Voto para candidata Maria ");
            maria++;

            break;

        case 4:
            Console.WriteLine("Voto para candidata Amanda ");
            amanda++;

            break;


        default:
            Console.WriteLine("===============================================================");
            Console.WriteLine("|                         Votação                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                  Votação encerrada                          |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|           Pressione qualquer tecla para continuara          |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("===============================================================");
            Console.ReadLine();
            break;
    }

}

Console.Clear();

Console.WriteLine("===============================================================");
Console.WriteLine("|                                                             |");
Console.WriteLine("|                                                             |");
Console.WriteLine("|                    Resultado da Votação                     |");
Console.WriteLine("|                                                             |");
Console.WriteLine("===============================================================");

total = mateus + jose + maria + amanda;
Console.WriteLine("Esta votação teve um total de " + total + " votos");

Console.WriteLine("Resultado de cada candidato");
Console.WriteLine("Mateus -> " + mateus);
Console.WriteLine("Jose -> " + jose);
Console.WriteLine("Maria -> " + maria);
Console.WriteLine("Amanda -> " + amanda);
Console.WriteLine("");

porcenmateus = (mateus * 100) / total;
porcenjose = (jose * 100) / total;
porcenmaria = (maria * 100) / total;
porcenamanda = (amanda * 100) / total;

Console.WriteLine("Porcentagem de votos");
Console.WriteLine("Mateus -> " + porcenmateus + "%");
Console.WriteLine("Jose -> " + porcenjose + "%");
Console.WriteLine("Maria -> " + porcenmaria + "%");
Console.WriteLine("Amanda -> " + porcenamanda + "%");
Console.WriteLine("");


if (mateus > jose && mateus > maria && mateus > amanda)
{
    Console.WriteLine(" O candidato Mateus foi o ganhador da votação");
}
if (maria > mateus && maria > jose && maria > amanda)
{
    Console.WriteLine(" A candidata Maria foi o ganhador da votação");
}
if (jose > mateus && jose > maria && jose > amanda)
{
    Console.WriteLine(" O candidato Jose foi o ganhador da votação");
}
if (amanda > mateus && amanda > jose && amanda > maria)
{
    Console.WriteLine(" A candidata Amanda foi o ganhador da votação");
}
if (mateus == maria)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Mateus e Maria");
}
if (mateus == jose)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Mateus e Jose");
}
if (mateus == amanda)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Mateus e Amanda");
}
if (maria == jose)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Maria e Jose");
}
if (maria == amanda)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Maria e Amanda");
}
if (amanda == jose)
{
    Console.WriteLine(" Ouve um empate entre os candidatos Amanda e Jose");
}
