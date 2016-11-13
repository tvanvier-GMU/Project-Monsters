using UnityEngine;
using System.Collections;

public class VineDinosaur : Monster {

	public override string speciesName {
		get {
			return "Vine Dinosaur";
		}
	}

	//override the element types, which CANNOT be modified.
	public override ElementType primaryType{
		get { 
			return ElementType.Grass; 
		}
	}
	public override ElementType secondaryType{
		get{ 
			return ElementType.None; 
		}
	}

	//override the base stats, which are fixed for each species.
	public override Stats baseStats {
		get {
			return new Stats (80, 82, 83, 100, 100, 80, 100, 0);
		}
	}

	protected override void AddTestMove ()
	{
		//add vine whip
		BattleMove newMove = new BattleMove ("Vine Whip", TargetingType.SingleEnemy, 50, 100, ElementType.Grass);
		moves [0] = newMove;
		//Debug.Log(newMove.ToString());
		//Debug.Log(moves[0]);
	}
		
}
