﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeEditorApp.Models.Entity
{
    public class Project
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string AspNetUserID { get; set; }
        public int ProjectTypeID { get; set; }
      /*  public virtual AspNetUser user { get; set; }*/
        public virtual ProjectType projectType { get; set; }
     /*   public virtual ICollection<AspNetUser> users { get; set; }*/
        public virtual ICollection<File> files { get; set; }
        public virtual ICollection<Goal> goals { get; set; }
        public virtual ICollection<Goal> objectives { get; set; }
        public virtual ICollection<Comment> comments { get; set; }
    }
}