extends Node2D

@export var id : float
@export var gid: float
@export var treeType : String 
@export var fruitType : String
@export var fruitPrice : float
@export var timeCounter: float
@export var fruits: int
@export var ready: bool = false
@export var click: bool = false
@onready var data = load("res://Data.tres")
@onready var trees = load("res://Storage.tres")
@onready var te = get_node("../../Background/Background/Label")
@onready var time : Timer = get_node("Timer")
@onready var anim2 = get_node("AnimationTree2").get("parameters/playback")
@onready var anim3 = get_node("AnimationTree3").get("parameters/playback")
@onready var anim = $AnimationTree4.get("parameters/playback")
@onready var loadBar = get_node("LoadBar")
@export var timeLimit : float
var box
var i = 0
var b = false
var pressed = false

func _ready():
	if trees.loaded:
		var path: String = self.get_path()
		trees.trees[str(gid)][id] = path
		var a = SL.Check(id)
		if a ==1:
			$Node2D/DarkL.visible = true
	
	#print(trees.trees[gid][id])
	#print(path)
	time.start(timeLimit)
	
	

func _process(delta):
	timeCounter = time.time_left
	#print_debug(time.time_left)
	#loadBar.get_child(2).value = time.time_left
	if trees.loaded:
		if (id+1)< trees.trees[str(gid)].size() && id > 0:
			$Node2D/DarkL2.visible = true


func _on_Timer_timeout():
	time.stop()
	anim2.start("AddFruit")
	ready = true
	
func OnClick():
	anim3.start("Click")
	if ready:
		var ft = fruitType+str(id)+str(gid)
		if data.MainDict.Box.has(ft):
			data.MainDict.Box[ft].fruitType = fruitType
			data.MainDict.Box[ft].fruits += 1
			data.MainDict.Box[ft].fruitPrice = fruitPrice
			
		else:
			data.MainDict.Box[ft] = data.Fruit.duplicate()
			data.MainDict.Box[ft].fruitType = fruitType
			data.MainDict.Box[ft].fruits += 1
			data.MainDict.Box[ft].fruitPrice = fruitPrice
			data.MainDict.Box[ft].ftId = ft
			
		time.start(timeLimit)
		anim2.start("TakeFruit")
		ready = false
	click = false

func _on_Close_pressed():
	anim.start("Minimize")

func longClick():
	anim.start("Expand")

func _on_KinematicBody2D_input_event(viewport, event, shape_idx):
	var sec = 0
	if event is InputEventScreenTouch and event.pressed:
		b = true
		print("true")
	if event is InputEventScreenTouch and not event.pressed:
		if b and sec ==0:
			print("click")
			OnClick()
		b= false 
		sec=0
	while b:
		await get_tree().create_timer(0.1).timeout
		sec+=1
		if sec==5: 
			longClick()
			b = false
			trees.button_pressed = false
			print("long", sec) 
			break
	if trees.pressed and not pressed and not b:
		OnClick()
		pressed = true



func _on_KinematicBody2D_mouse_exited():
	pressed = false
