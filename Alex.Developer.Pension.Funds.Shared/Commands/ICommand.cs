using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Shared.Commands
{
    public interface ICommand
    {
        bool IsValid();
    }
}
