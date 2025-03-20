namespace Aneta_s_Word_Counting_Console
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Twoje słowo to:");
            string s =  Console.ReadLine();
                
                
            //Console.WriteLine("The number of letters in your word(s) is:" + s.Length) ;
            Console.WriteLine($"The number of letters in your word(s) is: {s.Length}");



            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(charArray);

            string result = s.ToUpper();
            Console.WriteLine($"Original String : {s}"); //=>  Console.WriteLine("Original String :" + " " + s)
            Console.WriteLine(result);



            for (int i = 0; i < charArray.Length; i++) 
            {
                Console.WriteLine(charArray[i]);
            }


        }
        
       
        
    }
}