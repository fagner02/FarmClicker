using System.Diagnostics;
using Godot;
using StorageManagement;

namespace FarmClicker
{
	public partial class Box : Sprite2D
	{
		Label text;
		AnimationNodeStateMachinePlayback anim;
		Label label;
		Label infoMenu;
		VBoxContainer scroll;
		float fruits;
		float limit;
		bool on = false;

		Box()
		{
			// text = GetNode<Label>("Label");
			// anim = (AnimationNodeStateMachinePlayback)GetNode<AnimationTree>("AnimationTree").Get("parameters/playback");
			// label = ResourceLoader.Load<Label>("res://ObjectsInst/Label.tscn");
			// infoMenu = GetNode<Label>("Info/Item");
			// scroll = GetNode<VBoxContainer>("Info/ScrollContainer/VBoxContainer");
		}


		public override void _Process(double delta)
		{
			{
				// SLManage.Delete(data..Box, res.labels)

				// for i in data.MainDict.Box.size():

				//     var ft = data.MainDict.Box.values()[i - 1].ftId

				//     if res.labels.has(ft):
				// 		for n in scroll.get_child_count():

				//             if scroll.get_child(n).fruitName == ft:
				// 				scroll.get_child(n).text = str(data.MainDict.Box.values()[i - 1].fruits) + data.MainDict.Box.values()[i - 1].fruitType + str(data.MainDict.Box.values()[i - 1].fruitPrice)

				//     else:
				// 		Instance(i, ft)

				//     fruits += data.MainDict.Box.values()[i - 1].fruits

				// text.text = str(fruits) + "/" + str(limit)

				// fruits = 0}
			}
		}

		private void _on_button_pressed()
		{
			Debugger.Log(1, null, "INNNNNNNNNNNNNNNNNN");
			anim.Start("Expand");
			on = true;
		}
	}
}



// func Instance(x: int, ft : String):

// var temp = label.instantiate()

// var box = data.MainDict.Box

// temp.fruitName = ft
// temp.name = ft
// res.labels[ft] = str(ft)

// temp.get_child(0).text = str(box.values()[x - 1].fruits) + box.values()[x - 1].fruitType + str(box.values()[x - 1].fruitPrice)

// scroll.call_deferred("add_child", temp)


// func Delete(ft: String):


//     pass



// func _on_TextureButton_pressed():

// anim.start("Minimize")

// on = false


// func _on_Clients_collect():
// 	for x in data.MainDict.Box.size():

// 		var dict = data.MainDict.Box

// 		if dict.values()[x].fruits > 0:

// 			data.MainDict.Money += dict.values()[x].fruitPrice

// 			dict.values()[x].fruits -= 1


// 	pass





