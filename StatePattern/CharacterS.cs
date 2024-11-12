namespace phuong.baocao;

public class CharacterS
{
    private IState currentState;

    public CharacterS(IState initialState)
    {
        currentState = initialState;
    }

    public void SetState(IState newState)
    {
        currentState = newState;
        Console.WriteLine("State changed to: " + newState.GetType().Name);
    }

    public void PerformAction()
    {
        currentState.Handle(this);
    }
}
