using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Testing_Assignment_2.StringMethods
{
    public class StringMethods
    {
        public static string UpperLower(string id)
        {
            if (id != null && id!="")
            {
                if (id.All(char.IsUpper))
                {
                    id = id.ToLower();
                }
                else
                {
                    id = id.ToUpper();
                }
                return id;
            }
            return null;
           
        }

        
        public static  string TitleCase(string id)
        {
            if (id != null)
            {

                CultureInfo.CurrentCulture.TextInfo.ToTitleCase(id);

                return id;
            }
            return null;
            
        }

        
        public static  bool FindLower(string id)
        {
            if (id != null && id!="")
            {
                if (id.All(char.IsLower))
                {
                    return true;
                }
                return false;
            }
            return false;
            
        }

       
        public static  string FirstUpper(string id)
        {
            if (id != null && id != "")
            {
                id = id[0].ToString().ToUpper() + id.Substring(1);
                return id;
            }
            return null;
        }

        
        public static  bool FindUpper(string id)
        {
            if (id != null && id != "")
            {
                if (id.All(char.IsUpper))
                {
                    return true;
                }
                return false;
            }
            return false;
        }


       
        public static  bool FindNumber(string id)
        {
            if (id != null && id != "")
            {
                var isNumeric = int.TryParse(id, out _);
                if (isNumeric)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

       
        public static  string RemoveLast(string id)
        {
            if (id != null && id != "")
            {
                id = id.Substring(0, id.Length - 1);

                return id;
            }
            return null;
        }

        
        public static  int WordCount(string id)
        {
            if (id != null && id != "")
            {

                var match = Regex.Matches(id,
                    @"[^\s.?,]+", RegexOptions.IgnoreCase);

                return match.Count;
            }
            return 0;
        }

        
        public static  int? ConvertToInt(string id)
        {
            if (id != null && id != "")
            {
                var isNumeric = int.TryParse(id, out _);
                if (isNumeric)
                {
                    var c = Convert.ToInt32(id);

                    return c;
                }
                return null;
            }
            return null;
        }
    }
}