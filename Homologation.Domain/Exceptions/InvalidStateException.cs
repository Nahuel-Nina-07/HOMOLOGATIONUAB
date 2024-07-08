using Homologation.Domain.Common;

namespace Homologation.Domain.Exceptions;

public class InvalidStateException : DomainException
{
    public InvalidStateException():base("Invalid state")
    {
    }
}