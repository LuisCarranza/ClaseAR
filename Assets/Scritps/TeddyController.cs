using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyController : MonoBehaviour
{
    private DefaultTrackableEventHandler dte;
    public Animator oso;
    // Start is called before the first frame update
    void Start()
    {
        dte = GetComponent<DefaultTrackableEventHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dte.isActive)
        {
            oso.SetTrigger("active");
        }
    }
}
