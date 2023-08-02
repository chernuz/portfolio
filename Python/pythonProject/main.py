from JKFlush import CardDeck
from JKFlush import Player

# правила игры следующие: игроку раздается 7 карт; его цель - собрать 7 идущих подряд одномастных карт (например, пики 8-9-10-J-Q-K-A или крести A-2-3-4-5-6-7 (туз может быть только в начале "колеса")).
# в свой ход игрок может либо в открытую взять верхнюю карту колоды сброса, лежащую рубашкой вниз, либо в закрытую взять карту из неразложенной части колоды
# в конце хода игрок обязан скинуть одну из своих карт на выбор в колоду сброса
# когда неразложенная часть колоды заканчивается, перемешивается колода сброса (кроме верхней карты) и кладется рубашкой вниз, но лишь 1 раз
# если неразложенная часть колоды вновь заканчивается, игра считается проигранной.
# удачи!

deckIsShuffled = False  # флаг для завершения игры
deck = CardDeck()
deck.shuffle()
# Колода мешается и выводится для теста
dispatch = []
P1deck = []

# раздаем первые 7 карт игроку
for i in range(7):
    P1deck.append(deck.getCard(i))

# скидываем верхнюю карту в колоду сброса
dispatch.append(deck.getCard(7))

# убираем эти карты из колоды
for i in range(0, 8):
    deck.removeCard(0)
undealtInd = 0
dispatchInd = 0
P1 = Player(P1deck)
# ировой прцоесс
while True:
    P1.sort()
    print('Карты игрока:', len(P1.cards))
    P1.output()
    print('В колоде ', deck.getSize(), 'карт; Верхняя карта колоды сброса: ', end='')
    dispatch[dispatchInd].output()
    #print('1 - Взять верхнюю карту колоды сброса\n2 - Взять верхнюю карту колоды (взакрытую)')
    try:
        choice = int(input('1 - Взять верхнюю карту колоды сброса\n2 - Взять верхнюю карту колоды (взакрытую)\n'))
    except ValueError:
        print('Введите валидный индекс')
        continue
    match choice:
        case 1:
            # dispatchInd не меняется
            try:
                print('Выберите, какую карту сбросите: ')
                P1.output()
                chooseCard = int(input())
                if 1 <= chooseCard <= 8:
                    dispatch.append(P1.cards[chooseCard - 1])
                    P1.removeCard(chooseCard - 1)
                else:
                    print('Введен неверный индекс')
                    break
                P1.addCard(dispatch[dispatchInd])
                del dispatch[dispatchInd]
            except ValueError:
                print('Введите валидный индекс')
                continue
        case 2:
            try:
                print('Верхняя карта колоды: ', deck.getCard(undealtInd).returnCard())
                print('Выберите, какую карту сбросите: ')
                P1.output()
                chooseCard = int(input())
                if 1 <= chooseCard <= 8:
                    dispatch.append(P1.cards[chooseCard - 1])
                    P1.removeCard(chooseCard - 1)
                else:
                    print('Введен неверный индекс')
                    break
                P1.addCard(deck.getCard(undealtInd))
                deck.removeCard(undealtInd)
                dispatchInd += 1
            except ValueError:
                print('Введите валидный индекс')
                continue
        case _:
            print('Введен неверный индекс, попробуйте снова')

    # проверка на победу
    if P1.gameOverCheck():
        print('Вы победили! Поздравляю!')
        break

    # колода сброса перемешивается (помимо верхней карты), если карты в основной колоде заканчиваются. Колода перемешивается только раз
    if len(deck.getDeck()) == 0:
        if not deckIsShuffled:
            tempDeck = dispatch.copy()              # создаем копию колоды сброса
            lastCard = dispatch[len(dispatch)]      # создаем копию последней карты
            del tempDeck[len(tempDeck) - 1]         # удаляем из копии колоды последней карты
            deck.newCards(tempDeck)
            deck.shuffle()                          # заполняем колоду новыми картами и перемешиваем
            dispatch.clear()
            dispatch.append(lastCard)               # очищаем колоду сброса и добавляем туда только последнюю сброшенную карту
            deckIsShuffled = True                   # при следующем переполнении сброса игра завершается
            print('Колода перемешана. Если колода снова закончится - Вы проиграли.')
        else:
            print('Игра окончена: Вы проиграли.')
            break