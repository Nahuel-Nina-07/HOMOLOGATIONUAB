using Homologation.Domain.Exceptions;

namespace Homologation.Domain.Models;

public class HomologationModel
{
    public Guid Id { get; set; }
    public string State { get; set; }

    public HomologationModel(
        Guid id,
        string state
    )
    {
        Id = id;
        State = ValidateState(state);
    }
    
    public void SetState(string state) => State = ValidateState(state);
        
    private static string ValidateState(string state)
    {
        if (string.IsNullOrWhiteSpace(state))
            throw new InvalidStateException();

        string[] validStates = { "Pending", "Approved", "Rejected" };
        if (!validStates.Contains(state))
            throw new InvalidStateException();

        return state;
    }
}

