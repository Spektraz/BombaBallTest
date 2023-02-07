using UnityEngine;

namespace MainScene.Ball
{
    public class BallModel : MonoBehaviour
    {
        [Header("Object Game")] 
       
        [SerializeField] private GameObject m_ballObject = null;
        
        [SerializeField] private GameObject m_roadObject = null;
        [Header("Move")]
        [SerializeField] private Transform m_moveTransform = null;
        public GameObject BallObject => m_ballObject;
        public GameObject RoadObject => m_roadObject;
        public Transform MoveTransform => m_moveTransform;

    }
}