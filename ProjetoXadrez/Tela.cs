
using tabuleiro;

namespace ProjetoXadrez
{
    internal class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if (tab.getPeca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.getPeca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
