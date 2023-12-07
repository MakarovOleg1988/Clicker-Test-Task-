using UnityEngine;

namespace ClickerTestTask
{
    public class StartupLevel: MonoBehaviour
    {
        [SerializeField]
        private GameObject _chooseLevelPanel;
        [SerializeField]
        private GameObject _spawnObj;



        public void Level()
        {
            _chooseLevelPanel.SetActive(false);
            _spawnObj.SetActive(true);
        }
    }
}