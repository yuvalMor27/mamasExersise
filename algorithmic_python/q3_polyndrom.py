def is_sorted_polyndrom(word) -> bool:
    until_the_middle = word[:len(word)//2]
    from_the_middle = word[len(word)//2:]
    if until_the_middle == "".join(sorted(until_the_middle)) and from_the_middle[::-1] == "".join(sorted(from_the_middle[::-1])):
        for index in range(len(until_the_middle)):
                if until_the_middle[index] == from_the_middle[-(index+1)]:
                    continue
                else:
                    return False
        return True
    else:
        return False


if __name__ == '__main__':
    print(is_sorted_polyndrom("sos"))

