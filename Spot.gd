extends Node2D

# var plants: Array
# var plant = false
# @onready var parent = get_node("../Body")
# func _ready():
# 	var dir =DirAccess.new()
# 	dir.open('res://ObjectsInst/Trees/')
# 	dir.list_dir_begin() # TODOConverter3To4 fill missing arguments https://github.com/godotengine/godot/pull/40547
# 	var file = dir.get_next()
# 	while file:
# 		if file.ends_with('.tscn'):
# 			plants.insert(0, dir.get_current_dir()+'/'+file)
# 		file = dir.get_next()
# 	pass # Replace with function body.


# func _on_Area2D_input_event(viewport, event, shape_idx):
# 	if event is InputEventMouseButton and event.pressed:
# 		plant = true
# 	pass # Replace with function body.

# func _on_Button_click(text):
# 	print(plants[0])
# 	var p = load(plants[0]).instantiate()
# 	p.position = position
# 	parent.call_deferred("add_child", p)
# 	print(text)
# 	pass # Replace with function body.
