using EventPlanner.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventPlanner.Mvc.App_Start
{
    public class DatabaseFactory
    {
        static DatabaseFactory()
        {
            var Database = new MemoryEventDatabase();

            ScheduledEvent event1 = new ScheduledEvent()
            {
                Name = "Twenty One Pilots Concert",
                Description = "A concert focused around the new album Trench",
                StartDate = new DateTime(2018, 11, 7, 19, 0, 0),
                EndDate = new DateTime(2018, 11, 7, 23, 0, 0),
                IsPublic = false,
            };

            ScheduledEvent event2 = new ScheduledEvent()
            {
                Name = "Family Christmas party",
                Description = "My Family's Christmas party",
                StartDate = new DateTime(2018, 12, 24, 13, 0, 0),
                EndDate = new DateTime(2018, 12, 24, 21, 0, 0),
                IsPublic = false,
            };
            ScheduledEvent event3 = new ScheduledEvent()
            {
                Name = "Rock Climbing Competetion",
                Description = "My first rock climbing competetion",
                StartDate = new DateTime(2018, 12, 14, 18, 0, 0),
                EndDate = new DateTime(2018, 12, 14, 23, 0, 0),
                IsPublic = true,
            };

            Database.Add(event1);
            Database.Add(event2);
            Database.Add(event3);

            _database = Database;
        }

        public static IEventDatabase _database;
    }
}