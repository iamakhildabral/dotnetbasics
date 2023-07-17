with open("Input.txt","r",encoding="utf-8") as file,open("Output.txt","w",encoding="utf-8") as write_object:
    buffer = file.read()
    write_object.write(buffer.upper())
