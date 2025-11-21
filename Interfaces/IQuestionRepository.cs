using TestingPlatform.Application.Dtos;

namespace TestingPlatform.Application.Interfaces;

public interface IQuestionRepository
{
    Task<List<QuestionDto>> GetAllAsync();
    Task<QuestionDto> GetByIdAsync(int id);
    Task<int> CreateAsync(QuestionDto questionDto);
    Task UpdateAsync(QuestionDto questionDto);
    Task DeleteAsync(int id);
}

