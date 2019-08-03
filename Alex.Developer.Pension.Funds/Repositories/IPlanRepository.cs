using Alex.Developer.Pension.Funds.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Repositories
{
    public interface IPlanRepository
    {
        //Nosso repositorio não dependerar de implementação e sim de um contrato
        bool CheckPlan(long cnpb);
        void Save(Plan plan);

    }
}
