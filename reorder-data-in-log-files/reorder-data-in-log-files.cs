public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        SortedDictionary<string,SortedSet<string>> dict = new SortedDictionary<string,SortedSet<string>>();
        List<string> dig = new List<string>();
        List<string> result = new List<string>();
        foreach(var str in logs)
        {
            if(str[str.IndexOf(' ')+1] >= 'a' && str[str.IndexOf(' ')+1] <= 'z')
            {
                var key = str.Substring(str.IndexOf(' ') + 1);
                if(dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new SortedSet<string>{str});
                }
            }
            else
            {
                dig.Add(str);
            }
        }

        foreach(var str in dict)
        {
            result.AddRange(str.Value);
        }

        foreach(var str in dig)
        {
            result.Add(str);
        }

        return result.ToArray();
    }
}


//CompareTo method
/* public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        Array.Sort(logs, (log1, log2) => {
            //log1 < log2 => -1
            //log1 == log2 => 0
            //log1 > log2 => 1
            int index1 = log1.IndexOf(" ");
            string id1 = log1.Substring(0, index1);
            string main1 = log1.Substring(index1+1);
            
            int index2 = log2.IndexOf(" ");
            string id2 = log2.Substring(0, index2);
            string main2 = log2.Substring(index2+1);
            
            Console.WriteLine(id1 + " " + main1 + " - " + id2 + " " + main2);
            
            bool isDigit1 = Char.IsDigit(main1[0]);
            bool isDigit2 = Char.IsDigit(main2[0]);
            
            if(!isDigit1 && !isDigit2)
            {
                int value = main1.CompareTo(main2);
                if(value == 0) return id1.CompareTo(id2);
                return value;
            }
            return isDigit1 ? (isDigit2 ? 0 : 1) : -1;
        });
        return logs;
    }
}*/