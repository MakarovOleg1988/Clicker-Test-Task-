using UnityEngine;

namespace ClickerTestTask
{
    public class CommonButtonController : MonoBehaviour, IEventManager
    {
        public GameObject _playButton;
        public GameObject _chooseLevelPanel;
        public GameObject _settingPanel;
        public GameObject _storePanel;
        public GameObject _stopGameButton;
        public GameObject _spawnObj;

        public void TurnOnSettingPanel()
        {
            IEventManager.SetClickButton();
            _playButton.SetActive(false);
            _settingPanel.SetActive(true);
        }

        public void TurnOnStorePanel()
        {
            IEventManager.SetClickButton();
            _playButton.SetActive(false);
            _storePanel.SetActive(true);
        }

        public void TurnOnChooseLevelPanel()
        {
            IEventManager.SetClickButton();
            _playButton.SetActive(false);
            _chooseLevelPanel.SetActive(true);
        }

        public void BackToLobby()
        {
            IEventManager.SetClickButton();
            _playButton.SetActive(true);
            _chooseLevelPanel.SetActive(false);
            _storePanel.SetActive(false);
            _settingPanel.SetActive(false);
        }

        public void StartGame()
        {
            IEventManager.SetClickButton();
            _stopGameButton.SetActive(true);
            _chooseLevelPanel.SetActive(false);
            _spawnObj.GetComponent<SpawnCookies>().StartSpawnCookiesPrefab();
        }

        public void StopGame()
        {
            IEventManager.SetClickButton();
            _stopGameButton.SetActive(false);
            _spawnObj.GetComponent<SpawnCookies>().CancelSpawnCookiesPrefab();
        }
    }
}
