using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.TriggerDoor
{
    public class TriggerDoorView : TriggerView
    {
        [SerializeField] private TriggerDoorModel m_viewModel;
        public override void OnTriggerEnter(Collider other)
        {
            if(other == m_viewModel.Сollider) 
                base.OnTriggerEnter(other);
        }
        protected override IController CreateController() => new TriggerDoorController(this,m_viewModel);
    }
}