using UnityEngine;
using UnityEngine.UI;

namespace StartScene
{
    public class StartSceneModel : MonoBehaviour
    {
        [Header("Main buttons")]
        [SerializeField] private Button m_startButton = null;

        [SerializeField] private Button m_closeButton = null;
        public Button StartButton => m_startButton;
        public Button CloseButton => m_closeButton;

    }
}