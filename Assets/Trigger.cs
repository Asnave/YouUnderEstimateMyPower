using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public GameObject timeline;
    public GameObject mainCamera;
    public GameObject player;

    public bool OneTimeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            player.SetActive(false);
            mainCamera.SetActive(true);
            timeline.SetActive(true);

            if (OneTimeTrigger == true)
            {
                Destroy(this.gameObject);
            }

        }
    }
}
