with open("Input.txt","r",encoding="utf-8") as file,open("Output.txt","w",encoding="utf-8") as write_object:
    buffer = file.read()
    """
    I have used this code to test the funtions and speed to search 
    for a substring in the entire file all at once.
    So far python made me very happy with such a high speed compared to 
    statically type labguages.
    """
    # if buffer.__contains__("boyfriendKedarnath"):
    #     print("String Found in the file")
    # else:
    #     print("Not found")

