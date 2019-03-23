using System;

namespace BitOperations
{
    /// <summary>
    /// Contains methods that provide number's bits manipulations.
    /// </summary>
    public static class BitsManipulation
    {
        /// <summary>
        /// Maximal index of bit for number
        /// </summary>
        private const int MaximalBitNumber = 31;

        /// <summary>
        /// Minimal index of bit for number
        /// </summary>
        private const int MinimalBitNumber = 0;

        /// <summary>
        /// Method inserts bits from the second array to the first.
        /// </summary>
        /// <param name="sourceNumber">Number for modification.</param>
        /// <param name="insertNumber">Number where bits for first number is borrowed.</param>
        /// <param name="startBitNumber">Start bit number of numberSourceOfBits.</param>
        /// <param name="endBitNumber">End bit number of numberSourceOfBits.</param>
        /// <returns>Number with inserted bits</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when start 
        /// Bit startBitNumber is greater than endBitNumber. </exception>
        public static int GetModifiedNumber(int sourceNumber, int insertNumber, int startBitNumber, int endBitNumber)
        {
            if (startBitNumber < MinimalBitNumber || startBitNumber > MaximalBitNumber)
            {
                throw new ArgumentOutOfRangeException($"{nameof(startBitNumber)} must be in range  [0, 31]");
            }

            if (endBitNumber < MinimalBitNumber || endBitNumber > MaximalBitNumber)
            {
                throw new ArgumentOutOfRangeException($"{nameof(endBitNumber)} must be in  [0, 31]");
            }

            if (startBitNumber > endBitNumber)
            {
                throw new ArgumentOutOfRangeException($"{startBitNumber} can't be greater than {endBitNumber}");
            }

            return GetModifiedSignedNumber(sourceNumber, insertNumber, startBitNumber, endBitNumber);
        }

        private static int GetModifiedSignedNumber(int numberSource, int numberInsert, int startBitNumber, int endBitNumber)
        {
            int insertionPartLength = endBitNumber - startBitNumber + 1;
            int mask = (int.MaxValue >> (31 - insertionPartLength)) << startBitNumber;
            numberSource = ~mask & numberSource;
            numberInsert = mask & (numberInsert << startBitNumber);
            return numberSource | numberInsert;
        }
    }
}
