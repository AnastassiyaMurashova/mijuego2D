using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {
    public float speed;
    public int startingPoint;
    public Transform[] points;

    private int pointIndex;

    void Start() {
        transform.position = points[pointIndex].position;
    }
    private void Update() {
        if (Vector2.Distance(transform.position, points[pointIndex].position) >= 0.02f) return;
        if (++pointIndex == points.Length)  pointIndex = 0;
        transform.position = Vector2.MoveTowards(transform.position, points[pointIndex].position, speed * Time.deltaTime);
    }

}
