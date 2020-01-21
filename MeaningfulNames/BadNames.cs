using System;

namespace MeaningfulNames {
    public class BadNames {
        public void displayOwnerAndItemDetails (string owner, int itemCount, string item = null) {
            string number;
            string verb;
            string pluralModifier;

            if (itemCount == 0) {
                number = "no";
                verb = "has";
                item = "item";
                pluralModifier = "s";
            } else if (itemCount == 1) {
                number = "1";
                verb = "has one";
                pluralModifier = "";
            } else {
                number = "many";
                verb = "has";
                pluralModifier = "s";
            }

            var message = $"{owner} {verb} {number} {item}{pluralModifier}.";

            Console.WriteLine (message);
        }
    }
}