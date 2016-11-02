using UnityEngine;
using System.Collections;

public class StateMap : MonoBehaviour {

    static StateMap _instance;
    public static StateMap instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<StateMap>();
            return _instance;
        }
    }

    public AudioClip activationSound;
    public AudioSource audioSource;

    public void PlayActivationSound()
    {
        audioSource.PlayOneShot(activationSound);
    }
}
