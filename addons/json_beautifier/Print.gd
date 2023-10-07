
class_name JB

static func Print(dict: Dictionary):
	var json : String = JSONBeautifier.beautify_json(JSON.stringify(dict), 4)
	return json
