using UnityEngine;
using System.Collections;

public class Shockwave : MonoBehaviour {

    float lerpTime = 1f;
    float currentLerpTime;

    float moveDistance = 10f;

    Vector3 startPos;
    Vector3 endPos;
    void OnTriggerEnter2D(Collider2D coll)
    {

        if (coll.gameObject.GetComponent<Bullet_enemie>())
        {
            Destroy(coll.gameObject);

        }
        else if (coll.gameObject.GetComponent<Health>())
        {
            coll.GetComponent<Health>().Damage(50);

        }
        //else if(coll.gameObject.GetComponent<AsteroidCollision>())
    }
    protected void Start()
    {
        startPos = transform.localScale;
        endPos = transform.position + transform.up * moveDistance;
        Destroy(this.gameObject, 1f);
    }

    protected void Update()
    {
     

        //increment timer once per frame
        currentLerpTime += Time.deltaTime;
        if (currentLerpTime > lerpTime)
        {
            currentLerpTime = lerpTime;
        }

        //lerp!
        float perc = currentLerpTime / lerpTime;
        transform.localScale = Vector3.Lerp(startPos, new Vector3(10f,10f,0), perc);
    }
}
