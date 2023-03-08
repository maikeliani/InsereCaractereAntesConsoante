using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        string original, alterada;
        original = Console.ReadLine();
        alterada = InsereCaracter(original);
        Console.WriteLine(alterada);


        // strings  são imutáveis: após criadas, elas não podem ser editadas, apenas sobrescritas.
        // criar um vetor de caracteres para manipular
        // vetor criado tera o tamanho do dobro do tamanho da string (por garantia, vai inserir mais char)
        // dentro do metodo InsereCaractere() usou a variavel i para controle da original e o 'j' para controle da alterada
        string InsereCaracter(string original)
        {
            char[] aux = new char[original.Length * 2];
            string alterada = " ";
            for (int i = 0, j = 0; i < original.Length; i++)
            {
                if (original[i] != 'a' && original[i] != 'e' && original[i] != 'o' && original[i] != 'u')
                {
                    aux[j + 1] = original[i];
                    aux[j] = '.';
                    j = j + 2;
                }
                else
                {
                    aux[j] = original[i];
                    j++;
                }
            }

            for (int i = 0; i < aux.Length; i++)
            {
                alterada += aux[i];
            }
            return alterada;
        }
        Console.ReadLine();
    }
}