using UnityEngine;

namespace MainScene.Ball.Bomb
{
    public class BombView : MonoBehaviour
    {
        [SerializeField] private BombModel m_viewModel = null;
        private BombController m_controller = null;

        private void Start()
        {
            m_controller = new BombController(m_viewModel);
            m_controller.Initialize();
        }

        private void Update()
        {
            m_controller.SetTime();
        }
        public void OnTriggerEnter(Collider other)
        {
            m_controller.TriggerEnter();
        }
        private void OnDestroy()
        {
            m_controller.Dispose();
        }
    }
}