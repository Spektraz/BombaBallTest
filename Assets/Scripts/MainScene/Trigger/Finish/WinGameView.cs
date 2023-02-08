using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.Finish
{
    public class WinGameView : TriggerView
    {
        [SerializeField] private WinGameModel m_viewModel = null;
        public override void OnTriggerEnter(Collider other)
        {
            if(other == m_viewModel.Сollider) 
                base.OnTriggerEnter(other);
        }
        protected override IController CreateController() => new WinGameController(this);
    }
}