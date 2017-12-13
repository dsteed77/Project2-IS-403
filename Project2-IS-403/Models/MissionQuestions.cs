﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project2.Models
{
    [Table("MissionQuestions")]
    public class MissionQuestions
    {
        [Key]
        public int missionquestionID { get; set; }

        [ForeignKey("missionID")]
        public int missionId { get; set; }

        [ForeignKey("userID")]
        public int userID { get; set; }

        public string question { get; set; }
        public string answer { get; set; }

    }
}