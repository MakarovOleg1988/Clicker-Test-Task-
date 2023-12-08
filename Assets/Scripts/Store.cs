using TMPro;
using UnityEngine;

namespace ClickerTestTask
{
    public class Store : MonoBehaviour
    {
        [SerializeField]
        public TextMeshProUGUI[] _pricePurposeText;

        [SerializeField]
        private GameObject[] _lockPurpose;

        [SerializeField]
        private PricePurposeCriptableObject _pricePurposeCriptableObject;

        private void Start()
        {
            SetPrice();
        }

        public void SetPrice()
        {
            for (int i = 0; i < _pricePurposeText.Length; i++)
            {
                _pricePurposeText[i].text = $"Required {_pricePurposeCriptableObject._pricePurposeValue[i]}";
            }
        }

        private void Update()
        {
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[0]) _lockPurpose[0].SetActive(false);
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[1]) _lockPurpose[1].SetActive(false);
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[2]) _lockPurpose[2].SetActive(false);
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[3]) _lockPurpose[3].SetActive(false);
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[4]) _lockPurpose[4].SetActive(false);
            if (Bootstrap.Instance._ticketValue >= _pricePurposeCriptableObject._pricePurposeValue[5]) _lockPurpose[5].SetActive(false);
        }

        public void ActivePowerup()
        {
            if (Bootstrap.Instance._ticketValue > _pricePurposeCriptableObject._pricePurposeValue[0])
            {
                Bootstrap.Instance._powerupX2Ticket = true;
                Bootstrap.Instance._ticketValue -= _pricePurposeCriptableObject._pricePurposeValue[0];
                Bootstrap.Instance._ticketValueText.text = Bootstrap.Instance._ticketValue.ToString();
                Bootstrap.Instance._powerupX2TicketIcon.SetActive(true);
            }
        }
    }
}