using UnityEngine;

namespace DefaultNamespace.UI
{
    public class ShopWindow : MonoBehaviour
    {
        [SerializeField] public RectTransform _content;
        [SerializeField] private GameObject _buttonPrefab;
        [SerializeField] private int minNumButton = 5;
        [SerializeField] private int maxNumButton = 20;
        
        private void Start()
        {
            var numButton = Random.Range(minNumButton, maxNumButton + 1);

            for (var i = 0; i < numButton; i++)
            {
                Instantiate(_buttonPrefab, _content);
            }
        }
    }
}