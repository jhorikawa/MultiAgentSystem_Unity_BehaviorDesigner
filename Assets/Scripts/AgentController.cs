using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour {
    public int numberAgentA;
    public int numberAgentB;

    public GameObject prefabAgentA;
    public GameObject prefabAgentB;


	// Use this for initialization
	void Start () {
        Vector3 size = transform.localScale;

        for(int i=0; i<numberAgentA; i++)
        {
            GameObject instanceAgentA = (GameObject)Instantiate(prefabAgentA);
            instanceAgentA.transform.position = new Vector3(Random.Range(-size.x * 10f, size.x * 10f), 0, Random.Range(-size.z * 10f, size.z * 10f));

        }

        for (int i = 0; i < numberAgentB; i++)
        {
            GameObject instanceAgentB = (GameObject)Instantiate(prefabAgentB);
            instanceAgentB.transform.position = new Vector3(Random.Range(-size.x * 10f, size.x * 10f), 0, Random.Range(-size.z * 10f, size.z * 10f));

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
