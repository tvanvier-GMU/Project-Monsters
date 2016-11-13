using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BattleMove {
	
	public string attackName;
	public int baseDamage;
	public int baseAccuracy;
	public ElementType element;
	public TargetingType targetingType = TargetingType.SingleEnemy;

	public StatusEffect[] statusEffects;
	public BuffEffect[] buffEffects;
	public List<int> secondaryEffectChance;

	public override string ToString ()
	{
		string statusList = "";
		string buffList = "";
		if (statusEffects != null && statusEffects.Length > 0 ) {
			foreach (StatusEffect status in statusEffects) {
				statusList += (status.ToString ());
			}
		} else {
			statusList = "none";
		}

		if (buffEffects != null && buffEffects.Length > 0) {
			foreach (BuffEffect effect in buffEffects) {
				buffList += (effect.ToString ());
			}
		} else {
			buffList = "none";
		}

		return string.Format ("{0}\nBaseDamage: {1}\nBaseAccuracy: {2}\nElement: {3}\nStatusEffects: {4}\nSecondaryEffects: {5}", 
			attackName, baseDamage, baseAccuracy, element.ToString(), statusList, buffList);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BattleMove"/> class WITHOUT status effects or secondary effects.
	/// </summary>
	public BattleMove(string Name, TargetingType HitTarget, int BaseDamage, int MoveAccuracy, ElementType Element){
		attackName = Name;
		baseDamage = BaseDamage;
		baseAccuracy = MoveAccuracy;
		element = Element;
		targetingType = HitTarget;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BattleMove"/> class with a chance of multiple types of Status Effects
	/// </summary>
	public BattleMove(string Name, TargetingType HitTarget, int BaseDamage, int MoveAccuracy, ElementType Element, params StatusEffect[] StatusEffects){
		attackName = Name;
		baseDamage = BaseDamage;
		baseAccuracy = MoveAccuracy;
		element = Element;
		statusEffects = StatusEffects;
		targetingType = HitTarget;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BattleMove"/> class with a chance of multiple types of Secondary Effects
	/// </summary>
	public BattleMove(string Name, TargetingType HitTarget, int BaseDamage, int MoveAccuracy, ElementType Element, params BuffEffect[] BuffEffects){
		attackName = Name;
		baseDamage = BaseDamage;
		baseAccuracy = MoveAccuracy;
		element = Element;
		buffEffects = BuffEffects;
		targetingType = HitTarget;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BattleMove"/> class with a chance of only one type of status effect.
	/// </summary>
	public BattleMove(string Name, TargetingType HitTarget, int BaseDamage, int MoveAccuracy, ElementType Element, StatusEffect StatusEffect){
		attackName = Name;
		baseDamage = BaseDamage;
		baseAccuracy = MoveAccuracy;
		element = Element;
		statusEffects = new StatusEffect[]{StatusEffect};
		targetingType = HitTarget;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BattleMove"/> class with a chance of only one type of secondary effect.
	/// </summary>
	public BattleMove(string Name, TargetingType HitTarget, int BaseDamage, int MoveAccuracy, ElementType Element, BuffEffect BuffEffects){
		attackName = Name;
		baseDamage = BaseDamage;
		baseAccuracy = MoveAccuracy;
		element = Element;
		buffEffects = new BuffEffect[]{BuffEffects};
		targetingType = HitTarget;
	}

}
