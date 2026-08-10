public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) return "";    

        var sizes = new List<int>();
        var result = new StringBuilder();

        foreach (var str in strs) {
            sizes.Add(str.Length);
        }

        foreach (var size in sizes) {
            result.Append(size).Append(',');
        }
        result.Append('#');

        foreach (var str in strs) {
            result.Append(str);
        }

        return result.ToString();
    }

    public List<string> Decode(string s) {
        if (s.Length == 0) return new List<string>();

        var sizes = new List<int>();
        var result = new List<string>();
        int i = 0;

        while (s[i] != '#') {
            int j = i;
            while (s[j] != ',') {
                j++;
            }

            sizes.Add(int.Parse(s.Substring(i, j - i)));
            i = j + 1;
        }

        i++;

        foreach (var size in sizes) {
            result.Add(s.Substring(i, size));
            i = i + size;
        }

        return result;
   }
}
