using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
public class State : MonoBehaviour {

    public string name;

    SpriteRenderer _renderer;
    SpriteRenderer renderer
    {
        get
        {
            if (_renderer == null)
                _renderer = GetComponent<SpriteRenderer>();
            return _renderer;
        }
    }

    bool _activated;
    public bool activated
    {
        get
        {
            return _activated;
        }
    }

    void SetActivated(bool activate, bool sound)
    {
        _activated = activate;
        renderer.enabled = activate;
        PlayerPrefs.SetInt(name, activate ? 1 : 0);
        if (activate && sound)
            PlayActivationSound();
        if (activate)
        {
            StateCounter.instance.Increase();
        }
        else
        {
            if (sound)
             StateCounter.instance.Decrease();
        }
    }

    void Start()
    {
        SetActivated(PlayerPrefs.GetInt(name, 0) > 0, false);
    }
	
	void OnMouseDown () 
    {
        SetActivated(!activated, true);
	}

    void PlayActivationSound()
    {
        StateMap.instance.PlayActivationSound();
    }
	
}
