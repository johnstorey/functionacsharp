using System;
using LanguageExt;

namespace BinaryFeline.TaskService.Models.Task;

// Unlike a 'record class' a 'record struct' is not immutable by default so you need to specify it as such.
/*readonly record struct*/
public sealed class TaskEntity
{
    public Guid Id { get; init; }
    public ShortDescType ShortDesc { get; init; }
    public Option<LongDescType2> LongDesc { get; init; }

    //
    // Records don't work with OneOf, so we make it impossible to modify the class instead.
    //
    // Implementing "with" as an extension is difficult, so will just have to create new objects.
    // Should just mean coding is longer.
    //
    public TaskEntity(Guid id, ShortDescType shortDesc, Option<LongDescType2> longDesc)
    {
        Id = id;
        ShortDesc = shortDesc;
        LongDesc = longDesc;
    }

}
