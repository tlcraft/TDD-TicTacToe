using System;
using System.ComponentModel;
using System.Globalization;

namespace TicTacToeConsole
{
    public class MessageEnums
    {
        public enum Messages
        {
            [Description("The game is over.")]
            GameEnding = 1,
            [Description("Game-on!")]
            GameStart = 2,
            [Description("Please enter in the coordinates for your move. These are zero based.")]
            GatherInput = 3,
            [Description("Tic-tac-toe")]
            Title = 4,
            [Description("The winner is: ")]
            Result = 5
        }

        public enum Errors
        {
            [Description("Please enter in a positive zero based coordinate. For example (1, 1).")]
            InputError = 1
        }
    }

    public static class EnumHelpers
    {
        // Copied from: https://www.codementor.io/cerkit/giving-an-enum-a-string-value-using-the-description-attribute-6b4fwdle0
        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            string description = null;

            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                        if (descriptionAttributes.Length > 0)
                        {
                            // we're only getting the first description we find others will be ignored
                            description = ((DescriptionAttribute)descriptionAttributes[0]).Description;
                        }

                        break;
                    }
                }
            }

            return description;
        }
    }
}
