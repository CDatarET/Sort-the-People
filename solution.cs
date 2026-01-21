public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
        for(int i = 0; i < heights.Length; i++){
            sd[heights[i]] = names[i];
        }

        int r = 0;
        foreach(var kvp in sd.Reverse()){
            names[r++] = kvp.Value;
        }

        return(names);
    }
}
