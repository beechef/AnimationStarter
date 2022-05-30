using DotweenAnimations;
using UnityEngine;

namespace Popup
{
    [RequireComponent(typeof(PopupAnimation))]
    public class PopupController : MonoBehaviour
    {
        private PopupAnimation _popupAnimation;
        private RectTransform _rectTransform;
        [HideInInspector] public bool isOPen;
        private void Start()
        {
            _popupAnimation = GetComponent<PopupAnimation>();
            _rectTransform = GetComponent<RectTransform>();
            isOPen = false;
        }
    
        public virtual void Open(Vector3 position)
        {
            _rectTransform.localPosition = position;
            _popupAnimation.OpenPopup();
            isOPen = true;
        }

        public virtual void Close()
        {
            _popupAnimation.ClosePopup();
            isOPen = false;
        }
    }

    public enum PopupType
    {
        QuestReward
    }
}