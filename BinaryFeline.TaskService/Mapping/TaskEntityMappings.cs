
using System;
using BinaryFeline.TaskService.Models;
using BinaryFeline.TaskService.Models.Task;
using LanguageExt;
using LanguageExt.UnsafeValueAccess;

namespace BinaryFeline.TaskService.Mapping;

// No standalone functions allowed in C# so we use a static utility class.
public static class TaskMappings {

    // Over simplified. Need OneOf (discriminated union) here.
    public static TaskDTO MapTaskEntityToTaskDTO (TaskEntity taskEntity)
    {
         String longDescValue = taskEntity.LongDesc.Match(
                    Some: x => x.Description,
                    None: () => String.Empty);

        TaskDTO result = new TaskDTO(taskEntity.Id, taskEntity.ShortDesc.Value, longDescValue);

        return result;

    }

    // TODO: Make a discriminated union return type. Data can easily be bad in the db.
    public static TaskEntity MapTaskDTOToTaskEntity(TaskDTO dto)
    {
        Option<LongDescType2> longDescValue = dto.LongDesc switch
        {
            null => Option<LongDescType2>.None,
            "" => Option<LongDescType2>.None,
            _ => Option<LongDescType2>.Some(LongDescType2.Create(dto.LongDesc))
        };

        TaskEntity result = new TaskEntity(dto.Id, ShortDescType.From(dto.ShortDesc), longDescValue);

        return result;
    }

}
