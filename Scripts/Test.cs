using Godot;
using System;

public partial class Test : Node2D
{
	[Export]
	public int tes = 1;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Test");

		var scene = GD.Load<PackedScene>("res://Objects/player.tscn");

		var instance = scene.Instantiate();
		AddChild(instance);

		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
