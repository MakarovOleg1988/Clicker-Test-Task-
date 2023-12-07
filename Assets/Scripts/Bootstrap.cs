using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class Bootstrap: MonoBehaviour
    {
        public int _ticketValue = 40;

        public int _levelValue = 1;

        public bool _gravitySlowDownIsActive = false;

        public TextMeshProUGUI _ticketValueText;

        public GameObject _gravitySlowDownIcon;

        public static Bootstrap Instance { get; set; }

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(this.gameObject);
        }

        private void Start()
        {
            _ticketValueText.text = _ticketValue.ToString();
        }
    }
}