namespace LAba1 
{
public class Program
    {
        static void Main(string[] args)
        {
            int[] af = new int[]{3,6,5,8};
            af = af.OrderBy(p => p).ToArray();
            foreach(int f in af)
            {
                Console.WriteLine(f);
            }
        }
    }
}