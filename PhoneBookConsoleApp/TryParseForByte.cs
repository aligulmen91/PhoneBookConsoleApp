
using System;

namespace PhoneBookConsoleApp
{
    public static class TryParseIfPossible
    {
        public static byte FromStringToByte(string stringToConvert)
        {
            byte byteValue;
            bool result = Byte.TryParse(stringToConvert, out byteValue);
            if (result)
                return byteValue;
            else
                return 0;
        }
    }
}
