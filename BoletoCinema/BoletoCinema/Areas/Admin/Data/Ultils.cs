using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoletoCinema.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace BoletoCinema.Areas.Admin.Data
{
    public class Ultils
    {
        public static User getCurrentUser(HttpContext session)
        {
            if (!session.Session.TryGetValue("user",out byte[] _))
            {
                return new User();
            }
            JObject us = JObject.Parse(session.Session.GetString("user"));
            User user = new User();
            user.username = us.SelectToken("username").ToString();
            user.password = us.SelectToken("password").ToString();
            user.rule = Int32.Parse(us.SelectToken("rule").ToString());
            user.displayname = us.SelectToken("displayname").ToString();
            return user;
        }
    }
}
