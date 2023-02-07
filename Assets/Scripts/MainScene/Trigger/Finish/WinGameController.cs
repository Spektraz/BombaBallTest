using System;

namespace MainScene.Trigger.Finish
{
    public class WinGameController
    {
        public void TriggerEnter()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.WinGame);
        }
    }
}

