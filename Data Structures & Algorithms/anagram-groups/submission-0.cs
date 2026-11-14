public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        int i=0;

        List<int[]> freqs = new List<int[]>(strs.Length);
        for(i=0;i<strs.Length;i++){
            freqs.Add(new int[26]);
        }

        int j=0;

        foreach(string s in strs){
            foreach(char c in s){
                freqs[j][((int)c - 97)]++;
            }
            j++;
        }

        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        for(i=0;i<freqs.Count;i++){
            string id = IDCreator(freqs[i]);
            if(dict.ContainsKey(id)){
                dict[id].Add(strs[i]);
            }
            else{
                dict.Add(id, new List<string>() {strs[i]});
            }
        }

        return dict.Values.ToList();

    }
    public string IDCreator(int[] freq){
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<freq.Length;i++){
            sb.Append(freq[i].ToString() + "#");
        }
        return sb.ToString();
    }
}
