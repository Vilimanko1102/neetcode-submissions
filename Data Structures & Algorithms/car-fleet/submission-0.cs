public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        List<(int Position, int Speed)> sorted = new();

        for (int i = 0; i < position.Length; i++)
        {
            sorted.Add((position[i], speed[i]));
        }

        sorted = sorted.OrderByDescending(x => x.Position).ToList();

        List<float> arrivalTimes = new();

        foreach((int Position, int Speed) tuple in sorted){
            arrivalTimes.Add((target - tuple.Position)/(float)tuple.Speed);
        }

        int cnt = 1;
        float lastArrivalTime = arrivalTimes[0];
        for (int i = 1; i < arrivalTimes.Count(); i++)
        {
            if(lastArrivalTime < arrivalTimes[i]){
                lastArrivalTime = arrivalTimes[i];
                cnt++;
            }
        }

        return cnt;

    }
}
