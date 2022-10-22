using System;
using System.Runtime.InteropServices.ComTypes;
using OneOf;
using BinaryFeline.TaskService.Errors;
using LanguageExt;
using static LanguageExt.Prelude;
using LanguageExt.UnsafeValueAccess;
using Some = OneOf.Types.Some;

namespace BinaryFeline.TaskService.Models.Task;

// Record types are immutable
public class TaskDTO
{
    public Guid Id { get; set; }
    public String ShortDesc { get; set; }
    public String LongDesc { get; set; }

    public TaskDTO(Guid id, String shortDesc, String longDesc)
    {
        Id = id;
        ShortDesc = shortDesc;
        LongDesc = longDesc;
    }
}
