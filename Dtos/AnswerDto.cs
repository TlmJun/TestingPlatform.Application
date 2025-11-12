using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPlatform.Domain.Enums;

namespace TestingPlatform.Application.Dtos;

public class AnswerDto
{
    public int Id { get; set; }

    public string? Text { get; set; }
    public AnswerType Type { get; set; }
}
