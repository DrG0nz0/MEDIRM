using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectScheduling.SolverFoundation
{
    public class ScheduledTask
    {
        public DateTime start { get; private set; }
        public DateTime end { get; private set; }
        public double HourDuration { get; }
        public int JobId { get; internal set; }
        public int ProcessId { get; internal set; }
        public int MachineId { get; internal set; }

        public List<TimeInterval> Breaks = new List<TimeInterval>();

        public ScheduledTask(double start,double end)
        {
            var duration = end - start;
            this.start = AddDays(new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0), start, true);
            this.Breaks = CalculatePeriods(this.start, duration);
            this.end = AddDays(this.start, duration, false);
            this.HourDuration = end - start;
        }

        public static double EntregaFromDate(DateTime time)
        {
            // number of hours
            var startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            var hours = 0.0;
            while (startDate.Date.Year <= time.Date.Year && startDate.Date.DayOfYear < time.Date.DayOfYear)
            {

                var sum = Math.Min(1, time.Subtract(startDate).TotalHours);
                hours += sum;
                var startHolder = startDate;
                startDate = startDate.AddHours(sum);
                startDate = NextWorkingTime(startDate, false);
                //hours += startDate.Subtract(startHolder).TotalHours;
            }
            return hours;
        }

        private List<TimeInterval> CalculatePeriods(DateTime start, double hours)
        {
            var end = start;
            while (hours > 0)
            {
                var hoursHolder = hours;
                var increHours = Math.Min(hours, 1);

                double hoursOffset;
                var nextWorkingTime = NextWorkingTime(end,false, out hoursOffset);
                if (double.IsNaN(hoursOffset))

                {
                    hours -= increHours;
                   end = end.AddHours(increHours);
                }
                else
                {
                    hours += hoursOffset;
                    var h = end;
                    end = end.AddHours(-hoursOffset);
                    if (h > end)
                        throw new Exception("NOt");

                    if (end < start)
                        throw new Exception("NOt");
                    Breaks.Add(new TimeInterval(start, end));

                    start = nextWorkingTime;
                    end = nextWorkingTime;

                }
                if (hours == 0)
                {
                    if (end < start)
                        throw new Exception("NOt");
                    Breaks.Add(new TimeInterval(start, end));
                }

            }
            return this.Breaks;
        }

        public IEnumerable<TimeInterval> Merge(IEnumerable<TimeInterval> spans, int duration)
        {
            var stack = new Stack<TimeInterval>();

            stack.Push(spans.First());

            foreach (var span in spans.Skip(1))
                foreach (var interval in stack.Pop().Merge(span)) //this enumeration is guaranteed to have either one element or two elements.
                    stack.Push(interval);

            return from interval in stack where interval.Duration >= duration select interval;
        }

        public sealed class TimeInterval
        {
            public DateTime Start { get; private set; }
            public DateTime End { get; private set; }
            public double Duration { get; private set; }

            public TimeInterval(DateTime start, int duration)
            {
                Start = start;
                Duration = duration;
            }

            public TimeInterval(DateTime start, DateTime end)
            {
                Start = start;
                End = end;
                Duration = end.Subtract(start).Minutes;
            }

            public IEnumerable<TimeInterval> Merge(TimeInterval that)
            {
                if (that.Start >= this.Start && that.Start <= this.End)
                {
                    if (that.End > this.End)
                        Duration += (that.Duration - (this.End - that.Start).TotalMinutes);

                    yield return this;
                }
                else
                {
                    yield return this;
                    yield return that;
                }
            }
        }


        private DateTime AddDays(DateTime start, double hours, bool isStart)
        {
            while (hours > 0)
            {
                if (hours > 1)
                {
                    start = start.AddHours(1);
                    start = NextWorkingTime(start, false);
                    hours -= 1.0;
                }
                else
                {
                    start = start.AddHours(hours);
                    if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
                    {
                        TimeSpan duration = start.TimeOfDay - TimeSpan.FromHours(17);
                        start = NextWorkingTime(start, isStart).Add(duration);
                    }
                    hours = 0;
                }
            }
            start = NextWorkingTime(start, isStart);
            return start;
        }

        public static DateTime NextWorkingTime(DateTime start, bool isStart)
        {
            if (start.TimeOfDay >= TimeSpan.FromHours(isStart ? 17 : 17.01))
            {
                start = start.Date.AddHours(24 + 8);
            }
            else if (start.Hour < 8)
            {
                start = start.Date.AddHours(8);
            }

            while (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }
            return start;
        }

        public static DateTime NextWorkingTime(DateTime start, bool isStart, out double offset)
        {
            offset = double.NaN;

            var holder = start;
            if (start.TimeOfDay >= TimeSpan.FromHours(18))
            {
                var today = new DateTime(start.Year, start.Month, start.Day, 18, 0, 0);
                offset = today.Subtract(start).TotalHours;
                start = start.Date.AddHours(24 + 8);
            }
            else if (start.Hour < 8)
            {
                start = start.Date.AddHours(8);
            }

            while (start.DayOfWeek == DayOfWeek.Saturday || start.DayOfWeek == DayOfWeek.Sunday)
            {
                start = start.AddDays(1);
            }
            return start;
        }
    }
}