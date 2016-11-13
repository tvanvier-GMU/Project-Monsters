using UnityEngine;
using System.Collections;

public class ExampleChild : ExampleBase {

	// Use this for initialization
	void Start () {
		HelloVirtual ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void HelloVirtual(){
		//print ("Overrided HelloVirtual. This is the child.");
	}
}

public class ExampleAbstractChild : ExampleAbstract {
	new private int test;
	public override int testProperty {
		get {
			return testProperty;
		}
		set {
			test = value;
		}
	}

	public override int unchangingProperty {
		get {
			return 100;
		}
	}

	// Use this for initialization
	void Start () {
		testProperty = 4;
		//unchangingProperty = 20;
		Debug.Log (testProperty);
		Debug.Log ("Read Only Property: " + unchangingProperty.ToString());
	}

	// Update is called once per frame
	void Update () {
		
	}

	public override void Buzz ()
	{
		print ("I was forced to override buzz because it is abstract.");
	}


}