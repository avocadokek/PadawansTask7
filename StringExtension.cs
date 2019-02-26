using System;
using System.Text;

namespace PadawansTask7
{
    public class StringExtension
    {
        public static string OrderStringsByLength(string[] array)
        {

            for (int i = 1; i < array.Length; i++)
            {
               
               
                    int j = i - 1;

                    string temp = array[i];

                    while (j >= 0 && temp.Length < array[j].Length)
                    {
                        array[j + 1] = array[j];
                        j--;
                    }
                    array[j + 1] = temp;

                
            }

           if(array==null)
            {
                throw new ArgumentNullException();
            }
           if (array.GetType()!=typeof(string[]))
            {
                throw new ArgumentException();
            }

            return null;



            throw new NotImplementedException();
            
            throw new Exception();

        }
    }
}