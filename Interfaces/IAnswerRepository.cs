using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Application.Interfaces;

public interface IAnswerRepository
{
    Task<List<AnswerDto>> GetAllAsync();
    Task<AnswerDto> GetByIdAsync(int id);

    Task<int> CreateAsync(AnswerDto answerDto);

    Task UpdateAsync(AnswerDto answerDto);
    Task DeleteAsync(int id);
}
