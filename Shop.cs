using StorageManagement;
using Godot;
using System.Linq;
namespace FarmClicker
{
    partial class Shop : Node2D
    {
        Data data;
        PackedScene ground;
        Node node;
        Label te;
        Node box;
        Node shopMenu;
        PackedScene loadBar;
        PackedScene addButton;
        Storage trees;
        bool menuOn = false;

        Shop()
        {
            data = ResourceLoader.Load<Data>("res://Data.tres");
            ground = ResourceLoader.Load<PackedScene>("res://ObjectsInst/Ground.tscn");
            node = GetNode("../../Body");
            te = GetNode<Label>("../../Background/Background/Label");
            box = GetNode("../../Body/Market/Boxes");
            shopMenu = GetNode("../../MidCanvas/ShopMenu");
            loadBar = ResourceLoader.Load<PackedScene>("res://ObjectsInst/LoadBar.tscn");
            addButton = ResourceLoader.Load<PackedScene>("res://ObjectsInst/AddButton.tscn");
            trees = ResourceLoader.Load<Storage>("res://Storage.tres");
        }

        public override void _Ready()
        {
            if (trees.loaded == false) SLManage.Load();
            if (trees.loaded != true) return;

            foreach (int i in data.Grounds.Keys)
            {
                var n = data.Grounds[i].Id;
                var tt = data.Grounds[i].TreeType;

                Utils.AddGround(n, tt, GetTree());

                foreach (string x in data.Grounds[i].trees.Keys)
                {
                    if (!x.Contains("Tree") && !x.Contains("Type")) continue;
                    var tId = data.Grounds[i].trees[x].Id;
                    // Utils.AddTree(n, tId, tt, GetTree());
                }
            }
            trees.loaded = true;
        }

        public override void _Process(double delta)
        {
            // if (trees.loaded == true)
            //     SLManage.Save();
            // SLManage.WriteStorage();

            // SLManage.Delete(data.box, trees.labels);
        }

        void _on_Area2D3_click()
        {
            if (!menuOn)
            {
                menuOn = true;
                shopMenu.Set("visible", true);
            }
            else
            {
                menuOn = false;
                shopMenu.Set("visible", false);
            }
        }

        void _on_Area2D_click()
        {
            if (!menuOn)
            {
                menuOn = true;
                shopMenu.Set("visible", true);
            }
            else
            {
                menuOn = false;
                shopMenu.Set("visible", false);
            }
        }
    }
}