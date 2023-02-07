using System;
using MainScene.Trigger.TriggerCore;

namespace MainScene.Trigger.TriggerDoor
{
    public class TriggerDoorController //: TriggerController<TriggerDoorModel>
    {
        private TriggerDoorModel m_viewModel = null;
        public TriggerDoorController(TriggerDoorModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void TriggerEnter()
        {
            m_viewModel.AnimatorDoor.SetTrigger(GlobalConst.OpenDoorAnimator);
        }
        // public override void TriggerEnter()
        // {
        //     m_viewModel.AnimatorDoor.SetTrigger(GlobalConst.OpenDoorAnimator);
        // }
        // public TriggerDoorController(TriggerDoorModel viewModel) : base(viewModel)
        // {
        // }
    }
}

