class Solution {
    public String[] sortPeople(String[] names, int[] heights) {
        TreeMap<Integer, String> map = new TreeMap<Integer, String>();
        for(int i = 0; i < heights.length; i++){
            map.put(heights[i], names[i]);
        }

        int i = 0;
        for(int key : map.descendingKeySet()){
            names[i++] = map.get(key);
        }

        return(names);
    }
}
