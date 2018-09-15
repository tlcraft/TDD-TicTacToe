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
            [Description("Please enter in the coordinates for your move.")]
            GatherInput = 3
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
