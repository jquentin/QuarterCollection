using UnityEngine;
using System.Collections;

public class StateCounter : MonoBehaviour {

    static StateCounter _instance;
    public static StateCounter instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<StateCounter>();
            return _instance;
        }
    }

    TextMesh _textMesh;
    TextMesh textMesh
    {
        get
        {
            if (_textMesh == null)
                _textMesh = GetComponent<TextMesh>();
            return _textMesh;
        }
    }

    int count = 0;

	public void Increase () 
    {
        count++;
        UpdateLabel();
	}

    public void Decrease () 
    {
        count--;
        UpdateLabel();
    }

    void UpdateLabel()
    {
        textMesh.text = count.ToString();
    }
	
}
