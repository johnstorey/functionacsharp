using System;
using OneOf;
using BinaryFeline.TaskService.Errors;
using BinaryFeline.TaskService.Models.Task;
using OneOf.Types;

namespace BinaryFeline.TaskService.Models.Task;

// Record types are immutable
public class TaskDTO
{
    public Guid Id { get; set; }
    public string ShortDesc { get; set; }
    public string LongDesc { get; set; }

    public TaskDTO(Guid id, String shortDesc, String longDesc)
    {
        Id = id;
        ShortDesc = shortDesc;
        LongDesc = longDesc;
    }

    public TaskDTO MapRecordToDTO(TaskEntity de)
    {
        TaskDTO result = new TaskDTO(de.Id, de.ShortDesc.Value, de.LongDesc.Value);

        return result;
    }

    public OneOf<TaskEntity, InvalidId, InvalidLongDesc, InvalidShortDesc>  MapDTOToRecord(TaskDTO dto)
    {
        TaskEntity te = new TaskEntity(
            dto.Id,
            ShortDescType.From(dto.ShortDesc),
            LongDescType.From(dto.LongDesc)
            );

        return te;
    }
}
