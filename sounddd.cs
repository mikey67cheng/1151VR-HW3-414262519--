using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        // 取得同一個物件上的 Audio Source 元件
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 當檢測到滑鼠點擊時播放音效（條件與你的輪盤旋轉相同）
        if (Input.GetMouseButtonDown(0))
        {
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}