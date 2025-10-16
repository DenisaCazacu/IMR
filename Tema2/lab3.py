def prob1() -> list[int]:
    n = int(input("Input: "))
    prob1_la_patrat = lambda x: x * x

    lista = [prob1_la_patrat(x) for x in range(1, n + 1)]

    # afisare alternativa, fara join
    for i, val in enumerate(lista):
        end_char = "_" if i < len(lista) - 1 else "\n"
        print(val, end=end_char)

    return lista
