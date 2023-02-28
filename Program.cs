namespace PracticeForAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // file name
            string str = " 20230228.D ataFile1.001.xml ";

            //length of string
            int size = str.Length;

            //gets substring
            string size1 = str.Substring(1);
           
            //trim space from left and right.Not remove space in-between
            str = str.Trim();
            
            //split an split into an array using separator
            string[] strSplitArray = str.Split(".");

            //total num of element 
            int totalElementInArray = strSplitArray.Length;

            string str1 = " 20230228.D..ataFile1. 001.xml ";

            //don't Omit array contain empty string 
            string[] strSplitArrayWithOptions = str1.Split(".");

            //split with options RemoveEmptyEntries.Omit array contain empty string 
            string[] strSplitArrayWithOptions1 = str1.Split(".", StringSplitOptions.RemoveEmptyEntries);

            //trim white spaces if any
            string[] strSplitArrayWithOptions2 = str1.Split(".", StringSplitOptions.TrimEntries);
        }
    }
}