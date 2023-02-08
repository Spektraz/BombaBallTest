using UnityEngine;

namespace MainScene.Trigger.Barrier
{
    public class BarrierView: MonoBehaviour
    {
        [SerializeField] private BarrierModel m_viewModel = null;
        private BarrierController m_controller = null;
        private void Start()
        {
            m_controller = new BarrierController( this);
        }

        private void Update()
        {
            m_controller.DeleteTree();
        }

        public void DestroyObject()
        {
            gameObject.SetActive(false);
        }
        public void OnTriggerEnter(Collider other)
        {
            if(other == m_viewModel.Сollider)
              m_controller.TriggerEnter();
            else if (other == m_viewModel.ColliderBomb)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                m_controller.TriggerBomb();
            }
        }
    }
}