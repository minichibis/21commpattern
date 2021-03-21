using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSetter : MonoBehaviour
{
	public ActualObject a;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	public void MakeCommand(int type){
		if(type == 5){
			a.Undo();
		}else{
			Move m = new Move();
			m.j = a;
			if(type == 1){
				m.v = new Vector3(1,0,0);
			}else if(type == 2){
				m.v = new Vector3(0,-1,0);
			}else if(type == 3){
				m.v = new Vector3(-1,0,0);
			}else if(type == 4){
				m.v = new Vector3(0,1,0);
			}
			m.Do();
		}
	}
}
