def pythagorean_triplet_by_sum(sum):
    for a in range(sum):
        for b in range(sum):
            for c in range(sum):
                if a + b + c == sum:
                    if a**2 + b**2 == c**2 and a < b < c:
                        return f"{a} < {b} < {c}"

if __name__ == '__main__':
    print(pythagorean_triplet_by_sum(30))
