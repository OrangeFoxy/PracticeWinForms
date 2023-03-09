using System;
using Presentation.Common;

namespace Presentation.Views
{
    public interface ILoginView : IView
    {
        string LoginName { get; }
        string Pass { get; }
        // Попытка входа
        event Action Login;
        // Попытка регистрации
        event Action Register;
        void ShowError(string errorMessage);
    }
}
