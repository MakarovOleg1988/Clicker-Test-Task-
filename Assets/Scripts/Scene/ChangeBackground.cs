using UnityEngine;

namespace ClickerTestTask
{
    public class ChangeBackground: MonoBehaviour
    {
        [SerializeField]
        private Sprite[] _backgroundSprite;

        [SerializeField]
        private GameObject _background;

        [SerializeField]
        private GameObject _particleSystemStars;

        public bool _isAfternoon = false;

        [SerializeField]
        private float _startTime, _delayTime;

        private void Start()
        {
            InvokeRepeating("ChangeColorBackground", _startTime, _delayTime);
        }

        private void Update()
        {
            if (_isAfternoon == true) _particleSystemStars.SetActive(false);
            else if (_isAfternoon == false) _particleSystemStars.SetActive(true);
        }

        private void ChangeColorBackground()
        {
            if (_isAfternoon == false)
            {
                _background.GetComponent<SpriteRenderer>().sprite = _backgroundSprite[0];
                _isAfternoon = true;
            }
            else if (_isAfternoon == true)
            {
                _background.GetComponent<SpriteRenderer>().sprite = _backgroundSprite[1];
                _isAfternoon = false;
            }
        }
    }
}