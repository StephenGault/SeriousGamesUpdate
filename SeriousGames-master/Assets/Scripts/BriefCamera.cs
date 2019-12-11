using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BriefCamera : MonoBehaviour
{
    Animation anim;
    private void Start()
    {
        anim = this.GetComponent<Animation>();
    }
    public void PlayerCamera()
    {
        anim.Play("playerselect");
    }

    public void ReturnCamera()
    {
        anim.Play("RETURNTOBASECAMERA");
    }
}
