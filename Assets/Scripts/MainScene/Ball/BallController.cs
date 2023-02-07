using System;
using UnityEngine;

namespace MainScene.Ball
{
    public class BallController
    {
        private BallModel m_viewModel = null;
        private Rigidbody m_rigidbody = null;
        private float m_powerBomb = 0;
        private float m_timer = 0;
        private bool m_isFinish = false;
        public BallController(BallModel viewModel)
        {
            m_viewModel = viewModel;
            m_rigidbody = m_viewModel.BallObject.GetComponent<Rigidbody>();
            m_timer = GlobalConst.TimeJump;
        }
        public void Initialize()
        {
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGameEvent += FinishGame;
        }
        public void MoveBall()
        { 
            if(m_isFinish)
                return; 
            m_viewModel.MoveTransform.Translate(0,0,GlobalConst.SpeedBall);
            m_timer -= Time.deltaTime;
            if (!(m_timer < 0)) return;
            m_rigidbody.AddForce(Vector2.up * GlobalConst.JumpBall, ForceMode.Impulse);
            m_timer = GlobalConst.TimeJump;
        }
        public void CreateBomb()
        {
            if(m_isFinish || ApplicationContainer.Instance.ResultGame.IsLifeBomb)
                return;
            m_powerBomb += GlobalConst.UpBomb;
            var localScale = m_viewModel.BallObject.transform.localScale;
            if (localScale.x <= GlobalConst.LifeBall)
            {
                ApplicationContainer.Instance.EventHolder.OnFinishGame(GlobalConst.LooseGame);
                return;
            }
            var roadScale = m_viewModel.RoadObject.transform.localScale;
            localScale = new Vector3(
                localScale.x - m_powerBomb,
                localScale.y - m_powerBomb,
                localScale.z - m_powerBomb);
            roadScale = new Vector3(
                localScale.x, 
                roadScale.y,
                roadScale.z);
            ApplicationContainer.Instance.ResultGame.DistanceBombCount = localScale.z;
            ApplicationContainer.Instance.EventHolder.OnSizeBomb(m_powerBomb);
            m_viewModel.BallObject.transform.localScale = localScale;
            m_viewModel.RoadObject.transform.localScale = roadScale;
        }

        public void ShootBomb()
        {
            if(ApplicationContainer.Instance.ResultGame.IsLifeBomb)
                return;
            ApplicationContainer.Instance.EventHolder.OnShootBomb(true);
            m_powerBomb = 0;
        }
        private void FinishGame(string info)
        {
            m_isFinish = true;
        }
        private void DisposeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnFinishGameEvent -= FinishGame;
        }
        public void Dispose()
        {
            DisposeEvents();
        }
    }
}

