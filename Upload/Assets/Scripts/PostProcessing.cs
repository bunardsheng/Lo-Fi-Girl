using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;


public class PostProcessing : MonoBehaviour
{
    public PostProcessVolume ppv;

    // Start is called before the first frame update
    void Start()
    {
        ppv.weight = 1;
        Messenger.AddListener(GameEvent.EVENT_0, BWtoMuted);
        Messenger.AddListener(GameEvent.EVENT_1, MutedtoFull);
    }

    // Update is called once per frame


    IEnumerator Fade(float start, float end)
    {
        for (float ft = 0; ft <= 1; ft += Time.deltaTime)
        {
            ppv.weight = Mathf.Lerp(start, end, ft);
            yield return null;
        }
    }

    void BWtoMuted()
    {
        StartCoroutine(Fade(1, 0.7f));
    }
    void MutedtoFull()
    {
        StartCoroutine(Fade(0.7f, 0));
    }


}
