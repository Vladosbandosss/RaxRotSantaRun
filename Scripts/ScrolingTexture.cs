using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrolingTexture : MonoBehaviour
{
   
   
    [SerializeField] public bool   Isscrool = true;
    [SerializeField] float scrollSpeed;
     Material backGroundMaterial;
    private void Awake()
    {
        
        backGroundMaterial = GetComponent<Renderer>().material;
    }
 
     void FixedUpdate()
    {
        if (Isscrool)
        {
            Vector2 offset = new Vector2(scrollSpeed * Time.deltaTime, 0);
            backGroundMaterial.mainTextureOffset += offset;
        }
        
    }
}
