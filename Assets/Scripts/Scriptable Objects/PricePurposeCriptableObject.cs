using UnityEngine;

namespace ClickerTestTask
{
    [CreateAssetMenu(fileName = "Price.asset", menuName ="Resources/Create Price")]
    public class PricePurposeCriptableObject: ScriptableObject
    {
        public int[] _pricePurposeValue;
    }
}