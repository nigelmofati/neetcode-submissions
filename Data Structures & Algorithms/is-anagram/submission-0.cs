public class Solution {
    public bool IsAnagram(string s, string t) {
        //my plan is to check if the two strings are equal in length first then secondly check if each letter appears the same number of times 
        if (s.Length != t.Length )
            return false;
       
       int uniqueChars1 =0;
       int uniqueChars2 =0;
            for (int i=0; i<s.Length ; i++)
            {
                HashSet<char> unique1 = new HashSet<char>();
                HashSet<char> unique2 = new HashSet<char>();
                unique1.Add(s[i]);
                unique2.Add(t[i]);
                uniqueChars1 = unique1.Count();
                uniqueChars2 = unique2.Count();
            }
        
        if (uniqueChars1 != uniqueChars2)
        return false;

            
            List<char> String1 = new List<char> ();
            List<char> String2 = new List<char> ();
            for (int i=0; i<s.Length ; i++)
            {
                String1.Add(s[i]);
                String2.Add(t[i]);
            }
            String1.Sort();
            String2.Sort();

            for (int i=0; i< String1.Count();i++)
            {
                if (String1[i] != String2[i])
                return false;
            }

            
            //how many times does each unique char instance appear in either 


    return true;
    }
}
