using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace StartScene
{
    public class StartSceneController
    {
        private StartSceneModel m_viewModel = null;
        public StartSceneController(StartSceneModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            m_viewModel.StartButton.onClick.AddListener(StartGame);
            m_viewModel.CloseButton.onClick.AddListener(CloseGame);
        }
        private void StartGame()
        {
            SceneManager.LoadScene(GlobalConst.MainScene);
        }
        private void CloseGame()
        {
            Application.Quit();
        }
        private void DisposeButtons()
        {
            m_viewModel.StartButton.onClick.RemoveAllListeners();
            m_viewModel.CloseButton.onClick.RemoveAllListeners();
        }
        public void Dispose()
        {
            DisposeButtons();
        }
    }
}

