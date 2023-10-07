extends Node2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
@onready var data = load("res://Data.tres")
@onready var storage = load("res://Storage.tres")
@onready var shop = get_node("../../../DownCanvas/Shop")
@export var id: int
var n = 0
@export var treeType: String
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.
	


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	pass


func _on_Button_button_down():
	if storage.loaded:
		for x in data.MainDict.Grounds.values()[id].keys() :
			if "Tree" in x and not "Type" in x:
				print(x, " name")
				n += 1
		if n < 3:
			shop.AddTree(id, n, treeType)
		print(str(n), " add after")
		n = 0
