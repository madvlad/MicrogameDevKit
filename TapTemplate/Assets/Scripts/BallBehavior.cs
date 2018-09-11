using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
    public AudioSource popSound;

	void Update () {
        if (Input.touchCount == 1)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector2 touchPos = new Vector2(wp.x, wp.y);
            if (gameObject.GetComponent<CircleCollider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                popSound.Play();
                GameObject.FindGameObjectWithTag("Manager").GetComponent<GameManager>().GetPop();
                Destroy(gameObject);
            }
        }
    }
}
