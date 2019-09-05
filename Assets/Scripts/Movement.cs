using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 15F;
    public GameObject player;

    void Update()
    {
        if (GvrControllerInput.IsTouching && GvrControllerInput.ClickButton)
        {
            print("touch");
            Vector2 touchPos = GvrControllerInput.TouchPos;
            float velocityZ = (1 - (touchPos.y * 2f)) * .2f;
            player.transform.Translate(velocityZ * transform.forward * speed * Time.deltaTime, Space.World);
        }
    }
}