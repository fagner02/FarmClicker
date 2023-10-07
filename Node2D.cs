using FarmClicker;
using Godot;
using StorageManagement;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

public partial class Node2D : Godot.Node2D
{
	public static async void DelayAction(int millisecond, Action action)
	{
		await Task.Delay(500);
		action.Invoke();
	}
	public override void _Ready()
	{
		RuntimeData runtimeData = GetNode<RuntimeData>("/root/RuntimeData");
		if (!runtimeData.loaded)
		{
			// SLManage.Load();
		}
		System.Threading.Thread.Sleep(1000);
		Task.Run(async delegate
		{
			await Task.Delay(500);
			Utils.AddGround(0, "OrangeTree", GetTree());
			Utils.AddTree(0, 1, "OrangeTree", GetTree());
		});
		// Utils.AddGround(0, "OrangeTree", GetTree());
		// Utils.AddTree(0, 0, "OrangeTree", GetTree());
		// Data data = ResourceLoader.Load<Data>("res://Data.tres");
		// for (int i = 0; i < data.Grounds.Count; i++)
		{
			// var n = data.Grounds[i].trees.Id
			// var tt = data.Grounds.values()[i].TreeType

			// for x in data.MainDict.Grounds.values()[i].keys(){
			// 	if not("Tree" in x and not "Type" in x): continue
			// 	var tId = data.MainDict.Grounds.values()[i][x].Id
			// 	AddTree(n, tId, tt)
			// 	print("end")
			// 	#node.call_deferred("add_child",tree)
			// 	#node.call_deferred("add_child", lbar)}
		}
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
