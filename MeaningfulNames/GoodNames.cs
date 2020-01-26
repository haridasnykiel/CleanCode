namespace MeaningfulNames
{
    public class GoodNames
    {
        private string _owner;
        private int _itemCount;
        private string _item;

        private string _number;
        private string _pluralModifier;
        private string _verb;

        public GoodNames(string owner, int itemCount, string item = null)
        {
            _owner = owner;
            _itemCount = itemCount;
            _item = item;
        }

        private void NoItemsMessage() {
            _number = "no";
            _verb = "has";
            _item = "item";
            _pluralModifier = "s";
        }

        private void OneItemMessage() {
            _number = "1";
            _verb = "has one";
            _pluralModifier = "";
        }

        private void ManyItemsMessage() {
            _number = $"{_itemCount}";
            _verb = "has";
            _pluralModifier = "s";
        }

        public string Message() {

            if (_itemCount == 0)
            {
                NoItemsMessage();
            }

            if (_itemCount == 1)
            {
                OneItemMessage();
            }

            if (_itemCount > 1)
            {
                ManyItemsMessage();
            }

            return $"{_owner} {_verb} {_number} {_item}{_pluralModifier}.";
        }

    }
}