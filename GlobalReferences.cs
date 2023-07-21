using Godot;
using System;

public partial class GlobalReferences : Node
{

	public static GlobalReferences instance;

	[Export]
	public CharacterBody2D player;

	public override void _Ready() {
		instance = this;
	}


}
