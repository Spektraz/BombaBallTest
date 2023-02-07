using UnityEngine;

namespace StartScene
{
    public class StartSceneView : MonoBehaviour
    {
        [SerializeField] private StartSceneModel m_viewModel = null;
        private StartSceneController m_controller = null;

        private void Start()
        {
            m_controller = new StartSceneController(m_viewModel);
            m_controller.Initialize();
        }

        private void OnDestroy()
        {
            m_controller.Dispose();
        }
    }
}