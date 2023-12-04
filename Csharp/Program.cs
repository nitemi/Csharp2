using Csharp;
using System.Diagnostics;

public class Program
{
    //Icollection
    //dictionary
    //list, stack, queue and set
    private static void Main(string[] args)
    {
        //Dictionary is mostly used for querying database, it contains key and value
        Party party1 = new Party() { Id = 1, Price = 100000, Name = "Birthday Celebration", Description = "Ade's birthday celebration" };
        Party party2 = new Party() { Id = 2, Price = 200000, Name = "Naming Ceremony", Description = "Mr & Mrs Adeyi naming celebration" };
        Party party3 = new Party() { Id = 3, Price = 450000, Name = "Corporate Event ", Description = "Walure Mananagement Event" };
        Party party4 = new Party() { Id = 4, Price = 250000, Name = "House Warming", Description = "Blessed House Opening", };
        Party party5 = new Party() { Id = 5, Price = 150000, Name = "Graduation", Description = "Adebisi's Graduation", };

        //stack : lastinFirstout
        Stack<Party> stack = new Stack<Party>();
        stack.Push(party1);
        stack.Push(party2);
        stack.Push(party3);
        stack.Push(party4);
        stack.Push(party5);

        var a1 = stack.Pop();
        Console.WriteLine(a1.Name + "   " + a1.Price);
        Console.WriteLine("Items left in the stack");

        var a2 = stack.Pop();
        Console.WriteLine(a2.Name + "   " + a2.Price);
        Console.WriteLine("Items left in the stack");

        var a3 = stack.Pop();
        Console.WriteLine(a3.Name + "   " + a3.Price);
        Console.WriteLine("Items left in the stack");

        var a4 = stack.Pop();
        Console.WriteLine(a4.Name + "   " + a4.Price);
        Console.WriteLine("Items left in the stack");

        var a5 = stack.Pop();
        Console.WriteLine(a5.Name + "   " + a5.Price);
        Console.WriteLine("Items left in the stack");






        WordsandMeaning words1 = new WordsandMeaning() { Words = "Noun", Meaning = "a naming word. E.g Abuja,Cat, Tade,Freedom" };
        WordsandMeaning words2 = new WordsandMeaning() { Words = "Verb", Meaning = "an action words.E.g eat, finish, drink, believes,dance" };
        WordsandMeaning words3 = new WordsandMeaning() { Words = "Pronoun", Meaning = "words use instead of a noun. E.g She, He, Himself, Herself, It, We" };
        WordsandMeaning words4 = new WordsandMeaning() { Words = "Adverb", Meaning = "a word that modifies a verb, adjectives or other adverbs.E.g softly,lazily, only, often, sometimes" };
        WordsandMeaning words5 = new WordsandMeaning() { Words = "Conjunction", Meaning = "a  word that joins other words or phrases together into sentences.E.g and,or,nor,neither" };
        WordsandMeaning words6 = new WordsandMeaning() { Words = "Preposition", Meaning = "shows the relationship between noun and pronoun and the other words in a sentence. E.g by, against, for, apart,out of" };
        WordsandMeaning words7 = new WordsandMeaning() { Words = "Adjectives", Meaning = "describes noun or pronoun , e.g hot,lazy,beautiful" };
        WordsandMeaning words8 = new WordsandMeaning() { Words = "Interjection", Meaning = "are expressions that can stand on thier own or be contained within a sentence.E.g ah!, ouch!, whoops!" };

        Stack<WordsandMeaning> words = new Stack<WordsandMeaning>();
        words.Push(words1);
        words.Push(words2);
        words.Push(words3);
        words.Push(words4);
        words.Push(words5);
        words.Push(words6);
        words.Push(words7);
        words.Push(words8);

        var b1 = words.Pop();
        Console.WriteLine(b1.Words + "   " + b1.Meaning);
        Console.WriteLine("Items left in the stack");

        var b2 = words.Pop();
        Console.WriteLine(b2.Words + "   " + b2.Meaning);
        Console.WriteLine("Items left in the stack");

        var b3 = words.Pop();
        Console.WriteLine(b3.Words + "   " + b3.Meaning);
        Console.WriteLine("Items left in the stack");

        var b4 = words.Pop();
        Console.WriteLine(b4.Words + "   " + b4.Meaning);
        Console.WriteLine("Items left in the stack");

        var b5 = words.Pop();
        Console.WriteLine(b5.Words + "   " + b5.Meaning);
        Console.WriteLine("Items left in the stack");

        var b6 = words.Pop();
        Console.WriteLine(b6.Words + "   " + b6.Meaning);
        Console.WriteLine("Items left in the stack");

        var b7 = words.Pop();
        Console.WriteLine(b7.Words + "   " + b7.Meaning);
        Console.WriteLine("Items left in the stack");

        var b8 = words.Pop();
        Console.WriteLine(b8.Words + "   " + b8.Meaning);
        Console.WriteLine("Items left in the stack");


    }

    }
}
