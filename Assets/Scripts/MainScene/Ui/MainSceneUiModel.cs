using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MainScene.Ui
{
    public class MainSceneUiModel : MonoBehaviour
    {
        [Header("Canvas info")]
        [SerializeField] private Canvas m_mainCanvas = null;
        [Header("Info about game")]
        [SerializeField] private Button m_reloadButton = null;
        [SerializeField] private TextMeshProUGUI m_statusGame = null;
        
        public Canvas MainCanvas => m_mainCanvas;
        public Button ReloadButton => m_reloadButton;
        public TextMeshProUGUI StatusGame => m_statusGame;

    }
}