using UnityEngine;
using UnityEngine.UI;

namespace Popup.Quest_Reward
{
    [RequireComponent(typeof(Button))]
    public class OpenQuestRewardPopup : MonoBehaviour, IOpenPopup
    {
        public QuestRewardPopupController questRewardPopupController;
        [Range(20,100)]
        public int gemQuantityRange;
        [Range(1000,6000)]
        public int coinQuantityRange;
        private int _gemQuantity;
        private int _coinQuantity;
        public Vector3 openPos;
        private Button _button;

        private void Start()
        {
            InitialPopup();
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Open);
        }

        private void Update()
        {
            _button.interactable = !questRewardPopupController.isOPen;
        }

        public void InitialPopup()
        {
            _gemQuantity = Random.Range(1000, gemQuantityRange);
            _coinQuantity = Random.Range(1000, coinQuantityRange);
            questRewardPopupController.Initial(_gemQuantity, _coinQuantity);
        }

        public void Open()
        {
            InitialPopup();
            questRewardPopupController.Open(openPos);
        }
    }
}