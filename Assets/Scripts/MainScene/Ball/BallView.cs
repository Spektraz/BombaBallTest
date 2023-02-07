using UnityEngine;

namespace MainScene.Ball
{
    public class BallView : MonoBehaviour
    {
        [SerializeField] private BallModel m_viewModel = null;
        private BallController m_controller = null;

        private void Start()
        {
            m_controller = new BallController(m_viewModel);
            m_controller.Initialize();
        }

        private void Update()
        {
            m_controller.MoveBall();
            OnClick();
        }
        private void OnDestroy()
        {
            m_controller.Dispose();
        }

        private void OnClick()
        {
            if (Input.touchCount > 0)
            {
                m_controller.CreateBomb();
            }

            // else if (Input.touchCount == 0)
            // {
            //     m_controller.FinishCreateBomb();
            // }
#if UNITY_EDITOR
            if (Input.GetKey(KeyCode.Mouse0))
            {
                m_controller.CreateBomb();
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                m_controller.ShootBomb();
            }
#endif
        }
    }
}