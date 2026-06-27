namespace TransportChallenge;

public class Car : Vehicle, IDriveable
{

    public override string Move()
    {
        return "Driving in the road.";
    }

}