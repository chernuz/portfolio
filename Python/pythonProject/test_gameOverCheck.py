from JKFlush import Player
from JKFlush import Card
from JKFlush import cardSuits
from JKFlush import cardNominals
import unittest

class test_gameOverCheck(unittest.TestCase):
    def setUp(self):
        pass

    def tearDown(self):
        pass

    def test_gameOverCheck(self):
        testPlayer = Player(
            [Card(2, cardSuits.пики),
            Card(3, cardSuits.пики),
            Card(4, cardSuits.пики),
            Card(5, cardSuits.пики),
            Card(6, cardSuits.пики),
            Card(7, cardSuits.пики),
            Card(8, cardSuits.пики)])
        self.assertTrue(testPlayer.gameOverCheck()), 'should be true'

    def test_roll(self):
        testPlayer = Player(
            [Card(cardNominals.A.value, cardSuits.пики),
            Card(2, cardSuits.пики),
            Card(3, cardSuits.пики),
            Card(4, cardSuits.пики),
            Card(5, cardSuits.пики),
            Card(6, cardSuits.пики),
            Card(7, cardSuits.пики)])
        self.assertTrue(testPlayer.gameOverCheck()), 'should be true'

if __name__ == "__main__":
    unittest.main()