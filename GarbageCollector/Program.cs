using System.Dynamic;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
            new Sample(i);
        Console.WriteLine("***************"); /* used to seperate constructors’ and destructors’  outputs*/
        GC.Collect();
        var a = new Test();
        a.runner = "Testo";
        Console.WriteLine(a.Runner);
        Console.Read();
    }

    class Sample
    {
        int number;
        public Sample(int x)
        {
            this.number = x;
            Console.WriteLine($"{number} object produced.");
        }
        ~Sample()
        {
            Console.WriteLine(number + " object is being deleted.");
        }
    }

    public class Test : Test2
    {
        public Test4 GetKisi()
        {
            List<Test4> testList = new List<Test4> { 
                new Test4() {Name = "Ali",Surname="KELEŞ" },
            
            };
        }
        public string runner;
        public Test()
        {
            Run();
        }

        public override string Runner { get { return runner; } set { value = runner; } }

        public override void Stop()
        {
            Console.WriteLine("Run");
        }

        public void PrintRunner()
        {
            Console.WriteLine(Runner);
            runner = "Ali";
        }
    }

    public interface Test3
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public abstract class Test2
    {
        public void Run()
        {
            Console.WriteLine("Run");
        }

        public abstract void Stop();
        public virtual void Walk()
        {
            int[] a = new int[] { 1, 2, 3, 4 };

            Console.WriteLine("Walk");
        }
        public abstract string Runner { get; set; }


    }

    public class Test4
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}