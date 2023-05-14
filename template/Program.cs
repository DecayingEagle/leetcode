using System.IO;
namespace Template {
    public class TestCase {
    public TestCase()
    {
        int Id = -1;
        String[] input;
        String[] output;
    }

    public int Id { get; set; }
    public String[] input { get; set; }
    public String[] output { get; set; }
}
public class Program
{
    public static void Main() {
        string fileName = "testcases";
        string jsonString = File.ReadAllText(fileName);
        
    }
}
}


