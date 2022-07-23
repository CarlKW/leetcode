public class Solution
{
    static void Main(string[] args)
    {

        Console.WriteLine(RomanToInt("MCMXCIV"));
         
       
    }
    public static int RomanToInt(string s)
    {
        int sum = 0;
        char[] charArr = s.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            if (charArr[i] == 'I')
            {
                if (charArr.Length -1 != i  )
                {
                    if (charArr[i + 1] == 'V')
                    {
                         sum += 4;
                         i++;
                    }else if(charArr[i + 1] == 'X')
                    {
                        sum += 9;
                        i++;
                    }
                    else
                    {
                        sum++;
                    }
                }
                else
                {
                    sum++;
                }                
            }
            else if (charArr[i] == 'X')
            {
                if (charArr.Length -1 != i)
                {
                    if (charArr[i + 1] == 'L')
                    {
                        sum += 40;
                        i++;
                    }
                    else if (charArr[i + 1] == 'C')
                    {
                        sum += 90;
                        i++;
                    }
                    else
                    {
                        sum+=10;
                    }
                }
                else
                {
                    sum += 10;
                }
            }
            else if (charArr[i] == 'C')
            {
                if (charArr.Length-1f != i)
                {
                    if (charArr[i + 1] == 'D')
                    {
                        sum += 400;
                        i++;
                    }
                    else if (charArr[i + 1] == 'M')
                    {
                        sum += 900;
                        i++;
                    }
                    else
                    {
                        sum += 100;
                    }
                }
                else
                {
                    sum += 100;
                }
            }
            else if (charArr[i] == 'V')
            {
                sum += 5;
                
            }
           else if (charArr[i] == 'L')
            {
                sum += 50;
            }
           else if (charArr[i] == 'D')
            {
                sum += 500;
            }
           else if (charArr[i] == 'M')
            {
                sum += 1000;
            }


        }
        return sum;
    }
}