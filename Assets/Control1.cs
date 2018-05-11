using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Control1 : MonoBehaviour
{

    public static MonoBehaviour Global;
    bool state = true;
    public static ParticleSystem spawn;

    // Use this for initialization
    void Start()
    {
        Global = GameObject.Find("Global").GetComponent<MonoBehaviour>();
        spawn = GameObject.Find("Sand Particle11").GetComponent<ParticleSystem>();
        Invoke("Toggle", 2f);
        
    }

    public void Toggle()
    {
        spawn.Play();
        Invoke("Disable", 0.5f);
        state = !state;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = state;
        Invoke("Toggle", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                StartCoroutine(ScaleMe(hit.transform));
                if (hit.transform.name == gameObject.name)
                {
                    //Do ya thing
                    if (state)
                    {
                        gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
                        state = false;
                        Global.SendMessage("IncreaseScore", 1);
                    }
                    else
                    {
                        Global.SendMessage("DecreaseLive", 1);
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (state)
            {
                gameObject.GetComponentInChildren<MeshRenderer>().enabled = false;
                state = false;
                Global.SendMessage("IncreaseScore", 1);
            }
            else
            {
                Global.SendMessage("DecreaseLive", 1);
            }
        }
    }

    IEnumerator ScaleMe(Transform objTr)
    {
        //objTr.localScale *= 1.2f;
        yield return new WaitForSeconds(0.5f);
        //objTr.localScale /= 1.2f;
    }

    IEnumerator Disable(Transform objTr)
    {
        //objTr.localScale *= 1.2f;
        spawn.Pause();
        yield return new WaitForSeconds(0.5f);
        //objTr.localScale /= 1.2f;
    }
}
