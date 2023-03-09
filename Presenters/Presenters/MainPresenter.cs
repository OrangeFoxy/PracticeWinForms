using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Common;
using Presentation.Views;
using DomainModel;
using DBContext.DB.Models;

namespace Presentation.Presenters
{
    public class MainPresenter : IPresenter
    {
        private readonly IMainView view;
        private readonly IMainService service;
        string loginName;
        User user;
        Game game;
        public MainPresenter(IMainView view, IMainService service)
        {
            this.view = view;
            this.service = service;

            view.UpdateScore += () => UpdateScore();
        }
        public string LoginName
        {
            get => loginName;
            set
            {
                user = service.GetUser(value);
                loginName = user.Login;
            }
        }

        public void Run()
        {
            if (LoginName is not null) StartView();
            else throw new Exception("Не передано имя пользователя");
        }
        private void StartView()
        {
            view.UserName = user.Name;
            //view.Admin = user.Admin;
            game = service.CreateGame(user);
            view.Score = game.Score;
            view.TopList = service.GetTopScore();
            view.Show();
        }
        private void UpdateScore()
        {
            game.Score++;
            view.Score = game.Score;
            service.UpdateGame(game);
            view.TopList = service.GetTopScore();
        }
    }
}
