using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Command
{
	public Vector3 v;
	public ActualObject j;
	
    public void Do(){
		j.Move(v);
		j.c.Add(this);
	}
	
	public void Undo(){
		j.Move(v * -1);
	}
}
