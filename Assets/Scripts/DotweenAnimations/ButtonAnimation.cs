using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace DotweenAnimations
{
    public class ButtonAnimation : MonoBehaviour, IPointerClickHandler
    {
        private Button _button;
        private RectTransform _rectTransform;
        public float disableShakeStrength = 3.5f;
        public float disableShakeDuration = 1f;
        public int disableShakeRepeatTime = 1;
        public Ease disableShakeEaseType = Ease.Linear;

        private void Start()
        {
            _button = GetComponent<Button>();
            _rectTransform = GetComponent<RectTransform>();
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            if (!_button.interactable)
                DisableButton();
        }

        private void AppendTweens(ref Sequence sequence, Tween[] tweens)
        {
            foreach (var tween in tweens)
            {
                sequence.Append(tween);
            }
        }

        private Tween[] ShakeButton(Vector3 rotateDir, float duration, Ease easeType)
        {
            Tween[] shakeButton = new Tween[3];
            shakeButton[0] = _rectTransform.DOLocalRotate(rotateDir, duration).SetEase(easeType);
            shakeButton[1] = _rectTransform.DOLocalRotate(-rotateDir, duration).SetEase(easeType);
            shakeButton[2] = _rectTransform.DOLocalRotate(Vector3.zero, duration).SetEase(easeType);

            return shakeButton;
        }

        private void DisableButton()
        {
            Sequence disableSequence = DOTween.Sequence();
            AppendTweens(ref disableSequence,
                ShakeButton(Vector3.forward * disableShakeStrength, disableShakeDuration, disableShakeEaseType));
            disableSequence.SetLoops(disableShakeRepeatTime).SetEase(disableShakeEaseType).Play();
        }
    }
}