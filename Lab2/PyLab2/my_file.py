import pickle


def fill_file(path, is_clearing, data):
    info = []

    if not is_clearing:
        with open(path, "rb") as file:
            info = pickle.load(file)

    for call in data:
        info.append(call)

    with open(path, "wb") as file:
        pickle.dump(info, file)


def read_file(path):
    info = []
    with open(path, "rb") as file:
        info = pickle.load(file)

    return info


def display_file(path, caption="File: "):
    print(caption)

    with open(path, "rb") as file:
        info = pickle.load(file)

        for call in info:
            for value in call.values():
                print(value, end=' ')
            print()
