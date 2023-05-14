using System;
using System.IO;

namespace AllRunner {

    public class Runner {
        public int leetcodeNum = -1;
        public static int Main(string[] args) {
            
            if(args.Length == 0){
                System.Console.WriteLine("LeetCode number:").NewLine();
                leetcodeNum = System.Console.ReadLine().ToInt;
            } else {
                leetcodeNum = args[0].TrimStart.ToInt;
            }
            
            
            return 0;
        }
    }

    public 
    public TestCase TestCaseReader (String fileName) {
        
    }
}