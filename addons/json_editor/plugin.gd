tool
extends EditorPlugin

var select_file_dialog: FileDialog
var btnStt: PopupPanel
var dock : PanelContainer

func _enter_tree() -> void:
	var base := get_editor_interface().get_base_control()
	print("enter")
	select_file_dialog = FileDialog.new()
	select_file_dialog.add_filter("*.json")
	select_file_dialog.mode = FileDialog.MODE_OPEN_FILE
	base.add_child(select_file_dialog)
	
	btnStt = PopupPanel.new()
	
	dock = load("res://addons/json_editor/json_dock.tscn").instance()
	add_control_to_dock(DOCK_SLOT_RIGHT_UL, dock)

func _process(delta):
	pass

func _exit_tree() -> void:
	remove_control_from_docks(dock)
	dock.free()
	select_file_dialog.free()
