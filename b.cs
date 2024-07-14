using System;
using System.ComponentModel.DataAnnotations;

public class Feedback
{
    public int FeedbackId { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Message { get; set; }
    public DateTime ReceivedDate { get; set; }
}