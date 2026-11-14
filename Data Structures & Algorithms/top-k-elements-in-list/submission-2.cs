public class Solution {

    public static List<int> FindKLargest(Dictionary<int, int> freq, int k)
    {
        if (freq == null || freq.Count == 0 || k <= 0)
            return new List<int>();

        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

        foreach (KeyValuePair<int, int> kvp in freq)
        {
            if (minHeap.Count < k)
            {
                minHeap.Enqueue(kvp.Key, kvp.Value);
            }
            else if (minHeap.TryPeek(out int minElement, out int minPriority) && kvp.Value > minPriority)
            {
                minHeap.DequeueEnqueue(kvp.Key, kvp.Value);
            }
        }

        List<int> res = new List<int>();
        while (minHeap.Count > 0)
        {
            res.Add(minHeap.Dequeue());
        }
        
        return res;
    }

    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>(nums.Length);

        foreach(int x in nums){
            if(freq.ContainsKey(x)){
                freq[x]++;
            }
            else{
                freq.Add(x, 1);
            }
        }

        return FindKLargest(freq, k).ToArray();

    }
}
