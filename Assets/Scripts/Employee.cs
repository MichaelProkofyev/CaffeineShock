using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Employee : MonoBehaviour {

    public Transform desk;
    NavMeshAgent m_agent;
    EState State
    {
        get { return state; }
        set {
            switch (state)
            {
                case EState.WORKING:
                    
                    break;
                case EState.AT_MACHINE:
                    break;
                case EState.TO_MACHINE:
                    break;
                case EState.TO_WORK:
                    break;
                default:
                    break;
            }
        }
    }
    private EState state;

    enum EState
    {
        WORKING,
        AT_MACHINE,
        TO_MACHINE,
        TO_WORK,
    }


    // Use this for initialization
    void Start () {
        m_agent = GetComponent<NavMeshAgent>();

    }

    IEnumerator SwitchToState(EState newState, float delay)
    {
        yield return new WaitForSeconds(delay);
        State = newState;
    }
    

    // Update is called once per frame
    void Update () {
        if (m_agent.pathPending || m_agent.remainingDistance > 0.1f)
            return;


        //S
        switch (state)
        {
            case EState.WORKING:
                break;
            case EState.AT_MACHINE:
                break;
            case EState.TO_MACHINE:
                break;
            case EState.TO_WORK:
                break;
            default:
                break;
        }
    }
}
