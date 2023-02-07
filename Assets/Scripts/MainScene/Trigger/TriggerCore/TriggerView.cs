using UnityEngine;

namespace MainScene.Trigger.TriggerCore
{
    public  abstract class TriggerView<T> : MonoBehaviour where T: TriggerModel
    {
        [SerializeField] private T m_viewModel = default(T);
        //private TriggerController<T> m_controller = null;
        
        public virtual void Start(T triggerController)
        {
          //  m_controller = new TriggerController<T>(m_viewModel);
        }

        public virtual void OnTriggerEnter(Collider other)
        {
        //    if(other == m_viewModel.Сollider) 
                //m_controller.TriggerEnter();
        }
    }
}
