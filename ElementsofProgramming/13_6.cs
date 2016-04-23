using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsofProgramming
{
    class _13_6
    {

        public string MFQ()
        {
            try
            {
                string str = "This is a sample sentences,This is a sample sentences,This is a sample sentences,This is a sample sentences,This is a sample sentences,This is a sampl sentences,This is a sample sentenc,";
                string[] Query = str.Split(',');

                SortedDictionary<string, int> ht = new SortedDictionary<string, int>();

                foreach (string temp in Query)
                {
                    if (ht.ContainsKey(temp))
                    {
                        int value = (int)ht[temp];
                        value++;
                        ht[temp] = value;
                    }
                    else
                    {
                        ht.Add(temp, 1);

                    }


                }
                var max = ht.OrderByDescending(d => d.Value).First();
                var key = max.Key;
                return key;
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }

        }
    }
}
