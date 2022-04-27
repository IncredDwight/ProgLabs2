import Input as input
import my_file as m_file

inputFilePath = "/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/PyLab2/InputFile.bat"
dayFilePath = "/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/PyLab2/DayFile.bat"
nightFilePath = "/Users/yaroslavvalchyshen/Desktop/Study/Labs/Programming/Lab2/PyLab2/NightFile.bat"

day_calls = []
night_calls = []

is_clearing = input.get_file_mode()

calls = input.get_calls()

m_file.fill_file(inputFilePath, is_clearing, calls)
m_file.display_file(inputFilePath, "File: ")

for call in calls:
    if input.is_time_day(call["start_time"]) and input.is_time_day(call["end_time"]):
        day_calls.append(call)
    else:
        night_calls.append(call)

m_file.fill_file(dayFilePath, is_clearing, day_calls)
m_file.display_file(dayFilePath, "Day file: ")
m_file.fill_file(nightFilePath, is_clearing, night_calls)
m_file.display_file(nightFilePath, "Night file: ")

