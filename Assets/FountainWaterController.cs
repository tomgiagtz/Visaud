using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class FountainWaterController : MonoBehaviour
{

    public float floodTime = 3f;
    public float delayTime;
    public float maxSize = 3f;

    public Vector3 startScale, endScale;
    void Awake() {
        transform.localScale = startScale;
    }

    public void AnimateWater(Action onComplete = null) {
        Tween.LocalScale(transform, endScale, floodTime, delayTime, null, Tween.LoopType.None, null, onComplete);
    }
}
