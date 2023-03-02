namespace System
{
    static class StringExtensions // Primeiramente vamos falar que é uma classe statica
    {
        public static string Cut(this string thisObj, int count) // Criar o extensions method. Coloca como string pq ele vai retornar como string
        { // O primeiro argumento tem que ser this como string e depois coloca o this como objeto. O cult recebe o numero inteiro, então a gente coloca o int count)
            if (thisObj.Length <= count) // Comecar testando se meu thisObj.Length for maior ou igual ao count
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "..."; // Retornar a string original.Substring começando da posição zero e a quantidade count, e apresentar no final os 3 pontinhos
            }
        }
    }
}