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
                    Hint 1: Pentru 0 inlocuiti cu "A", s.a.m.d
                - Inversați ordinea caracterelor rămase în text.
                - Înlocuiți caracterele cu literele corespunzătoare, utilizând cheia Constants.Key.
                  Cheia este folosita in cadrul unui algoritm de criptare cu substitutie, alfabetul suportat fiind specificat in Constants.Alphabet.
                    Hint 2: Drept autor al tehnicii de criptare, este creditat imparatul roman Iulius Caesar (12 July 100 BC – 15 March 44 BC).
                    Hint 3: Fiecare litera din cheie reprezinta de fapt un deplasament (shift), in functie de indexul ei din alfabet
                - Afișați mesajul rezultat.
             */

            const string encryptedText = ">&%%S,^Kf*10zc3n5,4QQ1<6NRL^43^y91je62<L,OMP!l91PPWRwM;2S4Zy?*#XU!hS%;eKQf^^L%>MN3K";

            // TODO: implement decryption

            Console.WriteLine("Decrypted text=????");
        }
    }
}