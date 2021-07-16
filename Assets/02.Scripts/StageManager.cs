using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public enum HINT_COLOR
    {
        BLACK, BLUE, GREEN, RED
    }

    public HINT_COLOR hintColor = HINT_COLOR.BLACK;

    public Material[] hintMt;
    public string[] hintTag;

    private int prevTag = -1;
    private new Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        renderer = transform.Find("Hint").GetComponent<MeshRenderer>();
        InitStage();
    }

    public void InitStage()
    {
        int idx = 0;
        do
        {
            idx = Random.Range(0, hintTag.Length);
        } while (idx == prevTag);
        prevTag = idx;

        renderer.material = hintMt[idx];
        renderer.gameObject.tag = hintTag[idx];
        // 목표타겟의 색상을 지정
        hintColor = (HINT_COLOR)idx;
    }
}
