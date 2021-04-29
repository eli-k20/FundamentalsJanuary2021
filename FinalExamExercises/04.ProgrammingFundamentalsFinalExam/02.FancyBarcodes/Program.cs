using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex pattern = new Regex(@"(@#+)(?<code>[A-Z][A-Za-z0-9]{4,}[A-Z])(@#+)");

            for (int i = 0; i < n; i++)
            {
                string currentBarcode = Console.ReadLine();

                Match barcodeMatch = pattern.Match(currentBarcode);

                if (barcodeMatch.Success)
                {
                    string barcode = barcodeMatch.Groups["code"].Value;
                    StringBuilder productGroup = new StringBuilder();

                    Regex digitRegex = new Regex(@"\d");

                    MatchCollection digits = digitRegex.Matches(barcode);

                    if (digits.Count == 0)
                    {
                        productGroup.Append("00");
                    }
                    else
                    {
                        foreach (Match match in digits)
                        {
                            productGroup.Append(match.ToString());
                        }
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
