using MainScene.Trigger.TriggerCore;
using UnityEngine;

namespace MainScene.Trigger.TriggerDoor
{
    // public class TriggerDoorView : TriggerView<TriggerDoorModel>
    // {
    //     public override void OnTriggerEnter(Collider other)
    //     {
    //         throw new System.NotImplementedException();
    //     }
    // }
    public class TriggerDoorView : MonoBehaviour
    {
        [SerializeField] private TriggerDoorModel m_viewModel = null;
        private TriggerDoorController m_controller = null;
        
        private void Start()
        {
            m_controller = new TriggerDoorController(m_viewModel);
        }
        
        public void OnTriggerEnter(Collider other)
        {
            if(other == m_viewModel.Сollider)
                m_controller.TriggerEnter();
        }
    }
}