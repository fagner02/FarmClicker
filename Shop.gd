extends Node2D

onready var data = load("res://Data.tres")
onready var ground = load("res://ObjectsInst/Ground.tscn")
onready var node = get_node("../../Body")
onready var te = get_node("../../Background/Background/Label")
onready var box = get_node("../../Body/Market/Boxes")
onready var shopMenu = get_node("../../MidCanvas/ShopMenu")
onready var loadBar = load("res://ObjectsInst/LoadBar.tscn")
onready var addButton = load("res://ObjectsInst/AddButton.tscn")
onready var trees = load("res://Storage.tres")

var menuOn = false

func _ready():
	if trees.loaded == false: SL.Load()
	if trees.loaded != true: return
	print(SL.item("Box", data.MainDict))
	for i in data.MainDict.Grounds.size():
		var n = data.MainDict.Grounds.values()[i].Id
		var tt = data.MainDict.Grounds.values()[i].TreeType
		AddGround(n, tt)
		for x in data.MainDict.Grounds.values()[i].keys():
			if not ("Tree" in x and not "Type" in x): continue
			var tId = data.MainDict.Grounds.values()[i][x].Id
			AddTree(n, tId,  tt)
			print("end")
			#node.call_deferred("add_child",tree)
			#node.call_deferred("add_child", lbar)
	trees.loaded = true


func _process(delta):
	if trees.loaded == true:
		SL.Save()
		SL.WriteStorage()
	SL.delete(data.MainDict.Box, trees.labels)


func _on_Area2D3_click():
	if not menuOn:
		menuOn = true
		shopMenu.visible = true
	else:
		menuOn = false
		shopMenu.visible = false


func _on_Area2D_click():
	if not menuOn:
		menuOn = true
		shopMenu.visible = true
	else:
		menuOn = false
		shopMenu.visible = false
		
		
func AddTree(gid: int, id: int, type: String, first = false ):
	var t: Resource = load("res://ObjectsInst/Trees/"+ type +".tscn")
	
	var lbar = loadBar.instance()
	var tree = t.instance()
	tree.id = id
	tree.gid = gid
	lbar.id = id
	lbar.gid = gid
	lbar.added = true
	
	var a = SL.Check(id)
	if a == 1: tree.z_index = 1
	else: tree.z_index = 2
	tree.set_position(Vector2(-410 + (190 * id), -420 + (300 * gid)+(-30 * a)))
	lbar.set_position(Vector2(-300 + (190 * id), -500 + (300 * gid)+(-30 * a)))
	
	tree.box = box
	node.call_deferred("add_child",tree)
	#node.call_deferred("add_child", lbar)
	
	var temp = data.TreeDict.duplicate()
	temp.treeType = type
	temp.Id = id
	data.MainDict.Grounds.values()[gid]["Tree"+ str(id)] = temp
	#trees.loaded = true

func AddGround(var id: int, var treeType: String ):
	var g = ground.instance()
	g.set_position(Vector2(-470, -1260 + (300 * id)))
	node.call_deferred("add_child", g)
	trees.trees[str(id)] = {}

	return false
	
