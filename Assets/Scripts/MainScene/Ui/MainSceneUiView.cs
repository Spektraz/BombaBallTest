using UnityEngine;

namespace MainScene.Ui
{
    public class MainSceneUiView : MonoBehaviour
    {
        [SerializeField] private MainSceneUiModel m_viewModel = null;
        private MainSceneUiController m_controller = null;

        private void Start()
        {
            m_controller = new MainSceneUiController(m_viewModel);
            m_controller.Initialize();
        }

        private void OnDestroy()
        {
            m_controller.Dispose();
        }
    }
}