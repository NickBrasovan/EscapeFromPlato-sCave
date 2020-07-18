using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelotAnimationController : MonoBehaviour
{
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
 //      if(Input.GetKeyUp(KeyCode.Space))
 //      {
 //          anim.SetTrigger("RaiseHands");
 //      }

 //      if(Input.GetKey(KeyCode.Space))
 //      {
 //          anim.SetBool("HandsRaised", true);
 //
 //      }
 //      else 
 //      { 
 //          anim.SetBool("HandsRaised", false); 
 //      }
    }

    public void RaiseHands()
    {
        anim.SetBool("HandsRaised", true);
    }

    public void LowerHands()
    {
        anim.SetBool("HandsRaised", false);
    }

}
