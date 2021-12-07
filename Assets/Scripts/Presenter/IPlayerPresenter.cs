using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP.Presenter
{
    public interface IPlayerPresenter
    {
        void RunForward();
        void RunBack();
        void Damage();
    }
}
