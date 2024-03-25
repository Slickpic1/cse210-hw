public class Player : Character
{
    public Player() : base()
    {
        position[0] = 1;  //Better way to do this?
        position[1] = 1;
    }

    public void Move(string direction)
    {
        // Determine where the new position will be
        switch (direction)
        {
            case "north":
                position[0] += 1;
                break;

            case "south":
                position[0] -= 1;
                break;

            case "east":
                position[1] += 1;
                break;

            case "west":
                position[0] -= 1;
                break;
        }
    }
}