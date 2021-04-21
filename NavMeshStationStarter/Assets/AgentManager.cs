using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents; //Array de gameobjects
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai"); //Encontra gameobjects com a tag "ai" na scene
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //Condicional para o click do mouse
        {
            RaycastHit hit;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) //Caso o raycast atinja um local em uma distancia de 100, o agent se move até o local
            {
                foreach (GameObject a in agents)
                {
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point); //Pega o component da classe AIControl
                }
            }
        }
    }
}
