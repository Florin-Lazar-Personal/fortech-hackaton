namespace DecryptTheMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Pași de Decodificare:
                - Eliminați caracterele "^" și "~" din text.
                - Înlocuiți caracterele "{", "}", "(", ")" cu spații.
                - Înlocuiți cifrele cu literele corespunzătoare.
                - Inversați ordinea caracterelor rămase în text.
                - Înlocuiți caracterele cu literele corespunzătoare, utilizând cheia Constants.Key.
                  Cheia este folosita in cadrul unui algoritm de criptare cu substitutie, alfabetul suportat fiind specificat in Constants.Alphabet.
                - Afișați mesajul rezultat.
             */

            const string encryptedText = ">&%%S,^Kf*10zc3n5,4QQ1<6NRL^43^y91je62<L,OMP!l91PPWRwM;2S4Zy?*#XU!hS%;eKQf^^L%>MN3K";

            // TODO: implement decryption

            Console.WriteLine("Decrypted text=????");
        }
    }
}