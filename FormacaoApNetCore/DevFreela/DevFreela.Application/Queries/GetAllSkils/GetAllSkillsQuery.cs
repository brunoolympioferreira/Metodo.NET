using DevFreela.Application.ViewModels;
using MediatR;
using System.Collections.Generic;

namespace DevFreela.Application.Queries.GetAllSkils
{
    public class GetAllSkillsQuery : IRequest<List<SkillViewModel>>
    {
    }
}
