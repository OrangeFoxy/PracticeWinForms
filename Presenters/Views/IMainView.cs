using System;
using Presentation.Common;
using System.Collections.Generic;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void ShowError(string errorMessage);
        int Score { set; }
        string UserName { set; }
        event Action UpdateScore;
        bool Admin { set; }
        List<string> TopList { set; }
    }
}
