using System;
using Presentation.Common;

namespace Presentation.Views
{
    public interface IRegistrationView : IView
    {
        string LoginName { get; }
        string Pass { get; }
        string UserName { get; }
        bool Admin { get; }
        event Action Register;
        void ShowError(string errorMessage);
    }
}
