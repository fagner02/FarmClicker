using System;
using System.Collections.Generic;
using Godot;
using Godot.Collections;

namespace StorageManagement
{
	[GlobalClass]
	public partial class Data : Resource
	{
		public Godot.Collections.Dictionary<string, int> MainDict = new(){
			{"money", 0},
			// {'ground', }
			// Chest
			// Money
		};
		// public class MainDict{
		// 	int Money;

		// }

		public Godot.Collections.Dictionary<int, Ground> Grounds = new()
		{
			// Add Ground
		};

		public partial class Ground : GodotObject
		{
			public int Id = 0;
			public string TreeType;
			public Godot.Collections.Dictionary<string, TreeDict> trees;
		};

		public partial class TreeDict : GodotObject
		{
			public string treeType = "";
			public int Id = 0;
		};

		public class Box
		{
			int limit = 0;
			// #Add Fruit;
		}

		public class Fruit
		{
			int fruits = 0;
			string fruitType = "";
			double fruitPrice = 0;
			string ftId = "";
		}
		Godot.Collections.Array data = new() { };

		public class sto
		{
			int id = 0;
		}

		public void Check()
		{
			var dataD = ResourceLoader.Load<Data>("res://Data.tres");

			for (int i = 0; i < dataD.data.Count; i++)
			{
				// print(dataD.data.values()[x].id);
				// print(load("res://Data.tres"));
			}
		}

		public enum TreeType
		{
			OrangeTree
		}
	}
}