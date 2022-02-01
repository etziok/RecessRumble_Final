using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{


    public Animator animator;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    
    
    public void destroyme (){
    
    Destroy(gameObject, 1f);
    
    
    
    }
    
    
    public void FadeOut()
    {
         // Invoke("FadeIn");   
        animator.Play ("FadeIn");
    }
    
   


}
