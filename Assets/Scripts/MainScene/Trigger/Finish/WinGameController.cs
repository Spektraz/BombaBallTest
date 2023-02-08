using System;
using MainScene.Trigger.TriggerCore;

namespace MainScene.Trigger.Finish
{
    public class WinGameController :  TriggerController<WinGameView>
    {
        public WinGameController(WinGameView view) : base(view)
        {
        }
        public override void TriggerEnter()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.WinGame);
        }
    }
}

