//Written by Jiameng Zhou
//04/02/2021

namespace TestPart3
{
    public class Card
    {
        public string name;
        public int value;
        public string suit;

        public Card(string name, int value, string suit)
        {
            this.name = name;
            this.value = value;
            this.suit = suit;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }

        }
        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = Value;
            }

        }
        public string Suit
        {
            get
            {
                return this.suit;
            }
            set
            {
                this.suit = value;
            }

        }

        public override string ToString()
        {
            return Name + " of " + Suit + ", Value: " + Value; 
        }

    }
}
