namespace SpaceAcademy;

public static class LaunchPolicy
{
    public static bool CanLaunch(int fuel, bool safetyApproved)
    {
        return fuel >= 50 && safetyApproved;
    }
}