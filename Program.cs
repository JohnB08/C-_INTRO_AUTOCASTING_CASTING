namespace C__INTRO_AUTOCASTING_CASTING;

class Program
{
    static void Main(string[] args)
    {
        string myString = "Hello";
        int myWholeNumber = 10;
        double myDouble = 15.999999999;
        char myChar = 'a';


        //Implicit casting.
        var result = myString + myWholeNumber;
        Console.WriteLine(result.GetType());
        var numberResult = myWholeNumber + myDouble;
        Console.WriteLine(numberResult.GetType());
        var charResult = myChar + myChar;
        Console.WriteLine(charResult);
        var addingCharToInt = myChar + myWholeNumber;
        Console.WriteLine(addingCharToInt.GetType());
        var addingCharToString = myChar + myString;
        Console.WriteLine(addingCharToString.GetType());
        //Hvis datamaskinen må gjøre operasjoner på to forskjellige datatyper. 
        //Gjør den, som en tommelfinger regel, den mindre komplisrte typen, om til den mest kompliserte.
        //Slik at den kan gjøre operasjoner på begge uten å miste data. 

        int mySecondWholeNumber = 13;
        var divisionResult = myWholeNumber / (double)mySecondWholeNumber; //Her explicit caster vi (aka forteller datamaskinen at) mySecondWholeNumber
        //Skal behandles som om den er av datatypen double.
        Console.WriteLine(divisionResult); //Det gjør at resultatet av operasjonen også blir behandlet som en double. 

        var addNumberResult = myWholeNumber + (int)myDouble; //Når vi caster en double til en int, sier vi til datamaskinen at det er helt greit å miste data om desimaltall.
        //aka, den ignorerer alle desimaltall utenom i ekstreme tilfeller hvor tallet er EKSTREMT nært neste hele tall.
        Console.WriteLine(addNumberResult);

        char mySecondChar = 'b';
        var divisionWithChar = myChar / (double)mySecondChar; //På samme måte med ints, kan vi og caste chars til doubles for å hente ut desimaltall
        //etter en divisjon.
        Console.WriteLine(divisionWithChar);

        var myWeirdChar = (char)myWholeNumber;
        Console.WriteLine(myWeirdChar);

        var mySecondWeirdChar = (char)mySecondWholeNumber;
        Console.WriteLine(mySecondWeirdChar);

        int thisHasToBeACharacter = 87;
        var pleaseMakeThisWork = (char)thisHasToBeACharacter;
        Console.WriteLine(pleaseMakeThisWork);

        int largeNumber = (int)Math.Pow(2, 18);
        Console.WriteLine(largeNumber);
        var characterWithLoss = (char)largeNumber;
        Console.WriteLine(characterWithLoss);
        Console.WriteLine((int)characterWithLoss);
    }
}
