using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class EaseMove : MonoBehaviour
{
    public Ease easeType;
    public bool move;
    public bool reset;
    private RectTransform _rectTransform;
    private Vector3 _pos;
    private void Start()
    {
        _rectTransform = GetComponent<RectTransform>();
        _pos = _rectTransform.localPosition;
    }

    private void Update()
    {
        if (move)
        {
            move = false;
            _rectTransform.DOMoveX(500, 1.25f).SetEase(easeType);
        }

        if (reset)
        {
            reset = false;
            _rectTransform.localPosition = _pos;
        }
    }
}
