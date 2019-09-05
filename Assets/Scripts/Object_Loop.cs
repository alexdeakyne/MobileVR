using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Loop : MonoBehaviour {
    private int currFrame = 0;
    private Transform[] allChildren;
    private float timeLog;
    public float refreshRate = 2.5f/30f;

	// Use this for initialization
	void Start () {
        allChildren = new Transform[transform.childCount];
        int i = 0;
        foreach(Transform child in transform)
        {
            allChildren[i] = child;
            i++;

        }
        allChildren[0].gameObject.SetActive(true);
        for (i = 1; i < transform.childCount; i++)
        {
            allChildren[i].gameObject.SetActive(false);
        }


    }
	
	// Update is called once per frame
	void Update () {
        timeLog = timeLog + Time.deltaTime;
        if (refreshRate < timeLog)
        {
            allChildren[currFrame].gameObject.SetActive(false);
            currFrame = (currFrame + 1) % transform.childCount;
            allChildren[currFrame].gameObject.SetActive(true);
            timeLog = 0.0f;
        }
		
	}
}
