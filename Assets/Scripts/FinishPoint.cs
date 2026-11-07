using UnityEngine;

public class FinishPoint : MonoBehaviour
{

   private void OnCollisionEnter2D(Collision2D collision)
    {
        //Win
        Debug.Log("win");
    }
    
}
