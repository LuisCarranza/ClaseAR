using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyController : MonoBehaviour
{
    private DefaultTrackableEventHandler dte;
    public Animator oso;
    public Ray ray;

    // Start is called before the first frame update
    void Start()
    {
        dte = GetComponent<DefaultTrackableEventHandler>();
    }

    /*
    TODO: change raycaster to a new camera script and make functions here to
     send the triggers
     https://gamedevelopment.tutsplus.com/tutorials/introduction-to-vuforia-on-unity-for-creating-augmented-reality-applications--cms-27693
     
    */


    // Update is called once per frame
    void Update()
    {
        if (dte.isActive)
        {
            oso.SetTrigger("active");
        }
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hitInfo;
                Debug.Log("Generating ray: " + ray.ToString());
                if (Physics.Raycast(ray, out hitInfo))
                {
                    Debug.Log("Hit something!");
                    Debug.Log("Hit Info: " + hitInfo.ToString());
                    // var rig = hitInfo.collider.GetComponent<GameObject>();
                    // Debug.Log("Hit tag: " + rig.tag);
                    // if (rig.GetComponent<Animator>() != null)
                    // {
                    //     oso.SetTrigger("dead");
                    // }
                }
            }
        }
    }
}
