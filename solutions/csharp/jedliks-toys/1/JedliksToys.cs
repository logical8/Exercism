class RemoteControlCar
{
    private int _distance = 0;
    private int _batteryRemainingPercent = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        if(_batteryRemainingPercent == 0) return "Battery empty";
        return $"Battery at {_batteryRemainingPercent}%";
    }

    public void Drive()
    {
        if(_batteryRemainingPercent == 0) return;
        _distance += 20;
        _batteryRemainingPercent -= 1;
    }
}
