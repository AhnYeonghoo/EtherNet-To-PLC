using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace LinqFaroShuffle
{

     
    public static class Extensions
    {

        public static IEnumerable<T> LogQuery<T>
            (this IEnumerable<T> sequence, string tag)
        {
            using (var writer = File.AppendText("debug.log"))
            {
                writer.WriteLine($"Executing Query {tag}");
            }
            return sequence;
        }

        public static IEnumerable<T> InterLeaveSequenceWith<T>(this IEnumerable<T> firsth,
            IEnumerable<T> second)
        {
            var firsthIter = firsth.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firsthIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firsthIter.Current;
                yield return secondIter.Current;
            }
        }

        public static void MainQuery()
        {
            static IEnumerable<string> Suits()
            {
                yield return "clubs";
                yield return "diamonds";
                yield return "hearts";
                yield return "spades";
            }

            static IEnumerable<string> Ranks()
            {
                yield return "two";
                yield return "three";
                yield return "four";
                yield return "five";
                yield return "six";
                yield return "seven";
                yield return "eight";
                yield return "nine";
                yield return "ten";
                yield return "jack";
                yield return "queen";
                yield return "king";
                yield return "aec";
            }

            var startingDeck = from s in Suits()
                               from r in Ranks()
                               select new { Suit = s, Rank = r };

            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterLeaveSequenceWith(bottom);

            foreach (var card in startingDeck)
            {
                Console.WriteLine(card);
            }

            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }

            var startingDeck2 = (from s in Suits().LogQuery("Suit Generation")
                                 from r in Ranks().LogQuery("Rank Generation")
                                 select new { Suit = s, Rank = r }).LogQuery("Starting Deck");

            foreach (var c in startingDeck2)
                Console.WriteLine(c);

            Console.WriteLine();

            var times = 0;
            var shuffle2 = startingDeck2;

            do
            {
                shuffle2 = shuffle2.Skip(26).LogQuery("Bottom Half")
                    .InterLeaveSequenceWith(shuffle2.Take(26).LogQuery("Top Half"))
                    .LogQuery("Shuffle");

                foreach (var c in shuffle2)
                {
                    Console.WriteLine(c);
                }
                times++;
                Console.WriteLine(times);
            } while (!startingDeck2.SequenceEqual(shuffle2));
            Console.WriteLine(times);

        }
    }
}