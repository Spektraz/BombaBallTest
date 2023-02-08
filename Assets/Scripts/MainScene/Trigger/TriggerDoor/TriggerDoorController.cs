using System;
using MainScene.Trigger.TriggerCore;

namespace MainScene.Trigger.TriggerDoor
{
    public class TriggerDoorController : TriggerController<TriggerDoorView>
    {
         private TriggerDoorModel m_viewModel = null;
         public TriggerDoorController(TriggerDoorView view, TriggerDoorModel triggerDoorModel) : base(view)
        {
            m_viewModel = triggerDoorModel;
        }

        public override void TriggerEnter()
        {
            m_viewModel.AnimatorDoor.SetTrigger(GlobalConst.OpenDoorAnimator);
        }
    }
}

