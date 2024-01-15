using FluentValidation;
using FluentValidation.Results;
using JLASales.Business.Interfaces;
using JLASales.Business.Models;
using JLASales.Business.Notifications;


namespace JLASales.Business.Services
{
    public abstract class BaseService
    {


        private readonly INotifier _notifier;
        private readonly IUnitOfWork _unitOfWork;

        protected BaseService(INotifier notifier, IUnitOfWork unitOfWork)
        {
            _notifier = notifier;
            _unitOfWork = unitOfWork;
        }

        protected bool ExecuteValidation<TValidation, TEntity>(TValidation validation, TEntity entity)
            where TValidation : AbstractValidator<TEntity>
            where TEntity : Entity
        {
            var validator = validation.Validate(entity);
            if (validator.IsValid) return true;
            //Lançamento de notificações
            Notify(validator);
            return false;
        }

        protected void Notify(string message)
        {
            _notifier.HandleNotification(new Notification(message));
        }
        protected void Notify(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {

                Notify(error.ErrorMessage);
            }
        }
        protected async Task<bool> Commit()
        {
            if (await _unitOfWork.Commit()) return true;

            Notify("Não foi possível salvar os dados no BD");
            return false;
        }
    }
}
