using Alex.Developer.Pension.Funds.Domain.Entities;
using Alex.Developer.Pension.Funds.Domain.Repositories;
using Alex.Developer.Pension.Funds.Infra.PensionFundsContext.DataContexts;
using Dapper;
using System.Linq;

namespace Alex.Developer.Pension.Funds.Infra.PensionFundsContext.Repositories
{
    public class PlanRepository : IPlanRepository
    {
        private readonly PensionFundDataContext _context;
        public PlanRepository(PensionFundDataContext context)
        {
            _context = context;
        }
        public bool CheckPlan(long cnpb)
        {
            return _context.Connection.Query<bool>(@"Select case when exists( 
                                                        select 1 from Plan where cnpb = @cnpb
                                                    ) then cast(1 as bit) else cast(0 as bit) end",
                                            new { @cnpb = cnpb }, 
                                            commandType: System.Data.CommandType.Text)
                                            .FirstOrDefault();
        }

        public void Save(Plan plan)
        {
            _context.Connection.Execute(@"procedure_de_save",
                                            new { @cnpb = plan.Cnpb },//adicionar demais campos
                                            commandType: System.Data.CommandType.Text);
                                            
        }
    }
}
