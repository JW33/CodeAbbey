/* Find the Difference */ success [runtime beats 52.26% of other C# submissions; what on earth could be optimized here?

public class Solution {
    public char FindTheDifference(string s, string t) {
		char[] chars_s = s.ToCharArray();
    	char[] chars_t = t.ToCharArray();

        int ascii_t = 0;
        int ascii_s = 0;

        foreach(char c in chars_s)
        {
        	ascii_s += (int)c;
        }

        foreach(char c in chars_t)
        {
        	ascii_t += (int)c;
        }

        return (char)(ascii_t - ascii_s);
    }
}
