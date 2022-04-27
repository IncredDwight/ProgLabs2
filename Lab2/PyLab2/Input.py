def get_file_mode():
    rewriteKey = "r"
    print("Enter file mode(To rewrite file enter '" + rewriteKey + "' or anything else to append):")
    return input() == rewriteKey


def get_calls():
    calls = []

    print("Enter information about phone calls. To stop enter empty line\n (format: +**0********* HH:MM HH:MM): ")
    inp = input()
    while inp != "":
        call = create_call(inp)

        if len(call) != 0:
            calls.append(call)
        else:
            print("Error! Wrong format. Try again")
        inp = input()
    return calls


def create_call(line):
    elements = str(line).split(" ")

    if len(elements) != 3:
        return {}

    if not is_phone_number_format_valid(elements[0]) or not is_time_format_valid(
            elements[1]) or not is_time_format_valid(elements[2]):
        return {}

    start_time = elements[1]
    end_time = elements[2]

    call_info = {
        "phone_number": elements[0],
        "start_time": start_time,
        "end_time": end_time
    }

    return call_info


def is_phone_number_format_valid(number):
    if len(number) != 13 or number[0] != "+" or number[3] != "0":
        return False
    i = 1
    while i < len(number):
        if not str(number[i]).isdigit():
            return False
        i += 1

    return True


def is_time_format_valid(time):
    if len(time) != 5 or time[2] != ":":
        return False

    i = 0
    while i < len(time):
        if not str(time[i]).isdigit() and i != 2:
            return False
        i += 1

    splitted = str(time).split(":")
    if int(splitted[0]) > 23 or int(splitted[1]) > 59:
        return False

    return True

def is_time_day(time):
    splitted = str(time).split(":")
    return 6 < int(splitted[0]) < 20