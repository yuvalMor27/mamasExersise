def pythagorean_triplet_by_sum(sum) -> str:
    for a in range(sum):
        for b in range(sum):
            c= sum-a-b
            if a + b + c == sum:
                if a**2 + b**2 == c**2 and a < b < c:
                    return f"{a} < {b} < {c}"
    return "There is no Pythagorean triple"

if __name__ == '__main__':
    print(pythagorean_triplet_by_sum(1000))
