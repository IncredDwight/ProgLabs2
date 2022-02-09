def InputFile():
    text = []
    inp = ""
    print("Enter text (enter end to stop input): ")

    inp = input()
    while(inp != "end"):
          text.append(inp)
          inp = input()

    return text


    
