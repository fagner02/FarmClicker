using Godot;
using Godot.Collections;

namespace StorageManagement
{
	[GlobalClass]
	public partial class Storage : Resource
	{
		[Export]
		public Dictionary<string, string> main;
		[Export] public bool loading = false;
		public Dictionary<string, string> trees;
		public Dictionary<string, string> plants;
		public Dictionary<string, string> labels;
		public bool loaded = false;
		public bool pressed = false;
		public float screenS;
	}
}
