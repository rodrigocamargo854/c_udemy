using System;

namespace Strings {
    class Program {
        static void Main (string[] args) 
        {
            string original = "abcde EFGHIJ ABC abcd DEFGH";
            string s1 = original.ToUpper (); //maiusculo
            string s2 = original.ToLower ();//minusculo
            string s3 = original.Trim(); //apaga os espaços
            string s4 = original.IndexOf("bc"); // procura predicado em uma string retorna o index
            string s5 = original.LastIndexOf("bc");//ultimo index de ocorrencia do predicado
            string s6 = original.Substring(3); // corta a partir do index inserido
            string s5 = original.Substring(3,5);//corta a partir com limite de 5 predicados
            string s6 = original.Replace('a','x');// troca a pelo x
            string s7 = original.Replace("abc","xy");
            bool v1 = String.IsNullOrEmpty(original); //  verifica se a string é vazia ou nao
            bool b2 = string.IsNullOrWhiteSpace(original); //verifica se é nulo ou espaço em branco
            string s9 = original.Split(",");



        }
    }
}