using BinaryFeline.TaskService;
using BinaryFeline.TaskService.Errors;
using BinaryFeline.TaskService.Models.Task;
using OneOf;
using ValueOf;

namespace TaskServiceRepository;

public class TaskRepository
{
    public OneOf<TaskDTO, EntityFrameworkError, DatabaseError> PersistDTO(TaskDTO dto)
    {
        throw new NotImplementedException();
    }

    public TaskDTO RetrieveDTO(Guid Id)
    {
        throw new NotImplementedException();
    }
}
