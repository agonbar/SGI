using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Control2 : MonoBehaviour
{

    public static MonoBehaviour Global;
    bool state = true;

    // Use this for initialization
    void Start()
    {
        Global = GameObject.Find("Global").GetComponent<MonoBehaviour>();
        Invoke("Toggle", 3f);
    }

    public void Toggle()
    {
        state = !state;
        gameObject.GetComponentInChildren<MeshRenderer>().enabled = state;
        Invoke("Toggle", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                StartCoroutine(ScaleMe(hit.transform));
                Debug.Log("You selected the " + hit.transform.name);
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
        if (Input.GetKeyDown(KeyCode.Z))
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
}
