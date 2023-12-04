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
        //Party party1 = new Party() { Id = 1, Price = 100000, Name = "Birthday Celebration", Description = "Ade's birthday celebration" };
        //Party party2 = new Party() { Id = 2, Price = 200000, Name = "Naming Ceremony", Description = "Mr & Mrs Adeyi naming celebration" };
        //Party party3 = new Party() { Id = 3, Price = 450000, Name = "Corporate Event ", Description = "Walure Mananagement Event" };
        //Party party4 = new Party() { Id = 4, Price = 250000, Name = "House Warming", Description = "Blessed House Opening", };
        //Party party5 = new Party() { Id = 5, Price = 150000, Name = "Graduation", Description = "Adebisi's Graduation", };

        //Dictionary<int, Party> parties = new Dictionary<int, Party>();
        //parties.Add(party1.Price, party1);
        //parties.Add(party2.Price, party2);
        //parties.Add(party3.Price, party3);
        //parties.Add(party4.Price, party4);
        //parties.Add(party5.Price, party5);

        //foreach (KeyValuePair<int, Party> pair in parties)z
        //{
        //    Console.WriteLine("Key" + pair.Key);
        //    //var party = pair.Value;
        //    //Console.WriteLine("Id = {0}, Name = {1}, Description = {2}, Price = {3}", party.Id, party.Name, party.Description, party.Price);
        //}

        WordsandMeaning words1 = new WordsandMeaning() { Words = "Noun", Meaning = "a naming word. E.g Abuja,Cat, Tade,Freedom" };
        WordsandMeaning words2 = new WordsandMeaning() { Words = "Verb", Meaning = "an action words.E.g eat, finish, drink, believes,dance" };
        WordsandMeaning words3 = new WordsandMeaning() { Words = "Pronoun", Meaning = "words use instead of a noun. E.g She, He, Himself, Herself, It, We" };
        WordsandMeaning words4 = new WordsandMeaning() { Words = "Adverb", Meaning = "a word that modifies a verb, adjectives or other adverbs.E.g softly,lazily, only, often, sometimes" };
        WordsandMeaning words5 = new WordsandMeaning() { Words = "Conjunction", Meaning = "a  word that joins other words or phrases together into sentences.E.g and,or,nor,neither" };
        WordsandMeaning words6 = new WordsandMeaning() { Words = "Preposition", Meaning = "shows the relationship between noun and pronoun and the other words in a sentence. E.g by, against, for, apart,out of" };
        WordsandMeaning words7 = new WordsandMeaning() { Words = "Adjectives", Meaning = "describes noun or pronoun , e.g hot,lazy,beautiful" };
        WordsandMeaning words8 = new WordsandMeaning() { Words = "Interjection", Meaning = "are expressions that can stand on thier own or be contained within a sentence.E.g ah!, ouch!, whoops!" };

        Dictionary<string, string> words = new Dictionary<string, string>();
        words.Add(words1.Words, words1.Meaning);
        words.Add(words2.Words, words2.Meaning);
        words.Add(words3.Words, words3.Meaning);
        words.Add(words4.Words, words4.Meaning);
        words.Add(words5.Words, words5.Meaning);
        words.Add(words6.Words, words6.Meaning);
        words.Add(words7.Words, words7.Meaning);
        words.Add(words8.Words, words8.Meaning);

        foreach (KeyValuePair<string, string> pair in words)
        {
            Console.WriteLine("Key" + pair.Key);
            var wordread = pair.Value;
            Console.WriteLine(wordread);

        }

    }
}
