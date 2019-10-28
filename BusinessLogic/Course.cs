﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string courseName;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get
            {
                return courseName;
            }
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException("Course name can not be null");
                }
                else
                {
                    courseName = value;
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits { get; set; }

    }
}
