using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class TweenTest : MonoBehaviour
{
    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        sequence = DOTween.Sequence();
        sequence.Append(transform.DOMoveX(5, 1));
        sequence.SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void TweenEnd()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            sequence.Kill();


        }
    }
}
