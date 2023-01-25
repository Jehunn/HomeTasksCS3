using System;

namespace HomeTaskCS3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsDigit("Salam"));



            Console.WriteLine(IsFullname("HuseynAbbasov"));



            int[] numbers = { 3, 8, 12, 3, 9, 23 };
            var result = MakeUniqueArr(numbers);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            

            string[] emails = { "xalid@edu.az", "ceyhun@code.az", "elvin@mail.az", "vusal@inbox.az" };
            var result1 = MailsDomain(emails);
            for (int i = 0; i < result1.Length; i++)
            {
                Console.WriteLine(result1[i]);
            }


            string name = "huSEyn";
            Capitalise(ref name);
            Console.WriteLine(name);

            string mail = "huseyn@edu.az";
            Console.WriteLine(GetDom(mail));

        }

        static bool IsName(string name)
        {
            if (!char.IsUpper(name[0]))
            {
                return false;
            }
            for (int i=1;i<name.Length;i++)
            {
                if (!char.IsLower(name[i]))
                {
                    return false;
                }
            }
            return true;
        }



        #region Task 1
        static bool IsDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion


        #region Task 2
        static bool IsFullname(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
                if (count < 2)
                {
                    var words = str.Split(' ');
                    if (IsName(words[0]) && IsName(words[1]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion


        #region Task 3
        static int[] MakeUniqueArr(int[] arr)
        {
            int[] newArr = new int[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }
            return newArr;
        }
        #endregion


        #region Task 4
        static string[] MailsDomain(string[] emails)
        {
            for (int i = 0;i <emails.Length;i++)
            {
                emails[i] = emails[i].Substring(emails[i].IndexOf('@') + 1);
            }
            var result = new string[0];
            for (int i=0;i<emails.Length;i++)
            {
                if (Array.IndexOf(result, emails[i]) == -1)
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = emails[i];
                }
            }
            return result;






        }
        #endregion

        ///////////////////////////////////////////////

        //static string GetDomain(string email)
        //{
        //    //hiko@gmail.com
        //    var atIndex = email.IndexOf('@');
        //    var domain = email.Substring(email.IndexOf('@') + 1);

        //    return domain;
        //}




        static string GetDom(string mail)
        {
            var atIndex=mail.IndexOf("@");
            var domain=mail.Substring(mail.IndexOf('@') +1);
            return domain;
        }

        static string[] MakeUniqueArr(string[] arr)
        {
            string[] newArr = new string[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.IndexOf(newArr, arr[i]) == -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = arr[i];
                }
            }

            return newArr;
        }

        static string[] MakeNames(string[] arr)
        {
            string[] names = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                var fullname = arr[i].TrimStart();
                var name = arr[i].TrimStart().Substring(0, fullname.IndexOf(' '));
                names[i] = name;
            }

            return names;
        }


        static void Capitalise(ref string name)
        {
            name= char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

    }
}
