using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Piece
    {
        public string ComposerName { get; set; }

        public string Key { get; set; }
    }
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);

                string pieceName = line[0];

                pieces.Add(pieceName, new Piece { ComposerName = line[1], Key = line[2] });
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Stop")
                {
                    break;
                }

                string[] parts = line
                    .Split('|', StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];
                string piece = parts[1];

                switch (command)
                {
                    case "Add":
                        string composer = parts[2];
                        string key = parts[3];
                        if (!pieces.ContainsKey(piece))
                        {
                            pieces.Add(piece, new Piece { ComposerName = composer, Key = key });
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        string newKey = parts[2];
                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece].Key = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }

            pieces = pieces.OrderBy(x => x.Key)
                .ThenBy(x => x.Value.ComposerName)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.ComposerName}, Key: {piece.Value.Key}");
            }
        }
    }
}
