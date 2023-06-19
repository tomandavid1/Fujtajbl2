namespace Fujtajbl2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Životní cyklus programu
            while (true)
            {

                // Logika zpracování prvního vstupu společně s validací
                Console.Write("Zadejte první číslo \"a\": ");
                string vstupA  = Console.ReadLine().Trim();
                if (!double.TryParse(vstupA, out double a) || string.IsNullOrEmpty(vstupA)) {
                    TextNeplatnyVstup();
                    continue;
                }
                // Logika zpracování druhého vstupu společně s validací
                Console.Write("Zadejte druhé číslo \"b\": ");
                string vstupB = Console.ReadLine().Trim();
                if (!double.TryParse(vstupB, out double b) || string.IsNullOrEmpty(vstupB))
                {
                    TextNeplatnyVstup();
                    continue;
                }

                // Výpis výběru operace
                TextVyberOperace();

                // Výběr operace
                string operaceVyber = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();
                if (!int.TryParse(operaceVyber, out int operace) || string.IsNullOrEmpty(operaceVyber))
                {
                    Console.WriteLine("Neplatný výběr operace! Zkuste to prosím znovu");
                    continue;
                }

                // Inicializace rozhraní IOperace

                IOperace strategie;

                // Switch pro výběr operace
                switch (operace)
                {
                    case 1:
                        strategie = new ScitaniOperace();
                        break;
                    case 2:
                        strategie = new OdcitaniOperace();
                        break;
                    case 3:
                        strategie = new DeleniOperace();
                        break;
                    case 4:
                        strategie = new NasobeniOperace();
                        break;
                    default:
                        Console.WriteLine("Neznámá operace! Zkuste to prosím znovu");
                        Thread.Sleep(2000);
                        Console.Clear();
                        continue;
                }

                // Výpočet výsledku
                strategie.VypocetOperace(a, b);

                // Dotaz na spuštění dalšího životního cyklu aplikace
                Console.WriteLine("Chcete spustit další výpočet? (ano/ne)");
                string continueInput = Console.ReadLine().ToLower();
                if (continueInput != "ano")
                    break;
                Console.Clear();

            }


            // Metoda pro výpis neplatného vstupu
            void TextNeplatnyVstup()
            {
                Console.WriteLine("Byl zadán neplatný vstup! Zkuste to prosím znovu");
            }

            // Metoda pro výpis výběru operací
            void TextVyberOperace()
            {
                Console.WriteLine("Vyberte požadovanou operaci:");
                Console.WriteLine("1: Sčítání   (a + b)");
                Console.WriteLine("2: Odčítání  (a - b)");
                Console.WriteLine("3: Dělení    (a / b)");
                Console.WriteLine("4: Násobení  (a * b)");
            }
        }
    }
}