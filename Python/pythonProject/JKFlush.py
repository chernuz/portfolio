import enum
from random import shuffle


cardNominals = enum.Enum(
    value='cardNominals',
    names=[('2', 2), ('3', 3), ('4', 4), ('5', 5), ('6', 6), ('7', 7), ('8', 8), ('9', 9), ('10', 10), ('J', 11),
           ('Q', 12), ('K', 13), ('A', 14)],
)


class cardSuits(enum.Enum):
    крести = 0
    пики = 1
    буби = 2
    черви = 3


class Card(object):
    def __init__(self, nominal, suit):
        self.suit = suit
        self.nominal = nominal

    def output(self):
        print(cardNominals(self.nominal).name, ' ', self.suit.name)

    def returnCard(self):
        return str(cardNominals(self.nominal).name) + ' ' + str(self.suit.name)

    def __lt__(self, other):  # крести<пики<буби<черви
        if cardSuits(self.suit).value == cardSuits(other.suit).value:
            return self.nominal < other.nominal
        else:
            return cardSuits(self.suit).value < cardSuits(other.suit).value


class CardDeck(object):
    def __init__(self):
        self.deck = []
        for nominal in range(2, 14):
            self.deck.append(Card(nominal, cardSuits.крести))
            self.deck.append(Card(nominal, cardSuits.пики))
            self.deck.append(Card(nominal, cardSuits.буби))
            self.deck.append(Card(nominal, cardSuits.черви))

    def newCards(self, cards):
        self.deck = cards

    def output(self):
        for i in self.deck:
            i.output()

    def shuffle(self):
        shuffle(self.deck)

    def getDeck(self):
        return self.deck

    def getCard(self, ind):
        return self.deck[ind]

    def removeCard(self, ind):
        del self.deck[ind]

    def getSize(self):
        return len(self.deck)


class Player(object):
    def __init__(self, cards):
        self.cards = cards

    def output(self):
        for i in range(1, len(self.cards) + 1):
            print(i, " - ", self.cards[i - 1].returnCard())

    def addCard(self, card):
        self.cards.append(card)

    def removeCard(self, ind):
        del self.cards[ind]

    def gameOverCheck(self):
        tempDeck = sorted(self.cards)
        if tempDeck[len(tempDeck)-1].nominal == cardNominals.A.value and tempDeck[0].nominal == 2 and tempDeck[len(tempDeck)-1].suit == tempDeck[0].suit:
            for i in range(0, len(tempDeck) - 2):
                if tempDeck[i].suit != tempDeck[i + 1].suit:
                    return False
                if tempDeck[i].nominal != tempDeck[i + 1].nominal - 1:
                    return False
        else:
            for i in range(0, len(tempDeck)-1):
                if tempDeck[i].suit != tempDeck[i + 1].suit:
                    return False
                if tempDeck[i].nominal != tempDeck[i + 1].nominal - 1:
                    return False
        return True

    def sort(self):
        self.cards = sorted(self.cards)