using System;

/*Foi realizada uma pesquisa de algumas características físicas da população de uma certa região, 
 * a qual coletou os seguintes dados referentes a cada habitante para serem analisados:

• Sexo (masculino ou feminino)

• Cor dos olhos (azuis, verdes, castanhos)

• Cor dos cabelos (louros, castanhos, pretos)

• Idade

Faça um algoritmo que determine e escreva:

• A maior idade dos habitantes

• A percentagem de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham
olhos verdes e cabelos louros.

Considerar 10 habitantes para a população */

namespace Dados_da_população
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 0, porcentagem = 0, porc_fem = 0;
            int idade, maior_idade = 0;
            int sexo_masc = 0, sexo_fem = 0;
            int olhos_azuis = 0, olhos_verdes = 0, olhos_castanhos = 0;
            int cab_louros = 0, cab_castanhos = 0, cab_pretos = 0;
            string sexo, olhos, cabelos;

            while (cont < 10 )
            {
                Console.Write("Informe o sexo: masculino/feminino => ");
                sexo = Console.ReadLine();

                

                if (sexo == "masculino")
                {
                    sexo_masc++;
                }

                else if (sexo == "feminino")
                {
                    sexo_fem++;              
                }

                Console.Write("Informe a cor dos olhos: azuis/verdes/castanhos => ");
                olhos = Console.ReadLine();

                if (olhos == "azuis")
                {
                    olhos_azuis++;
                }

                else if (olhos == "verdes")
                {
                    olhos_verdes++;
                }

                else if (olhos == "castanhos")
                {
                    olhos_castanhos++;
                }

                Console.Write("Informe a cor dos cabelos: louros/castanhos/pretos => ");
                cabelos = Console.ReadLine();

                if (cabelos == "louros")
                {
                    cab_louros++;
                }

                else if (cabelos == "castanhos")
                {
                    cab_castanhos++;
                }

                else if (cabelos == "pretos")
                {
                    cab_pretos++;
                }

                Console.Write("Informe a sua idade => ");
                idade = int.Parse(Console.ReadLine());

                if (idade > maior_idade)
                {
                    maior_idade = idade;
                }

                if ((sexo == "feminino") && (idade > 18 && idade <= 35) && (olhos == "verdes") && (cabelos == "louros"))
                {
                    porc_fem++;
                }

                cont++;
            }

            porcentagem = (porc_fem * 100) / 10;
           
            Console.WriteLine("A maior idade é a de {0:N0} anos", maior_idade);

            Console.WriteLine("A porcentagem de mulheres com idade de 18 a 35 anos de olhos verdes e cabelos louros é de {0:N}%", porcentagem);

            Console.ReadKey();
        }
    }
}
