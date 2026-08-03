public class Solution {
    public int[][] Merge(int[][] intervals) {
       Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0])); 

        int[] current = intervals[0];
        List<int[]> merged = new List<int[]>();
        merged.Add(current);

        for (int i = 1; i < intervals.Length; i++) {
            int nextStart = intervals[i][0];
            int nextEnd = intervals[i][1];

            if (nextStart <= current[1]) {
                current[1] = Math.Max(current[1], nextEnd);
            } else {
                current = intervals[i];
                merged.Add(current);
            }
        }

        return merged.ToArray();
    }
}
