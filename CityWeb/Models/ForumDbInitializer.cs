﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CityWeb.Models
{
    public class ForumDbInitializer : DropCreateDatabaseAlways<CityWebContext>
    {
        protected override void Seed(CityWebContext context)
        {
            Member member1 = new Member { FirstName = "Tony", LastName = "Plueard" };
            Member member2 = new Member { FirstName = "Tammi", LastName = "Plueard" };
            Topic topic1 = new Topic { Category = "For Sale" };
            Topic topic2 = new Topic { Category = "Help Wanted" };
            Message message1 = new Message
            {
                Subject = "Chevy Tahoe",
                Body = "I have a 2010 Chevy Tahoe great condition for a great price",
                Date = DateTime.Now.ToString(),
                From = member1.ToString()
                
            };
            Message message2 = new Message
            {
                Subject = "Scion TC",
                Body = "2012 Scion TC for sale",
                Date = DateTime.Today.ToString(),
                From = member2.ToString()
            };
            Message message3 = new Message
            {
                Subject = "Clerk Needed",
                Body = "Fast paced corner market in need of clerk",
                Date = DateTime.Now.ToString(),
                From = member1.ToString()

            };
            Message message4 = new Message
            {
                Subject = "Programmer Needed",
                Body = "Programmer needed at local IT company",
                Date = DateTime.Now.ToString(),
                From = member1.ToString()

            };
            topic1.Messages.Add(message1);
            topic1.Messages.Add(message2);
            topic2.Messages.Add(message3);
            topic2.Messages.Add(message4);
            context.Topics.Add(topic1);
            context.Topics.Add(topic2);

            base.Seed(context);
        }
    }
}