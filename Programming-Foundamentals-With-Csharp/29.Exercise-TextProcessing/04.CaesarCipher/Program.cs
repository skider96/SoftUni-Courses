namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
         char[] encryptedChars = input.ToCharArray();
        
            for (int i = 0; i < encryptedChars.Length; i++)
            {
                int asciiEquivalent = (int)encryptedChars[i] + 3;
                encryptedChars[i] = (char)asciiEquivalent;
            }

            foreach (var encryptedChar in encryptedChars)
            {
                Console.Write(encryptedChar);
            }
        }
    }
}
