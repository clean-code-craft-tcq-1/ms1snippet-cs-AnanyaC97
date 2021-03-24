using System;
using System.Collections.Generic;

namespace SensorValidate
{
    public class SensorValidator
    {
        public static bool CheckForSuddenValueJump(double value, double nextValue, double maxDelta) {
            if(nextValue - value > maxDelta) {
                return false;
            }
            return true;
        }
        public static bool ValidateSensorReadings(List<Double> values, double maxReading)
        {
            int lastButOneIndex = values.Count - 1;
            for (int i = 0; i < lastButOneIndex; i++)
            {
                if (!CheckForSuddenValueJump(values[i], values[i + 1], maxReading))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckSensorReadings(List<Double> values, double maxReading)
        {
            if (values.Count == 0)
                return false;
            else
                return ValidateSensorReadings(values, maxReading);
        }
    }
}
