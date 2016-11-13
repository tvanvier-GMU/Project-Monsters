using UnityEngine;
using System.Collections;

public class ExampleBase : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void HelloVirtual(){
		print ("Hello from the base class!");
	}

}

public abstract class ExampleAbstract : MonoBehaviour {
	public int testMemberVariable = 5;
	private int test;
	public abstract int testProperty{ get; set;}
	public abstract int unchangingProperty{ get; }
	public abstract void Buzz ();
	public virtual void TestVirtual(){
		Debug.Log ("printed from ExampleAbstract class");
	}

}
