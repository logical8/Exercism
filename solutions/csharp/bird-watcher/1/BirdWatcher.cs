class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1]++;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int i in birdsPerDay){
            if (i == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int result = 0;
        for(int i = 0; i < numberOfDays; i++){
            result += birdsPerDay[i];
        }
        return result;
    }

    public int BusyDays()
    {
        int result = 0;
        for(int i = 0; i < birdsPerDay.Length; i++){
            if(birdsPerDay[i] >= 5) result++;
        }
        return result;
    }
}
