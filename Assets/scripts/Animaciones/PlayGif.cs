using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGif : MonoBehaviour
{
    public Sprite[] gifFrames;
    public float frameDelay = 0.1f;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(PlayGifCoroutine());
    }

    IEnumerator PlayGifCoroutine()
    {
        while (true)
        {
            for (int i = 0; i < gifFrames.Length; i++)
            {
                spriteRenderer.sprite = gifFrames[i];
                yield return new WaitForSeconds(frameDelay);
            }
        }
    }
}
