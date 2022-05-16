﻿using System.ComponentModel.DataAnnotations;

namespace trackingApi.Models
{
    public class Issue
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IssueType IssueType { get; set; }
        public DateTime Created{ get; set; }
        public DateTime? Completed { get; set; }
    }
    public enum Priority
    {
        Low, Medium, High
    }
    public enum IssueType
    {
        Feature, Bug, Documentation
    }
}
