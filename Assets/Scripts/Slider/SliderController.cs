using DotweenAnimations;
using UnityEngine;

namespace Slider
{
    [RequireComponent(typeof(SliderAnimation))]
    public class SliderController : MonoBehaviour
    {
        private SliderAnimation _sliderAnimation;
        private int _maxValue;
        private UnityEngine.UI.Slider _slider;

        private void Start()
        {
            _sliderAnimation = GetComponent<SliderAnimation>();
            _slider = GetComponent<UnityEngine.UI.Slider>();
            _slider.value = 0;
        }

        public void SetMaxValue(int maxValue)
        {
            _sliderAnimation.SetMaxValue(maxValue);
            _maxValue = maxValue;
        }

        public void UpdateSlider(float value)
        {
            _sliderAnimation.UpdateSlider(value, _maxValue);
        }
    }
}
