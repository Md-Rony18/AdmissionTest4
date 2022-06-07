using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {
        public  int Count(string text)
        {
            int a = 0;
            int b = 1;
            int state = a;
            int cnt=0;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == ' ' || text[i]=='\n' || text[i] == '\t')
                {
                    state = a;
                }
                else if (state == a)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
