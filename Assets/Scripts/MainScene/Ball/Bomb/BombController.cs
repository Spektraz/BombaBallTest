using System;
using UnityEngine;

namespace MainScene.Ball.Bomb
{
    public class BombController
    {
        private BombModel m_viewModel = null;
        private Rigidbody m_rigidbody = null;
        private SphereCollider m_collider = null;
        private MeshRenderer m_meshRenderer = null;
        private float m_timer = 0;
        private bool m_isBombFree = false;
        public BombController(BombModel viewModel)
        {
            m_viewModel = viewModel;
            m_timer = GlobalConst.TimeLifeBomb;
            m_rigidbody = m_viewModel.BombObject.GetComponent<Rigidbody>();
            m_collider = m_viewModel.BombObject.GetComponent<SphereCollider>();
            m_meshRenderer = m_viewModel.BombObject.GetComponent<MeshRenderer>();
        }

        public void Initialize()
        {
            InitializeEvents();
        }
        private void InitializeEvents()
        {
            ApplicationContainer.Instance.EventHolder.OnShootBombEvent += ShootBomb;
            ApplicationContainer.Instance.EventHolder.OnSizeBombEvent += ChangeBomb;
            ApplicationContainer.Instance.EventHolder.OnBoomEvent += BoomObject;
        }

        private void BoomObject(bool state)
        {
            if(!state)
                return;
            m_rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            m_rigidbody.useGravity = false;
            m_meshRenderer.enabled = false;
        }
        private void ChangeBomb(float size)
        {
            m_viewModel.BombObject.SetActive(true);
            m_meshRenderer.enabled = true;
            m_collider.radius = GlobalConst.ColliderUsually;
            var bombScale = m_viewModel.BombObject.transform.localScale;
            bombScale = new Vector3(
                bombScale.x + size,
                bombScale.y + size,
                bombScale.z + size);
            m_viewModel.BombObject.transform.localScale = bombScale;
        }
        private void ShootBomb(bool state)
        {
            m_isBombFree = state;
            m_collider.radius = GlobalConst.ColliderSizeBoom;
            m_collider.enabled = state;
            m_rigidbody.constraints = RigidbodyConstraints.None;
            m_rigidbody.AddForce(Vector3.forward * GlobalConst.LaunchVelocity, ForceMode.Impulse);
            m_rigidbody.useGravity = state;
            ApplicationContainer.Instance.ResultGame.IsLifeBomb = true;
        }
        public void SetTime()
        {
            if(!m_isBombFree)
                return;
            m_timer -= Time.deltaTime;
            if (!(m_timer < 0)) return;
            DisposeBomb();
            m_isBombFree = false;
            m_timer = GlobalConst.TimeLifeBomb;
        }
        public void TriggerEnter()
        {
            DisposeBomb();
        }
        private void DisposeBomb()
        {
            m_viewModel.BombObject.transform.localScale = new Vector3(
                GlobalConst.StandardBombSize,
                GlobalConst.StandardBombSize,
                GlobalConst.StandardBombSize);
            Vector3 position;
            position = new Vector3(
                0,
                0,
                ApplicationContainer.Instance.ResultGame.DistanceBombCount);
            m_collider.enabled = false;
            m_rigidbody.constraints = RigidbodyConstraints.FreezePosition;
            m_rigidbody.useGravity = false;
            m_viewModel.BombObject.transform.localPosition = position;
            ApplicationContainer.Instance.ResultGame.IsLifeBomb = false;
            m_viewModel.BombObject.SetActive(false);
        } 
        private void DisposeEvents()
        {
            ApplicationContainer.Instance.ResultGame.IsLifeBomb = false;
            ApplicationContainer.Instance.EventHolder.OnShootBombEvent -= ShootBomb;
            ApplicationContainer.Instance.EventHolder.OnSizeBombEvent -= ChangeBomb;
            ApplicationContainer.Instance.EventHolder.OnBoomEvent -= BoomObject;
        }
        public void Dispose()
        {
            DisposeEvents();
        }
    }
}

