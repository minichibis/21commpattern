using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualObject : MonoBehaviour
{
	public List<Command> c;
	
    // Start is called before the first frame update
    void Start()
    {
        c = new List<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void Move(Vector3 v){
		transform.position += v;
	}
	
	public void Undo(){
		if(c.Count > 0){
			c[c.Count-1].Undo();
			c.RemoveAt(c.Count-1);
		}
	}
}
