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

            #region Q3

            //Q3 : Explain the difference between a shallow copy and a deep copy. When would you use each one?
            //What is the risk of using a shallow copy when the object has reference-type fields?
            /*
             1-  Shallow Copy
            A shallow copy creates a new object, but it copies the values of the fields directly from the original object.

            When to use it:
           When the object contains only value types.
           When sharing referenced objects is acceptable.

            2. Deep Copy 
             A deep copy creates a completely independent copy of the object.

            When to use it:
          When the object contains reference-type fields.
          When you want the copied object to be fully independent from the original object.
             */



            #endregion

            #region Q4
            //Q4 : Look at the following code and determine the output. Explain why.
            /*
             Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");

            Dev - Testing

             Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");

            QA  -  Testing

             */
            #endregion

            #region Cinema_System

            Cinema cinema01 = new Cinema("City");
            Console.WriteLine("===========================  Open Cinema  ==================================");
            cinema01.Opencinem();

            StandardTicket ST01 = new StandardTicket("A15", "Zaky Chann", 200);

            VipTicket VT01 = new VipTicket(true, "Zaky Chann", 350);

            IMAXTicket IMAXT01 = new IMAXTicket("Harly", 400, true);

            cinema01.AddTicket(ST01);
            cinema01.AddTicket(VT01);
            cinema01.AddTicket(IMAXT01);


            Console.WriteLine("===========================  Print All Tickets ==================================");
            cinema01.PrintallTickets();

            Console.WriteLine("============================= Clone a VIP ticket =============================");
            VipTicket VT02 = VT01.clone();
            VT02._MovieName = "Askar FEL Moasker";
            VT01.print();
            VT02.print();

            Console.WriteLine("===========================  Canceld one Ticket ==================================");

            Console.WriteLine(ST01.Cansel());
            ST01.print();

            Console.WriteLine("===========================  Use the utility method to print an array of printable tickets. ========================");


            BookingHelper BH = new BookingHelper();
            Iprintable[] iprintable = new Iprintable[20];

            iprintable[0] = ST01;
            iprintable[1] = VT01;
            iprintable[2] = IMAXT01;

            BH.print(iprintable);

            Console.WriteLine("===========================  Close Cinema ==================================");
            cinema01.CloseCinema();


            #endregion
        }
    }
}
