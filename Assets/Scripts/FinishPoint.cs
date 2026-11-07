using UnityEngine;

public class FinishPoint : MonoBehaviour
{


    public GameObject finishedUI;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        //Win
           finishedUI.SetActive(true);
    }
    
}
