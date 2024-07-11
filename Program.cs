namespace GeIIS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entter a string");
            string s = Console.ReadLine();

            Rev rev = new Rev();
            rev.Occurennce(s);
            // Console.ReadLine();
        }

    }
    public class Rev
    {
        public string Occurennce(string input)
        {
            //string rev = string.Empty;


            while (input.Length > 0)
            {
                Console.Write(input[0] + ":");
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[0] == input[i])
                    {
                        count++;
                    }

                }
                Console.WriteLine(count);
                input = input.Replace(input[0].ToString(), string.Empty);
            }
            

           
            return input;
        }
    }
}
