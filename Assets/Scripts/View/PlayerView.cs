using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVP.Presenter;

namespace MVP.View
{
    public class PlayerView : MonoBehaviour, IPlayerView
    {
        #region Private Variables

        private IPlayerPresenter _presenter;

        #endregion

        #region User Input Events

        public void RunForwardEvent()
        {
            _presenter.RunForward();
        }

        public void RunBackEvent()
        {
            _presenter.RunBack();
        }

        public void DamageEvent()
        {
            _presenter.Damage();
        }

        #endregion

        #region Methods used in the Presenter layer 

        /// <summary>
        /// Метод повреждения персонажа
        /// </summary>
        /// <param name="lives">Количество жизней</param>
        public void DoDamage(int lives)
        {
            Destroy(gameObject);
        }

        public void DoRunForward()
        {
            transform.Translate(0.0f, 0.1f, 0.0f);
        }

        public void DoRunBack()
        {
            transform.Translate(0.0f, -0.1f, 0.0f);
        }

        #endregion

        #region  MonoBehaviour

        void Start()
        {
            _presenter = new PlayerPresenter(this);
        }

        #endregion
    }
}