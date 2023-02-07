using UnityEngine;

namespace MainScene.Ball.Bomb
{
    public class BombModel : MonoBehaviour
    {
        [Header("Bomb Object")]
        [SerializeField] private GameObject m_bombObject = null;
        public GameObject BombObject => m_bombObject;

    }
}