using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Services
{
    public interface IEmailService
    {
        void Send(string to, string from, string subject, string body);
    }
}
