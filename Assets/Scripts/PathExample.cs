using UnityEngine;
using System.Collections;

public class PathExample : MonoBehaviour{
	public Transform[] path;
    public float loopTime = 10;

    void Start(){
		tween();
	}
	
	void OnDrawGizmos(){
		iTween.DrawPath(path);
	}
	
	void tween(){
		iTween.MoveTo(gameObject,iTween.Hash("path",path,"time",loopTime,"orienttopath",true,"looktime",.6,"easetype","easeInOutSine","oncomplete","complete"));	
	}
	
	void complete(){
		tween();
	}
}

