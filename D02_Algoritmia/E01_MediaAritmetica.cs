using System;

namespace D02_Algoritmia
{
    public static class E01_MediaAritmetica
    {

        // Método = method = bloco de código para executar uma ação ( void não devolve resultado)
        public static void CalcularMediaAritemetica()
        {
            #region E01. Média aritmética


            // 1. Declarar variáveis (camelCase)

            /*
            double nota01;
            double nota02;
            double media;
            */

            // ou pode fiacar:
            
            double nota01, nota02, media;

            // 2. Manipular a 1ª nota (ler e escrever)
            Console.Write("1ª nota: "); //o WriteLine é para mudar de linha
                        
            // Atribuir a um double o que vem da consola (string), convertendo
            nota01 = Convert.ToDouble(Console.ReadLine());


            // 3. Manipular a 2ª nota (ler e escrever)
            Console.Write("2ª nota: "); //o WriteLine é para mudar de linha
            
            // Atribuir a um double o que vem da consola (string), convertendo
            nota02 = Convert.ToDouble(Console.ReadLine());

            // 4. Calcular a média
            Console.WriteLine();
            media = (nota01 + nota02) / 2;
            Console.WriteLine();

            // na matemática  { [ ( ) ] }
            // na programação ( ( ( ) ) )

            // 5. Mostrar a média
            Console.WriteLine("\nMédia: " + Convert.ToString(media)); // Concatenação ( é má pratica usar a conversão implicita, devemos sermpre converter )
            
            // 6. Avaliar a média  com a estrutura condicional
            if (media >= 9.5)
            {
                //True
                Console.WriteLine("Aprovado!");

            }

            else

            {
                //False
                Console.WriteLine("Reprovado!");

            }

            // 7. Pausar a consola
            Console.ReadLine();
            
            #endregion
        }



    }
}
