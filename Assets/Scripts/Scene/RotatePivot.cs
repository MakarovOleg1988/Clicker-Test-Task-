using UnityEngine;

namespace ClickerTestTask
{
    public class RotatePivot : MonoBehaviour
    {
        [SerializeField]
        private float _speedRotation;

        private void Update()
        {
            transform.Rotate(-Vector3.forward * _speedRotation * Time.deltaTime);
        }
    }
}
