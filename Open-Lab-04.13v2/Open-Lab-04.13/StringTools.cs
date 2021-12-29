using System;
using System.Linq;
namespace Open_Lab_04._13
{
    public class StringTools
    {
        public string GetLongestCommonSequence(string str1, string str2)
        {
            bool doit;
            int i = 1;
            int pos1 = 0;
            int pos2 = 0;
            string lon = "";
            string longest = "";
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            foreach (char c1 in ch1)
            {
                foreach (char c2 in ch2)
                {
                    if (c1 == c2)
                    {
                        i = 1;
                        lon = c1.ToString();
                        if (str1.Length > pos1 + 1)
                        {
                            if (str2.Length > pos2 + 1)
                            {


                                if (ch1[pos1 + 1] == ch2[pos2 + 1])
                                {
                                    do
                                    {
                                        lon += ch1[pos1 + i];
                                        i++;
                                        doit = true;
                                        if (pos1 + i > str1.Length - 1)
                                        {
                                            doit = false;
                                        }
                                        else
                                        {
                                            if (pos2 + i > str2.Length - 1)
                                            {
                                                doit = false;
                                            }
                                            else
                                            {
                                                doit = ch1[pos1 + i] == ch2[pos2 + i];
                                            }

                                        }
                                    } while (doit);


                                }




                            }
                        }

                    }

                    if (lon.Length > longest.Length)
                    {
                        longest = "";
                        longest = lon;
                        lon = "";
                    }
                    pos2++;
                }
                pos2 = 0;
                pos1++;
            }

            return longest;

        }
    }
}
