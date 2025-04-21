using SprintFlow.Domain.Entities;
using SprintFlow.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace SprintFlow.Application.Services
{
    public class SprintService
    {
        private readonly ISprintRepository _sprintRepository;

        public SprintService(ISprintRepository sprintRepository)
        {
            _sprintRepository = sprintRepository;
        }

        public void CreateSprint(Sprint sprint)
        {
            _sprintRepository.Add(sprint);
        }

        public IEnumerable<Sprint> GetAll()
        {
            return _sprintRepository.GetAll();
        }

        public IEnumerable<Sprint> GetByBoardId(Guid boardId)
        {
            return _sprintRepository.GetByBoardId(boardId);
        }
    }
}
