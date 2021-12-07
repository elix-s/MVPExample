using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MVP.Model
{
    public class PlayerModel
    {
        #region Model Fields

        public int LivesCount {get; set;}
        public int BulletsCount {get; set;}

        #endregion

        #region Start Initialization

        public PlayerModel()
        {
            LivesCount = 10;
            BulletsCount = 100;
        }

        #endregion

    }
}