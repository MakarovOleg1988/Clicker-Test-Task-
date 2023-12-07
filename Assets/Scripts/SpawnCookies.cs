using UnityEngine;

namespace ClickerTestTask
{
    public class SpawnCookies : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] _cookiePrefab;

        [SerializeField]
        private float _boardX = 3.0f, _startTime, _minDelayTime, _maxDelayTime;

        private void Start()
        {
            InvokeRepeating("SpawnCookiesPrefab", _startTime, Random.Range(_minDelayTime, _maxDelayTime));
        }

        private void SpawnCookiesPrefab()
        {
            int indexCookie = Random.Range(0, _cookiePrefab.Length);

            float PosX = Random.Range(-_boardX, _boardX);
            Vector2 SpawnPos = new Vector2(PosX, transform.position.y);

            Instantiate(_cookiePrefab[indexCookie], SpawnPos, _cookiePrefab[indexCookie].transform.rotation);
        }
    }
}
