namespace Assignment_05_OOP_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //  Q1 : What is an interface in C#? Why do we use interfaces instead of depending on concrete classes directly?
            //  Mention at least three benefits of using interfaces.

            /*
             An interface in C# is a reference type that defines a contract.
             It contains method signatures, properties, events, or indexers without implementation.
             Any class that implements the interface must provide the implementation for all its members.


            We use interfaces instead of depending directly on concrete classes
            to achieve loose coupling and make the code more flexible and maintainable.
             */
            #endregion

            #region Q2
            //Q2: Look at the following code and answer the questions below:


            //a) What is the problem with this design? Both interfaces have a method called Greet() —
            //how does the class handle it currently?

            /*
             The problem is that both interfaces contain a method with the same name Greet().
            This means that both IEnglishSpeaker and IArabicSpeaker will use the same method implementation
             */

            // b) How would you fix this so IEnglishSpeaker.Greet() says "Hello" and IArabicSpeaker.Greet() says "Ahlan" ?
            //What is this technique called?
            /*
             must makw
            public void IEnglishSpeaker.Greet()
            {

            } ;
            public void IArabicSpeaker.Greet()
            {

            } ;
            
             */

            //c) After applying your fix, can you call Greet() directly on a Translator object (e.g. translator.Greet())?
            //Why or why not? How do you call each version?

            /*
             NO,I can't call Greet() directly .

            ((IEnglishSpeaker)Translator).Greet() ;

            ((IArabicSpeaker)Translator).Greet() ;
             */


            #endregion
        }
    }
}
