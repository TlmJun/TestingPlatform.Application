using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Application.Dtos;

public class TestDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public bool IsRepeatable { get; set; } = false;
    public TestType Type { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public required DateTime PublishedAt { get; set; }
    public required DateTime Deadline { get; set; }
    public int DurationMinutes { get; set; }
    public bool IsPublic { get; set; } = false;
    public int PassingScore { get; set; }
    public int MaxAttempts { get; set; }
}