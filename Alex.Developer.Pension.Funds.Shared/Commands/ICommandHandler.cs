using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Shared.Commands
{
    public interface ICommandHandler<T> where T: ICommand
    {
        ICommandResult Handle(T command);
    }
}
