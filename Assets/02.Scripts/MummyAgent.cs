using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;

public class MummyAgent : Agent
{
    private Rigidbody rb;
    private Transform tr;

    public float moveSpeed = 1.5f;
    public float turnSpeed = 200.0f;

    public StageManager stageManager;
    public Renderer floorRd;
    private Material originMt;

    public Material goodMt, badMt;

    public override void Initialize()
    {
        MaxStep = 100;
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();

        rb.velocity = rb.angularVelocity = Vector3.zero;
    }

    public override void OnEpisodeBegin()
    {
        tr.localPosition = new Vector3(0, 0.05f, -4.5f);
        tr.localRotation = Quaternion.identity;
        stageManager.InitStage();
    }

}
