using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVP.Model;
using MVP.View;

namespace MVP.Presenter
{
    public class PlayerPresenter : IPlayerPresenter
    {
        #region Private Variables

        private IPlayerView _view;
        private PlayerModel _model;

        #endregion

        #region Presenter Methods

        public PlayerPresenter(IPlayerView view)
        {
            _model = new PlayerModel();
            _view = view;
        }

        public void RunForward()
        {
            _view.DoRunForward();
        }

        public void RunBack()
        {
            _view.DoRunBack();
        }

        public void Damage()
        {
            _model.LivesCount -= 1;
            _view.DoDamage(_model.LivesCount);
        }

        #endregion
    }
}