using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{

      

        class checkDuplicateUsingShiftOperator
    {
            public void check_duplicate()
            {
                string s = "finding";
                int H = 0;
                int X = 0;

                for(int i = 0; i < s.Length; i++)
                {
                    X = 1;
                    X = X << s[i] - 97;
                    if((X & H) > 0)
                    {
                        Console.Write("Duplicate{0}", s[i]);

                    }
                    else
                    {
                        H = X | H;
                    }
                }
            }
        }

    
}
