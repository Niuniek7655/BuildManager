using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IView.View
{
    public interface IWarningMessage
    {
        void ShowWarning(string message, string title);
    }
}
