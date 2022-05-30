using UnityEngine;
using UnityEngine.UI;

namespace Popup.Quest_Reward
{
    public class QuestRewardPopupController : PopupController
    {
        public int gemQuantity;
        public int coinQuantity;
        public Text textGemQuantity;
        public Text textCoinQuantity;

        public void Initial(int gemQuantity, int coinQuantity)
        {
            this.gemQuantity = gemQuantity;
            this.coinQuantity = coinQuantity;
            transform.localScale = Vector3.zero;

            textGemQuantity.text = this.gemQuantity.ToString();
            textCoinQuantity.text = this.coinQuantity.ToString();
        }
    }
}