using System.Diagnostics;
using System;
using Godot;
using StorageManagement;

[GlobalClass]
public static class SLManage
{
    public static bool Load()
    {
        ResourceSaver.Save(new Storage(), "res://Storage.tres");
        Storage res = ResourceLoader.Load<Storage>("res://Storage.tres");
        Storage data = ResourceLoader.Load<Storage>("res://Data.tres");
        Godot.FileAccess file;

        if (Godot.FileAccess.FileExists("res://Datak.json"))
        {
            file = Godot.FileAccess.Open("res://Datak.json", Godot.FileAccess.ModeFlags.Read);
            var jsn = file.GetAsText();
            if (jsn != "")
            {
                Debugger.Log(1, null, "load");

                using Json test_json_conv = new();
                if (test_json_conv.Parse(jsn) == Error.Ok)
                {
                    data = test_json_conv.Data.As<Storage>();
                }
            }
            else
            {
                Debugger.Log(1, null, "correct");

                file.Close();
                file = Godot.FileAccess.Open("res://DataBackup.json", Godot.FileAccess.ModeFlags.Read);

                jsn = file.GetAsText();
                using Json test_json_conv = new();
                if (test_json_conv.Parse(jsn) == Error.Ok)
                {
                    data = test_json_conv.Data.As<Storage>();
                }
            }
            file.Close();
        }

        res.loaded = true;
        return true;
    }

    static void Save()
    {
        var res = ResourceLoader.Load<Storage>("res://Storage.tres");

        var data = ResourceLoader.Load<Storage>("res://Data.tres");

        if (res.loaded == true)
        {
            if (res.loading == false)
            {
                res.loading = true;

                Godot.FileAccess file = Godot.FileAccess.Open("res://Datak.json", Godot.FileAccess.ModeFlags.Write);

                file.StoreLine(Json.Stringify(data));

                file.Close();


                file = Godot.FileAccess.Open("res://DataBackup.json", Godot.FileAccess.ModeFlags.Write);

                file.StoreLine(Json.Stringify(data));

                file.Close();

                res.loading = false;
            }
        }
    }


    public static int Check(double id)
    {
        double a = Math.Ceiling(id / 2.0);
        double m = id / 2.0;
        double c = a - m;

        int d;
        if (c > 0)
            d = 1;
        else
            d = 0;

        return d;
    }



    public static void Delete()
    {

    }


}


// class_name SL
// const v = {"pressed": false}

// static func WriteStorage():
// 	var res = load("res://Storage.tres")
// 	if res.loaded:
// 		var file = File.new()

//         file.open("res://Storage.json", File.WRITE)

//         file.store_line(JB.Print(res.main))

//         file.close()





// static func item(name: String, dict: Dictionary):
// 	return dict[name]

//     pass

// static func delete(dict: Dictionary, dict1: Dictionary):
// 	#find(dict, "fruits", 0)
// 	for x in dict.size():

//         if dict.values()[x - 1].fruits == 0:
// 			for y in dict1.size():

//                 if dict1.values()[y - 1] == dict.values()[x - 1].ftId:
// 					dict1.erase(dict1.values()[y - 1])

//                     return
//             dict.erase(dict.values()[x - 1].ftId)

//             print("deleted")


// static func check(name: String):
// 	var labels = load("res://Storage.tres").labels
// 	var exist = false
// 	for x in labels.size():
// 		if labels.values()[x] == name:
// 			exist = true

//     return exist

// static func find(dict: Dictionary, property: String, test):
// 	var found = false
// 	var index
// 	var key 
// 	for x in dict.size():
// 		if test == dict.values()[x - 1][property]:
// 			key = dict.keys()[x - 1]

//             found = true

//             index = x - 1

//             return

//     return key


// static func getData():
// 	var storage = load("res://Storage.tres")

// 	if not storage.loaded:
// 		return

//     else:
// 		print("els")

//         var data = load("res://Data.tres")
// 		return data


