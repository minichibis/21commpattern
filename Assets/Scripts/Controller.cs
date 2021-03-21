using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
	public ControlSetter c;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
			c.MakeCommand(1);
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			c.MakeCommand(2);
		}else if(Input.GetKeyDown(KeyCode.LeftArrow)){
			c.MakeCommand(3);
		}else if(Input.GetKeyDown(KeyCode.UpArrow)){
			c.MakeCommand(4);
		} else if(Input.GetKeyDown(KeyCode.Z)){
			c.MakeCommand(5);
		}
    }
}
