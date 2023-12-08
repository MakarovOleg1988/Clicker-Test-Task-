using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ClickerTestTask
{
    public class ClickSystem : MonoBehaviour, IPointerClickHandler
    {
        private TextMeshProUGUI _ticketValueText;

        private void Start()
        {
            _ticketValueText = GameObject.Find("Ticket Value Text").GetComponent<TextMeshProUGUI>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (Bootstrap.Instance._powerupX2Ticket == true)
            {
                Bootstrap.Instance._ticketValue += 2;
            }
            else if(Bootstrap.Instance._powerupX2Ticket == false)
            {
                Bootstrap.Instance._ticketValue += 1;
            }

            _ticketValueText.text = Bootstrap.Instance._ticketValue.ToString();
            Destroy(this.gameObject);
        }
    }
}