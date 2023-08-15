extends MenuButton

export var icon_name: String
export var type: String
func _ready():
	call_deferred("_add_props")

func _add_props():
	icon = get_icon(icon_name, type)
