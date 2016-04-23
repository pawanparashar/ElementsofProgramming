using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsofProgramming
{
    class _13
    {

        public void ShortestDistance()
        {
            //string[] str = new string[] { "sripts", "signed", "run", "only", "to", "policy", "the", "force", "can", "you", "metadata", "UNC", "the", "contain", "don't", "least", "at", "or", "Internet", "the", "from", "downloaded", "been", "not", "have", "that", "scripts", "own", "your", "on", "restrictions", "internal", "the", "up", "tighten", "to", "want", "you", "If" };

            string[] str = new string[] { "results","result","no","and","fun","no","work","no","for","makes","play","no","and","Work","All"        };

            Hashtable ht = new Hashtable();
            int shortest = int.MaxValue;
            for(int i=0;i<str.Length;i++)
            {
                if(ht.ContainsKey(str[i]))
                {

                    int temp = Convert.ToInt32(ht[str[i]]);
                    int distance = i - temp;
                    if(distance <shortest)
                    {
                        shortest = distance;
                    }
                    ht[str[i]] = i;

                }
                else
                {
                    ht.Add(str[i], i);

                }

            }



        }

        

        

    }
}
