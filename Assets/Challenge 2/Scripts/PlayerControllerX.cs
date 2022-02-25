using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spamDogDelay = 0.5f;
    private bool goForDog = true;

    void Start() => InvokeRepeating("GoForDog", 0, spamDogDelay);

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && goForDog)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            goForDog = false;
        }
    }

    void GoForDog() => goForDog = true;
}