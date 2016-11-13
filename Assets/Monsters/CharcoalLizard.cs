using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharcoalLizard : Monster {
	
	public override string speciesName {
		get {
			return "Charcoal Lizard";
		}
	}
	//override the element types, which CANNOT be modified.
	public override ElementType primaryType{
		get { 
			return ElementType.Fire; 
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
			return new Stats (94, 90, 50, 110, 85, 110, 100, 0);
		}
	}

	protected override void AddTestMove ()
	{
		//add move 1
		StatusEffect burnTenPercent = new StatusEffect (StatusType.Burn, 10, TargetingType.SingleEnemy);
		BattleMove newMove = new BattleMove ("Fire Blast", TargetingType.SingleEnemy, 125, 85, ElementType.Fire, burnTenPercent);
		moves [0] = newMove;

		//add move 2
		BattleMove newMove1 = new BattleMove ("Tackle", TargetingType.SingleEnemy, 40, 90, ElementType.Normal);
		moves [1] = newMove1;

		//add move 3
		BuffEffect lowerDefense = new BuffEffect(BuffType.defenseDown, 95, 50, TargetingType.SingleEnemy);
		BattleMove newMove2 = new BattleMove("Tail Whip", TargetingType.SingleEnemy, 0, 95, ElementType.Normal, lowerDefense);
		moves [2] = newMove2;

		//add move 4
		StatusEffect inflictBurn = new StatusEffect(StatusType.Burn, 100, TargetingType.SingleEnemy);
		BattleMove newMove3 = new BattleMove("Burn-o-Flame", TargetingType.SingleEnemy, 0, 75, ElementType.Fire, inflictBurn);
		moves [3] = newMove3;
	}
}
