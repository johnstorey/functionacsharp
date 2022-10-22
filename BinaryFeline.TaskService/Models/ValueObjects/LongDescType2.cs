using System;

namespace BinaryFeline.TaskService.Models;

public sealed class LongDescType2
{
    public String Description { get; init; }

    private LongDescType2()
    {
        Description = String.Empty;
    }

    private LongDescType2(String value)
    {
        Description = value;
    }

    // A separate function will let us return Result<T> later.
    public static LongDescType2 Create(String value)
    {
        // This will be replaced by Result<T>.
        if (String.IsNullOrEmpty(value))
            throw new ArgumentNullException();

        return new LongDescType2(value);
    }

}
