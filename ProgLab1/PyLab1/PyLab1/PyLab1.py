import Input as input
import MyFile as myFile

filePath = "D:\Дз\ОП\ProgLab1\File.txt"
changedFilePath = "D:\Дз\ОП\ProgLab1\ChangedFile.txt"
fileText = input.InputFile()
changedFileText = myFile.GetChangedFile(filePath)

myFile.FillFile(fileText, filePath)
myFile.FillFile(changedFileText, changedFilePath)

myFile.Display(filePath)
myFile.Display(changedFilePath, "Changed file")

