using Godot;
using StorageManagement;

public partial class Tree : Node2D
{
    public float id;
    float gid;
    public string treeType;
    public string fruitType;
    public float fruitPrice;
    float timeCounter;
    int fruits;
    bool ready = false;
    bool click = false;
    Data data = ResourceLoader.Load<Data>("res://Data.tres");
    Storage trees = ResourceLoader.Load<Storage>("res://Storage.tres");
    // # onready var te = get_node("../../Background/Background/Label")
    Timer time;

    AnimationNodeStateMachinePlayback anim2;
    AnimationNodeStateMachinePlayback anim3;
    AnimationNodeStateMachinePlayback anim;
    Node loadBar;
    float timeLimit;
    public Tree()
    {
        time = GetNode<Timer>("Timer");
        anim2 = (AnimationNodeStateMachinePlayback)GetNode("AnimationTree2").Get("parameters/playback");
        anim3 = (AnimationNodeStateMachinePlayback)GetNode("AnimationTree3").Get("parameters/playback");
        anim = (AnimationNodeStateMachinePlayback)GetNode("AnimationTree4").Get("parameters/playback");
        loadBar = GetNode<Node>("LoadBar");
    }
}


//  count = {"click": {}, "longClick": false}
// # var loading = {"click": false, "longClick": false}
// # var pressed = false
// # var clickId := 0
// # var menuOn = false
// # var box 

// # func _ready():
// #if trees.loaded:
// # var path: String = self.get_path()
// # trees.trees[str(gid)][id] = path
// # var a = SL.Check(id)
// #if a ==1:
// #           $Node2D/DarkL.visible = true
// # time.start(timeLimit)



// # func _process(delta):
// # timeCounter = time.time_left
// #if trees.loaded:
// #if (id+1)< trees.trees[str(gid)].size() && id > 0:
// #           $Node2D/DarkL2.visible = true


// # func _on_Timer_timeout():
// # time.stop()
// # anim2.start("AddFruit")
// # ready = true

// # func OnClick():

// # anim3.start("Click")
// #if ready:
// # var ft = fruitType+str(id)+str(gid)
// #if data.MainDict.Box.has(ft):
// #           # data.MainDict.Box[ft].fruitType = fruitType
// # data.MainDict.Box[ft].fruits += 1
// # data.MainDict.Box[ft].fruitPrice = fruitPrice
// #else:
// # data.MainDict.Box[ft] = data.Fruit.duplicate()
// # data.MainDict.Box[ft].fruitType = fruitType
// # data.MainDict.Box[ft].fruits += 1
// # data.MainDict.Box[ft].fruitPrice = fruitPrice
// # data.MainDict.Box[ft].ftId = ft

// # time.start(timeLimit)
// # anim2.start("TakeFruit")
// # ready = false
// # click = false

// # func _on_Close_pressed():
// # anim.start("Minimize")
// # menuOn = false

// # func _on_KinematicBody2D_input_event(viewport, event, shape_idx):
// # var x=clickId
// #if event is InputEventScreenTouch and event.pressed:
// # pressed = true
// # requestClick(x)
// # longClick()

// # # RELEASE --------------------------------------------------
// #if event is InputEventScreenTouch and not event.pressed:
// #if count.click.has(str(x)):
// # trees.button_pressed = false
// # pressed = false
// # count.longClick = false
// # count.click.erase(str(x))
// # OnClick()

// #if count.longClick:
// # count.longClick = false
// # pressed = false
// # clickId+=1
// #if clickId > 10: clickId =0

// #if trees.pressed and not pressed and not menuOn:
// # pressed = true
// # OnClick()

// # func requestClick(x: int):
// # count.click[str(x)] = true
// # await get_tree().create_timer(0.1).timeout

// #if not count.click.has(str(x)): 
// # return

// # count.click.erase(str(x))

// # func longClick():
// #if loading.longClick:
// # count.longClick = false
// # return
// # loading.longClick = true
// # count.longClick = true

// # await get_tree().create_timer(0.6).timeout
// #if not count.longClick: 
// # loading.longClick = false
// # return
// #   #count.longClick = false
// # anim.start("Expand")
// # menuOn = true
// #   #pressed = false
// # loading.longClick = false

// # func _on_KinematicBody2D_mouse_exited():
// # count.longClick = false
// # pressed = false
// }