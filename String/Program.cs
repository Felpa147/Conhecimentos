namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var frase = "           C# é uma linguagem moderna e versátil. " + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.            ";

            //length = número de letras
            var tamanho = frase.Length;

            //empty = cadeia de caracteres vazia == var x = " ";
            var vazio = string.Empty;

            //ToLowe,ToUpper = tudo em minúsculo ou maiusculo
            var fraseMinuscula = frase.ToLower();
            var fraseMaiscula = frase.ToUpper();

            //Split =  Método onde é encadeado uma array de strings, sendo separados pelo termo atribuido no metodo
            var frases = frase.Split('.');

            //Trim,TrimEnd,TrimStart = remover espaços em brancos e outras implementações
            var paragrafoTrim = frase.Trim();
            var paragrafoTrimEnd = frase.TrimEnd();
            var paragrafoStart = frase.TrimEnd();

            //IsNullOrWhiteSpace = Checa se é nulo ou vazio
            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(frase);

            //Replace = Substitui um caracter por outro
            var paragrafoCSharp = frase.Replace("C#", "C-Sharp");

            Console.ReadKey();

            // BUSCAS
            var outraFrase ="           C# é uma linguagem moderna e versátil. " + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.            ";


            //IndexOf char e string = Retorna o primeiro caractere digitado
            var indexOf = outraFrase.IndexOf("C#");

            //LasIndexOf char e string = retorna o ultimo caractere digitado
            var lastIndexOf = outraFrase.LastIndexOf("C#");

            //StartsWith char e string = uma condicional que retorna true ou false, caso o objeto comece com o parâmetro passado.
            var startswith = outraFrase.StartsWith("Com C#");

            //Substring int32 = posição onde começa e o seu tamanho
            var indexOfMobile = outraFrase.IndexOf("Mobile");
            var substring = outraFrase.Substring(indexOfMobile, 6);

            //Contains char e string = a condicional que você está colocando contem na variável
            var containsJogos = outraFrase.Contains("Jogos", StringComparison.OrdinalIgnoreCase); // ignora o sensitive case
            var containsJogosExato = outraFrase.Contains("Jogos"); // não ignora

        }

    }
}
