using Godot;
using StorageManagement;

namespace FarmClicker
{
	static class Utils
	{
		public static void AddTree(int gid, int id, string type, SceneTree sceneTree, bool first = false)
		{
			PackedScene t = ResourceLoader.Load<PackedScene>("res://ObjectsInst/Trees/" + type + ".tscn");
			PackedScene loadBar = ResourceLoader.Load<PackedScene>("res://ObjectsInst/LoadBar.tscn");

			Node lbar = loadBar.Instantiate();
			Node tree = t.Instantiate();

			tree.Set("id", id);
			tree.Set("gid", gid);
			lbar.Set("id", id);
			lbar.Set("gid", gid);
			lbar.Set("added", true);

			var a = SLManage.Check(id);
			if (a == 1) tree.Set("z_index", 1);
			else { tree.Set("z_index", 2); }
			tree.Call("set_position", new Variant[] { new Vector2(-410 + (190 * id), -420 + (300 * gid) + (-30 * a)) });
			lbar.Call("set_position", new Variant[] { new Vector2(-300 + (190 * id), -500 + (300 * gid) + (-30 * a)) });

			Node box = sceneTree.Root.GetNode("Node2D/Body/Market/Boxes");
			tree.Set("box", box);
			Node node = sceneTree.Root.GetNode("Node2D/Body");
			node.CallDeferred(Node2D.MethodName.AddChild, tree);
			Data data = ResourceLoader.Load<Data>("res://Data.tres");
			Data.TreeDict temp = new()
			{
				treeType = type,
				Id = id
			};
			data.Grounds[gid].trees.Add($"Tree{id}", temp);
		}

		public static bool AddGround(int id, string treeType, SceneTree sceneTree)
		{
			var ground = ResourceLoader.Load<PackedScene>("res://ObjectsInst/Ground.tscn").Instantiate();
			ground.Call("set_position", new Variant[] { new Vector2(-470, -1260 + (300 * id)) });
			Node node = sceneTree.Root.GetNode("Node2D/Body");
			node.CallDeferred("add_child", ground);

			return false;
		}
	}
}
