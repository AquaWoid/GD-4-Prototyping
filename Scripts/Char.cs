using Godot;
using System;

public partial class Char : CharacterBody2D
{
    [Export]
    public int Speed { get; set; } = 400;

    public void GetInput()
    {

        Vector2 inputDirection = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
        Velocity = inputDirection * Speed;
    }

    public override void _PhysicsProcess(double delta)
    {
        GetInput();
        MoveAndSlide();
    }


	
	private void OnArea2dBodyEntered(Node2D body) {
		GD.Print("Entered Trigger");
	}

	private void OnTriggerExit(Node2D body) {
			GD.Print("Exited Trigger");
	}

}
