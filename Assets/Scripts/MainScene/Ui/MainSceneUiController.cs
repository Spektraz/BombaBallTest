using System;
using UnityEngine.SceneManagement;

namespace MainScene.Ui
{
    public class MainSceneUiController
    {
        private MainSceneUiModel m_viewModel = null;
        public MainSceneUiController(MainSceneUiModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeEvents();
            InitializeButtons();
        }
        private void InitializeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGameEvent += InitializeText;
        }
        private void InitializeText(string status)
        {
            m_viewModel.StatusGame.text = status;
            SwitchCanvas(true);
        }
        private void SwitchCanvas(bool state)
        {
            m_viewModel.MainCanvas.enabled = state;
        }
        private void InitializeButtons()
        {
            m_viewModel.ReloadButton.onClick.AddListener(ReloadGame);
        }
        private void ReloadGame()
        {
            SceneManager.LoadScene(GlobalConst.StartScene);
        }
        private void DisposeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGameEvent -= InitializeText;
        }
        private void DisposeButtons()
        {
            m_viewModel.ReloadButton.onClick.RemoveAllListeners();
        }
        public void Dispose()
        {
            DisposeEvents();
            DisposeButtons();
        }
    }
}

