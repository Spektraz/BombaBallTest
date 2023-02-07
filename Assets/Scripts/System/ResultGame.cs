namespace System
{
    public class ResultGame
    {
        private float m_distanceBombCount = 0;
        public float DistanceBombCount
        {
            get => m_distanceBombCount;
            set => m_distanceBombCount = value;
        }
        private bool m_isLifeBomb = false;
        public bool IsLifeBomb
        {
            get => m_isLifeBomb;
            set => m_isLifeBomb = value;
        }
    }
}