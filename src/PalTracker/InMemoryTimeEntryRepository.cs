using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;
namespace PalTracker
{
    public class InMemoryTimeEntryRepository:ITimeEntryRepository
    {
        public Dictionary<int,TimeEntry> timeentrydict = new Dictionary<int, TimeEntry>();
        public TimeEntry Create(TimeEntry timeEntry) 
        {
            // mantain a unique key for id
            var newid=timeentrydict.Count+1;
            timeEntry.Id=newid;
            timeentrydict.Add(newid,timeEntry);
            return timeEntry;
        }
        public TimeEntry Find(int i)
        {
            var timeentry=timeentrydict.Where(x=>x.Key.Equals(i));
            if( timeentry!=null) 
            {
                return timeentry.FirstOrDefault().Value;
            }
            else 
            {
                return new TimeEntry(Int32.MinValue,Int32.MinValue,Int32.MinValue,DateTime.Now,Int32.MinValue);
            }
           
        }

         public bool Contains(int i)
        {   
            
           return timeentrydict.ContainsKey(i);
            
        }
        public List<TimeEntry> List()
        {
            return timeentrydict.Values.ToList();
        }

        public TimeEntry Update(int i,TimeEntry timeEntry)
        {
            timeEntry.Id = i;

            timeentrydict[i] = timeEntry;

            return timeEntry;
        }
        public void Delete(int i)
        {
            timeentrydict.Remove(i);
        }

    }
}