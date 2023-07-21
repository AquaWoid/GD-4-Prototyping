using Godot;
using System;

public partial class AreaTrigger : Area2D
{

	enum TriggerType {teleport, damage, pickup};

	private void OnTriggerEnter(Node2D body) {

		GD.Print(body.Name + " Entered Trigerrrr");
		if (body.IsInGroup("Player")) {
			GD.Print("Collider object is a Player");
		}

	}

		private void OnTriggerExit(Node2D body) {

		GD.Print(body.Name + " Exited Trigerrrr");
		if (body.IsInGroup("Player")) {
			GD.Print("Collider object is a Player");			
		}

	}
}
