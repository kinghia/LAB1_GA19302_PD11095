using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoController : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _sol, _la, _si;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("sol").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Press A");
            _do.Play();
        }        
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Press S");
            _re.Play();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Press D");
            _mi.Play();
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Press F");
            _fa.Play();
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log("Press G");
            _sol.Play();
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Press H");
            _la.Play();
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("Press J");
            _si.Play();
        }
    }
}
