using Constans;
using IView.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IView.View
{
    public interface ILogInView : IWarningMessage
    {
        void SetPresenter(ILogInPresenter presenter);
        event Func<string, string, Task> LogIn;
        void ShowMainWindow();
    }
}
