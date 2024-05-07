import math


def reverse_n_pi_digits(n) -> str:
    num_pi = str(math.pi)[2:2+n]
    return num_pi[::-1]


if __name__ == '__main__':
    print(reverse_n_pi_digits(5))
