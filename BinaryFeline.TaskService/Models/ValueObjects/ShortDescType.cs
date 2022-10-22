using System;
using ValueOf;

namespace BinaryFeline.TaskService.Models;

public class ShortDescType : ValueOf<String, ShortDescType>
{
    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Value))
            throw new ArgumentException("Value cannot be null or empty");
    }
}
