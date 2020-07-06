using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EnumApp
{
    class Program
    {
        //코드 조각을 많이 사용할수록 코딩양이 줄어든다.
        enum DialogResult
        {
            YES = 10, 
            NO = 20, 
            CANCEL = 30, 
            CONFIRM = 40,
            OK
        }
        static void Main(string[] args)
        {
            //WriteLine(DialogResult.OK);
            //WriteLine((int)DialogResult.OK); //OK는 문자열이 아님

            /*
             WriteLine(DialogResult.CONFIRM);
             WriteLine(DialogResult.CANCEL);
             WriteLine(DialogResult.NO);
             WriteLine(DialogResult.YES);
            */
            DialogResult result = DialogResult.YES;
            WriteLine(result == DialogResult.YES);

            
        }
    }
}
