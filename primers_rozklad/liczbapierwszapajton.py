n = int(input())
numbers = [True for i in range(n)]
primers = []
for i in range(len(numbers)):
    if i <= 1:
        numbers[i] = False
    else:
        if numbers[i]:
            primers.append(i)
            for j in range(i, len(numbers), i):
                numbers[j] = False
print(primers)
