using DG.Tweening;
using UnityEngine;

namespace DotweenAnimations
{
    public class PopupAnimation : MonoBehaviour
    {
        public float duration;
        public Ease easeType;
        private RectTransform _rectTransform;
        private void Start()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        public void OpenPopup()
        {
            _rectTransform.DOScale(1f, duration).SetEase(easeType);
        }
    
        public void ClosePopup()
        {
            _rectTransform.DOScale(0f, duration).SetEase(easeType);
        }
    }
}
