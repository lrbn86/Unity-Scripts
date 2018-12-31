     using UnityEngine;
     
     public class ConveyorBelt : MonoBehaviour {
     
         public float speed = 20f;
         bool on = true;
         Vector2 offset = new Vector2(0f,0f);
         
     
      
     
         void OnCollisionStay(Collision obj ){
             float beltVelocity = speed * Time.deltaTime;
             GetComponent<Rigidbody>().velocity = beltVelocity * transform.forward; 
         }
     
         void Update(){
             offset += new Vector2(0,0.1f) * Time.deltaTime;
             GetComponent<Renderer>().material.SetTextureOffset ("_MainTex", offset);
         }
     }