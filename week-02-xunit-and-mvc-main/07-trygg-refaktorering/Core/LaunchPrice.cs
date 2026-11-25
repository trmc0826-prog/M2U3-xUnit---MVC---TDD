namespace SpaceAcademy;

public static class LaunchPrice
{
    public static int Calculate(int peopleCount, bool priority)
    {
        int totalPrice = peopleCount * 100;

        if (priority)
        {
            totalPrice = totalPrice + peopleCount * 20;
        }

        return totalPrice;
    }
}
