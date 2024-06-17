using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 3, 4, 2, 5, 63, 3, 90 };


            Console.Write(returnsecondlargest(arr));


        }

        static public string test(string s)
        {
            Char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }

            return new string(chars);

        }
        static public bool palindrome(string s)
        {
            Char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (chars[left] != chars[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;

        }

        static public bool dublicate(int[] temp)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (set.Contains(temp[i]))
                {
                    return true;
                }
                set.Add(temp[i]);
            }
            return false;
        }
        static public int[] remove(int[] arr)
        {
            HashSet<int> ints1 = new HashSet<int>(arr);

            List<int> list = new List<int>(ints1);

            int[] tem = new int[ints1.Count];
            ints1.CopyTo(tem);
            return list.ToArray();
        }

       
        
        
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int j = 0;
            //112
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[j])
                {
                    j++;
                    nums[j] = nums[i];

                }


            }
            return j + 1;     
            }

        public static int returnsecondlargest(int[] ints)
        {
            int firstlargest = int.MinValue;
            int secondlargest = int.MinValue;
            for(int i=0;i<ints.Length; i++)
            {
                if (firstlargest < ints[i])
                {
                    secondlargest = firstlargest;
                    firstlargest = ints[i];
                }
                else if (firstlargest > ints[i]&& secondlargest < ints[i])
                {
                    secondlargest = ints[i];
                }
            }
            return secondlargest;
        }

        }
    }
