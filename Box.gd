extends Sprite2D

@onready var data = load("res://Data.tres")
@onready var res = load("res://Storage.tres")
@onready var text = $CanvasLayer/Label
@onready var anim = $AnimationTree.get("parameters/playback")
@onready var label = load("res://ObjectsInst/Label.tscn")
@onready var infoMenu = $Info/Item
@onready var scroll = $Info/ScrollContainer/VBoxContainer
var fruits: float
var limit: float
var on : bool = false
# Declare member variables here. Examples:
# var a = 2
# var b = "text"

	
func _process(delta):
	if res.loaded:
		SL.delete(data.MainDict.Box, res.labels)
		for i in data.MainDict.Box.size():
			var ft = data.MainDict.Box.values()[i-1].ftId
			if res.labels.has(ft):
				for n in scroll.get_child_count():
					if scroll.get_child(n).fruitName == ft:
						scroll.get_child(n).text = str(data.MainDict.Box.values()[i-1].fruits) + data.MainDict.Box.values()[i-1].fruitType + str(data.MainDict.Box.values()[i-1].fruitPrice)
			else:
				Instance(i,ft)
			fruits += data.MainDict.Box.values()[i-1].fruits 
		text.text = str(fruits)+"/"+str(limit)
		fruits = 0
	
func Instance(x: int, ft : String):
	var temp = label.instantiate()
	var box = data.MainDict.Box
	temp.fruitName = ft
	temp.name = ft
	res.labels[ft] = str(ft)
	temp.get_child(0).text = str(box.values()[x-1].fruits) + box.values()[x-1].fruitType + str(box.values()[x-1].fruitPrice)
	scroll.call_deferred("add_child", temp)
	
func Delete(ft: String):
	
	pass

func _on_Button_pressed():
	c

func _on_TextureButton_pressed():
	anim.start("Minimize")
	on = false


func _on_Clients_collect():
	for x in data.MainDict.Box.size():
		var dict = data.MainDict.Box
		if dict.values()[x].fruits > 0:
			
			data.MainDict.Money += dict.values()[x].fruitPrice
			dict.values()[x].fruits -= 1
	
	pass
	
	


func _on_button_pressed():
	pass # Replace with function body.
