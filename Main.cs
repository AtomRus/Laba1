namespace LAba1 
{
public class Program
    {
        static void Main(string[] args)
        {
            int[] af = new int[]{3,5,6,8};
            Console.WriteLine(af.Where(p => (p % 3 != 0) & (p % 2 == 1)).Aggregate((x,y) => x * y));
        }
    }
}