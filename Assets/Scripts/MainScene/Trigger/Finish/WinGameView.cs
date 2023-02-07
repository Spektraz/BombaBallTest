using UnityEngine;

namespace MainScene.Trigger.Finish
{
    public class WinGameView : MonoBehaviour
    {
        [SerializeField] private WinGameModel m_viewModel = null;
        private WinGameController m_controller = null;
        private void Start()
        {
            m_controller = new WinGameController();
        }
        public void OnTriggerEnter(Collider other)
        {
            if(other == m_viewModel.Сollider)
              m_controller.TriggerEnter();
        }
    }
}