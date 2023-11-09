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

        protected BaseService(INotifier notifier)
        {
            _notifier = notifier;
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
    }
}
