using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ClickerTestTask
{
    public class ClickSystem : MonoBehaviour, IEventManager, IPointerClickHandler
    {
        private TextMeshProUGUI _ticketValueText;

        private void Start()
        {
            _ticketValueText = GameObject.Find("Ticket Value Text").GetComponent<TextMeshProUGUI>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (Bootstrap.Instance._powerupX2Ticket == true) Bootstrap.Instance._ticketValue += 2;
            else if(Bootstrap.Instance._powerupX2Ticket == false) Bootstrap.Instance._ticketValue += 1;

            gameObject.GetComponentInChildren<ParticleSystem>().Play();

            IEventManager.SetEatCookiesButton();
            _ticketValueText.text = Bootstrap.Instance._ticketValue.ToString();

            StartCoroutine(DestroyCookie());
        }

        private IEnumerator DestroyCookie()
        {
            gameObject.GetComponentInChildren<ParticleSystem>().Play();
            yield return new WaitForSeconds(0.3f);
            Destroy(this.gameObject);
        }
    }
}