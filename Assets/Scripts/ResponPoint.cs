using UnityEngine;

public class ResponPoint : MonoBehaviour
{

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Instantiate(player, gameObject.transform.position, player.transform.rotation);
    }
}
