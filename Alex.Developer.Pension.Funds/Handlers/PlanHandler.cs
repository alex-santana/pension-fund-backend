using Alex.Developer.Pension.Funds.Domain.Commands.PlanCommands.Inputs;
using Alex.Developer.Pension.Funds.Domain.Commands.PlanCommands.Outputs;
using Alex.Developer.Pension.Funds.Domain.Entities;
using Alex.Developer.Pension.Funds.Domain.Repositories;
using Alex.Developer.Pension.Funds.Domain.Services;
using Alex.Developer.Pension.Funds.Domain.ValueObjects;
using Alex.Developer.Pension.Funds.Shared.Commands;
using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace Alex.Developer.Pension.Funds.Domain.Handlers
{
    public class PlanHandler : Notifiable, ICommandHandler<CreatePlanCommand>
    {
        private readonly IPlanRepository _planRepository;
        private readonly IEmailService _emailService;
        public PlanHandler(IPlanRepository planRepository, IEmailService emailService)
        {
            _planRepository = planRepository;
            _emailService = emailService;
        }
        //Nesta classe implementaremos um ou mais metodos Handle.
        //O suficiente, neste caso, para criar um Plano ou editar e etc
        //
        public ICommandResult Handle(CreatePlanCommand command)
        {
            //TODO: No handle é feito todos os passos, validações

            //Validar se Plano já existe na base,código cnpb
            _planRepository.CheckPlan(command.Cnpb);
            //Criar VOs
            var name = new Name(command.NameField, command.Abreviation, command.Description);
            var date = new Date(command.Inclusion, command.Alteracion);
            //Criar Entidade
            var plan = new Plan();
            //Validar
            AddNotifications(name.Notifications);
            AddNotifications(date.Notifications);
            AddNotifications(plan.Notifications);
            if (Invalid)
                return null;
            //Persistir o Plano
            _planRepository.Save(plan);
            //Enviar Email caso seja necessario 
            //_emailService.Send();
            //Retornar o resultado para a tela
            return new CreatePlanCommandResult();
        }

    }
}
