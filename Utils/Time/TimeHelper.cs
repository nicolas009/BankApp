using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utils.Time
{
    public static class TimeHelper
    {

        /// <summary>
        /// Check if a time range completely includes another
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="duration1"></param>
        /// <param name="start2"></param>
        /// <param name="duration2"></param>
        /// <returns></returns>
        public static bool CheckInclude(DateTime startA, int durationA, DateTime startB, int durationB)
        {

            DateTime endA = startA.AddHours(durationA);

            DateTime endB = startB.AddHours(durationB);

            bool includes = false;

            if (startA <= startB && endA >= endB)
            {
                includes = true;
            }


            return includes;

        }

        /// <summary>
        /// Check if two time ranges overlap
        /// </summary>
        /// <param name="start1"></param>
        /// <param name="duration1"></param>
        /// <param name="start2"></param>
        /// <param name="duration2"></param>
        /// <returns></returns>
        public static bool CheckOverlap(DateTime startA, int durationA, DateTime startB, int durationB)
        {
            DateTime endA = startA.AddHours(durationA);

            DateTime endB = startB.AddHours(durationB);

            bool overlap = false;

            if (startA <= endB && startB <= endA)
            {
                overlap = true;

            }

            return overlap;

        }
    }
}