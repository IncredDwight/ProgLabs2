def GetChangedFile(filePath):
    lines = []
    changedText = []
    currentLine = ""
    numbersAmount = 0
    counter = 0

    file = open(filePath, 'r')

    lines = file.readlines()
    for i in range(0, len(lines)):
        numbersAmount = 0
        currentLine = lines[i].replace("\n", "")
        for j in range(0, len(currentLine)):
            if(currentLine[j].isdigit()):
                numbersAmount += 1

        if(i % 2 == 0):
            currentLine += " Digits amount: " + str(numbersAmount)
        changedText.append(currentLine)
    return changedText

def FillFile(text, filePath):
    file = open(filePath, 'w')
    for i in range(0, len(text)):
        file.write(text[i] + "\n")

def Display(filePath, caption = "Original file"):
    print(caption)

    file = open(filePath, 'r')
    lines = file.readlines()
    for i in range(0, len(lines)):
        print(lines[i].replace("\n", ""))

