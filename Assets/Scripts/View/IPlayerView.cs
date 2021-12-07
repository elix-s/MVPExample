using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP.View
{
    public interface IPlayerView
    {
        void DoDamage(int lives);
        void DoRunForward();
        void DoRunBack();
    }
}