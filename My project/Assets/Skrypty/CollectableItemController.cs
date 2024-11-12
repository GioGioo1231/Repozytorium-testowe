using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItemController : MonoBehaviour
{
    public PlayerController playerController;
    public AudioSource audioSource;
    public AudioClip audioclip;

    public MeshRenderer meshRenderer;
    public CapsuleCollider capsuleCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        meshRenderer = GetComponent<MeshRenderer>();
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerController.zebranePunkty++;
            Debug.Log(playerController.zebranePunkty);

            audioSource.PlayOneShot(audioclip);

            meshRenderer.enabled = false;
            capsuleCollider.enabled = false;
        }
    }
}

