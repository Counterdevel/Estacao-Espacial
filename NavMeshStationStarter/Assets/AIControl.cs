using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent; //Variavel do tipo NAvMeshAgent
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>(); //Pega o componente de NAvMeshAgent
    }

}
