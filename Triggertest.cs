using Godot;
using System;

public partial class Triggertest : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		CharacterBody2D player = GlobalReferences.instance.player;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

}
