using IModel.Repositories;
using IView.View;
using IView.Presenter;
using System;
using Constans;
using System.Threading.Tasks;

namespace VP.Presenter
{
    public class LogInPresenter : ILogInPresenter
    {
        private readonly ILogInView _view;
        private readonly IUsersRepositories _repository;
        public LogInPresenter(ILogInView view, IUsersRepositories repository)
        {
            _view = view;
            _repository = repository;
            BindEvents();
        }

        private void BindEvents()
        {
            _view.LogIn += LogIn;
        }

        async private Task LogIn(string logIn, string password)
        {
            var logInResult = await _repository.TryLogIn(logIn, password).ConfigureAwait(false);
            switch(logInResult)
            {
                case LogInStatus.UserNotExist:
                    _view.ShowWarning("Użytkownik o podanej nazwie nie istniejeje w systemie.", "Niepoprawny login");
                    break;
                case LogInStatus.IncorrectPassword:
                    _view.ShowWarning("Wprowadzone hasło jest niepoprawne.", "Niepoprawne hasło");
                    break;
                case LogInStatus.AnotherNotAuthorizationStatus:
                    _view.ShowWarning("Podczas logowania do systemu wystąpił błąd.", "Błąd logowania użytkownika");
                    break;
                case LogInStatus.CorrectAuthorization:
                    _view.ShowMainWindow();
                    break;
            }
        }
    }
}
