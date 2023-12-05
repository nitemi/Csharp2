using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    //Abstract class , they are incomplete, they are called special class.
    //they are like a mother class that every other class feeds from but can't feed from others
    //you can't instantiate them. they don't have main method
    //they can inherit from a class and multiple interface
    //they have modifies for method and properties
    //they can have fields,constructor, destructors
    //they are used as a base class. A class that othr class inherit from.
    abstract class WordsandMeaning : Party, IParty, IPartylist
    {

        int v = 66; //Fields
        public string Words { get; set; }//properties
        public string Meaning { get; set; }

        public void game() //method
        {

        }

        public  void gamelist()
        {
            Console.WriteLine("Abstract class");
        }

        public void gamestart()
        {
            Console.WriteLine("Welcome to abstract class");
        }
    }
    interface IParty
    {
        public  void gamestart();
        //{
        //    Console.WriteLine("Welcome to abstract class");
        //}
}
    interface IPartylist
    {
        public void gamelist();
        //{
        //    Console.WriteLine("Abstract class");
        //}
    }
}
