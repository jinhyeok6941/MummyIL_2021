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

}
