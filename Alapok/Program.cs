internal class Program
{
    private static void Main(string[] args)
    {
        //Ez egy egy soros komment.
        /*Ez egy több 
         soros komment*/
        Console.WriteLine("Hello, World!");
        Console.WriteLine(3 + 3);
 
        //VÁLTOZÓK -----------------------------------------------------
        int i = 123; //minden egész számot az ˇintˇ változóban tárolunk, ez lehet negatív és pozitív is
        double d = 19.99D; //szintén szám, de tizedesjegysekkel együtt tárolja
        char a = 'a'; //egyedi karaktert tárol egyedül
        string szoveg = "Ez egy karakterlánc."; //egy karakterláncot tárol
        bool b = false; //összesen kettő értéket tud tárolni, vagy "true" vagy "false"

        //MANUÁLIS CASTING ---------------------------------------------
        double myDouble = 9.78;
        int myInt = (int)myDouble; //Manuálisan, nekünk kell átalakítani a számot 

        //AUTOMATIKUS CASTING ------------------------------------------
        int myInt2 = 9;
        double myDouble2 = myInt2;

        //ARITMETIKAI MŰVELETEK ----------------------------------------
            /* 
               "+" összeadás
               "-" kivonás
               "*" szorzás
               "/" osztás
               "%" Az osztás maradékát adja vissza
               "++" Változó értékét 1-gyel növeli
               "--" Változó értékét 1-gyel csökkenti
            */

        //PÉLDÁK -------------------------------------------------------
        string firstName = "Jhon";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;
        int age = 35;
        Console.WriteLine($"Szia {fullName}! A te életkorod {age}.");

        int x = 165;
        x = 100; //új értéket adhatunk egy változónak azonban ez felülírja az előző értéket
        const int y = 75; //ennek az értékét a "const" kulcsszó miatt nem változazható csak olvasató
        Console.WriteLine($"Értékek:\n\tx:{x}\n\ty:{y}\n\tx+y={x+y}");

        int q, r, s;
        q = r = s = 50; //mindegyik változó értéke 50 lesz
    }
}