using HotChocolate.Language;

#nullable enable

namespace HotChocolate.Types;

/// <summary>
/// This interface aggregates the most important attributes of a field.
/// </summary>
public interface IInputFieldInfo : IHasName, IHasFieldCoordinate, IHasRuntimeType
{
    /// <summary>
    /// Gets the type of this input field.
    /// </summary>
    IInputType Type { get; }

    /// <summary>
    /// Gets the default value literal of this field.
    /// </summary>
    IValueNode? DefaultValue { get; }

    /// <summary>
    /// Gets a formatter that shall intercept deserialized values and reformat them.
    /// </summary>
    IInputValueFormatter? Formatter { get; }
}
