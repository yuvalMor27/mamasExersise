import matplotlib.pyplot as plt
import numpy as np


def average(number_list) -> float:
    sum = 0
    for num in number_list:
        sum += num
    return sum / len(number_list)


def positive_numbers(number_list) -> int:
    count_positive = 0
    for num in number_list:
        if num >= 0 :
            count_positive += 1
    return count_positive


def sort_numbers(number_list) -> list:
    return sorted(number_list)


def graph(number_list, index_list):

    x = np.array(number_list)
    y = np.array(index_list)
    plt.title("INPUT DATA")
    plt.xlabel("NUMBERS")
    plt.ylabel("INPUT ORDER")

    avgx = np.mean(x)
    avgy = np.mean(y)
    m = (np.sum((x-avgx)*(y-avgy)))/(np.sum((x-avgx)*(x-avgx)))
    b = avgy - m*avgx
    print("m = ",m," b = ",b)
    x_line = x
    y_line = m*x + b
    plt.plot(x_line, y_line)
    plt.scatter(x, y)
    plt.show()


def is_number(num):
    if "-" in num:
        num_abs = abs(float(num))
        if str(num_abs).replace(".", "", 1).isdigit():
            return True
        else:
            return False
    else:
        if num.replace(".", "", 1).isdigit():
            return True
        else:
            return False

if __name__ == '__main__':
    number_list = []
    index_list = []
    num = 0
    print("INPUT:")
    index = 1
    while num != -1:
        num = input("enter number")
        if not is_number(num):
            raise TypeError("Only numbers can be entered")
        num = float(num)
        number_list.append(num)
        index_list.append(index)
        index += 1
    number_list.remove(-1)
    index_list.pop(-1)
    print(index_list)
    print(f"average : {average(number_list)}")
    print(f"positive : {positive_numbers(number_list)}")
    print(f"sort : {sort_numbers(number_list)}")
    graph(number_list, index_list)
