class Practical1
{

}

class Practical2
{
    public int sock_pairs(string socks)
    {
        // identify unique socks -> // find no. of unique socks // -> pair them and inc. count
        int cnt = 0;
        Dictionary<char, int> unique = new Dictionary<char, int>();
        foreach (char c in socks)
        {
            if (unique.ContainsKey(c))
            {
                unique[c] += 1;
            }
            else
            {
                unique.Add(c, 1);
            }
        }

        foreach (var item in unique)
        {
            cnt += item.Value / 2; // covers all cases ig
        }
        return cnt;
    }

    // task -> if any anagram of sub in super : true
    public bool anagramPresent(string sub, string super)
    {
        // store all cyclic permutations of sub + reverse(sub):if found in super : return true
        List<string> perms = new List<string>();
        for (int i = 0; i < sub.Length; i++)
        {
            string perm = sub.Substring(i) + sub.Substring(0, i);
            perms.Add(perm);
            perms.Add(reverse(perm));
        }
        foreach (var item in perms)
        {
            // returns -1 if not found
            if (super.IndexOf(item) >= 0 && super.IndexOf(item) < super.Length)
            {
                return true;
            }
        }
        return false;
    }

    // utility func to reverse
    public string reverse(string str)
    {
        string ans = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            ans += str[i];
        }
        return ans;
    }
}

class Practical3
{
    public void printFrequency(string str)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        foreach (char c in str)
        {
            if (freq.ContainsKey(c))
            {
                freq[c] += 1;
            }
            else
            {
                freq.Add(c, 1);
            }
        }
        // display the dictionary
        Console.WriteLine($"Letter /t: Frequency");
        foreach (var item in freq)
        {
            Console.WriteLine($"{item.Key}   /t:   {item.Value}");
        }
    }

    public string MaxVowels(string sent)
    {
        string[] arr = sent.Split(' ');
        int maxVowels = 0;
        string ans = "";
        foreach (var item in arr)
        {
            int vowelCnt = 0;
            foreach (char c in item)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCnt++;
                }
            }
            if( vowelCnt > maxVowels)
            {
                maxVowels = vowelCnt;
                ans = item; 
            }

        }
        return ans;
    }
}

class Program {
    public static void Main(string[] args)
    {
        Practical2 obj2 = new Practical2();
        Practical3 obj3 = new Practical3();
        int ans1 = obj2.sock_pairs("abcda");
        Console.WriteLine($"The number of sock pairs : {ans1}");
    }
}