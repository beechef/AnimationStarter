
namespace DotweenAnimations
{
    using DG.Tweening;
    using UnityEngine;
    using UnityEngine.UI;
    [RequireComponent(typeof(Slider))]
    public class SliderAnimation : MonoBehaviour
    {
        public Text currentValueText;
        public Text maxValueText;

        public float duration;
        public Ease easeType;
        private Slider _slider;
        private Tween _currentTween;
        private void Start()
        {
            _slider = GetComponent<Slider>();
        }

        public void SetMaxValue(float maxValue)
        {
            maxValueText.text = maxValue.ToString();
        }
        public void UpdateSlider(float value, float maxValue)
        {
            value += _slider.value * maxValue;
            _slider.DOValue((value / maxValue), duration).SetEase(easeType).OnUpdate(
                () =>
                {
                    currentValueText.text = Mathf.RoundToInt(_slider.value * maxValue).ToString();
                }).Play();
        }
    }
}