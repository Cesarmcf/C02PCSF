using System;

namespace D02_Algoritmia
{
    public static class E02_MaiorIdade
    {

        public static void AnalisarMaioridade()
        {

            // Declarar variável
            int idade;

            // Manipular idade
            Console.Write("Escreve a tua idade: ");
            
            //Atribuir o que vem da consola á variavel
            idade = Convert.ToInt16(Console.ReadLine());

            //Avaliar a idade
            if (idade >= 18)
            {
                Console.WriteLine("A tua idade é:" + Convert.ToString (idade) + "\tÉs maior de Idade");
            }
            else
            {
                Console.WriteLine("A tua idade é:" + Convert.ToString(idade) + "\tÉs menor de Idade");
            }

            //Pausar a consola
            Console.ReadLine();

        }
    }
}
