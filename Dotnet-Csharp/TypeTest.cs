using System;
using System.Collections.Generic;

namespace TypeTest
{
    public class TypeTest
    {
        public static T MidPoint<T>(IEnumerable<T> sequence)
        {
            if (sequence is IList<T> list)
            {
                return list[list.Count / 2];
            }
            else if (sequence is null)
            {
                throw new ArgumentNullException(nameof(sequence), "Sequence can`t be null.");
            }
            else
            {
                int halfLength = sequence.Count() / 2 - 1;
                if (halfLength < 0) halfLength = 0;
                return sequence.Skip(halfLength).First();

            }
        }
        public State PerformOperation(Operation Command) =>
            Command switch
            {
                Operation.SystemTest => RunDiagnostics(),
                Operation.Start => StartSystem(),
                Operation.Stop => StopSystem(),
                Operation.Reset => ResetToReady(),
                _ => throw new ArgumentException("Invalid enum value for command", nameof(command)),
            };

    }
}