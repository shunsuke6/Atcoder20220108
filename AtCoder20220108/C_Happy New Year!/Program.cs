using System;

namespace Atcoder0108_B
{
    class Program
    {
        static void Main(){
            long N = Int64.Parse(Console.ReadLine());
            string strBin = Convert.ToString(N,2);
            
            string result = strBin.Replace('1','2');

                
            Console.WriteLine(result);
        }
        static string checkStr(string str){
            if(str[str.Length-1] == '2') return  addStr(str);
            else return replaceStr(str);
            
        }
        static string addStr(string str){
            return str + "0";
        }
        static string replaceStr(string str){
            return str.Substring(0,str.Length-1) + "2";
        }
        
    }
}
