using UnityEngine;
using UnityEngine.UI;

namespace Popup.Quest_Reward
{
    [RequireComponent(typeof(Button))]
    public class CloseQuestRewardPopup : MonoBehaviour, IClosePopup
    {
        public QuestRewardPopupController questRewardPopupController;
        public bool isCollect;
        private Button _button;

        private void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(Close);
        }

        public void Close()
        {
            if (!isCollect)
            {
                questRewardPopupController.Close();
                return;
            }
            if (ConcurrencyController.Instance.AddConcurrency(questRewardPopupController.gemQuantity,
                questRewardPopupController.coinQuantity))
                questRewardPopupController.Close();
            else
                Debug.Log("Maximum Value!");
        }
    }
}