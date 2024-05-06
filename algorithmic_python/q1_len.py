import math


def num_len(num) -> int:
    return round(math.log(num, 10)+1)

if __name__ == '__main__':
    print(num_len(2005555999))
