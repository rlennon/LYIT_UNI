import pickle

modules = ["SWEN", "PROC", "OOP"]
file = open ('modules.txt', 'wb')
pickle.dump(modules, file)
file.close()
print("File updated by L00144427")
