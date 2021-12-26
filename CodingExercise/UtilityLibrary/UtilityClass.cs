using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLibrary
{
    public class UtilityClass
    {
        public UtilityClass()
        {
        }


        public string aboveBelow(int[] collection, int value)
        {
            string json = "";
            ReturnAboveBelow ret = new ReturnAboveBelow();

            foreach (var c in collection)
            {
                if (c < value)
                    ret.Below++;
                else if (c > value)
                    ret.Above++;
            }

            json = JsonConvert.SerializeObject(ret);

            return json;
        }

        public string aboveBelowEqual(int [] collection, int value)
        {
            string json = "";
            ReturnAboveBelowEqual ret = new ReturnAboveBelowEqual();

            foreach(var c in collection)
            {
                if (c < value)
                    ret.Below++;
                else if (c > value)
                    ret.Above++;
                else if (c == value)
                    ret.Equal++;
            }

            json = JsonConvert.SerializeObject(ret);

            return json;
        }


        //Rotate the originalString by the rotationAmount, by splitting originalString based of which characters would overflow to the start of the string.
        public string stringRotation(string originalString, int rotationAmount)
        {
            string returnString = "";

            //If the rotation amount exceeds the max length of the original string the swap would try to access data that's not there, so we mod the rotationAmount by the originalString's length to get the correct index where the string needs to be split
            if (rotationAmount > originalString.Length)
                rotationAmount = rotationAmount % originalString.Length;

            //Taking the overflowed characters and putting them at the begining of the new string
            returnString = originalString.Substring(originalString.Length - rotationAmount);

            //Taking the shifted characters and putting them at the end
            returnString += originalString.Substring(0, originalString.Length - rotationAmount);

            return returnString;
        }
    }
}
