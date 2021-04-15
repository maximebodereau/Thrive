﻿using System.Collections.Generic;

/// <summary>
///   Allows storing compounds up to the specified capacity
/// </summary>
public interface ICompoundStorage : IEnumerable<KeyValuePair<Compound, float>>
{
    /// <summary>
    ///   The max amount of any compound that can be stored
    /// </summary>
    float Capacity { get; }

    /// <summary>
    ///   Returns the stored amount of the compound in this
    /// </summary>
    float GetCompoundAmount(Compound compound);

    /// <summary>
    ///   Takes some compound out of this bag. Returns the amount
    ///   taken, which can be less than the requested amount.
    /// </summary>
    float TakeCompound(Compound compound, float amount);

    /// <summary>
    ///   Adds some compound amount to this. Returns the amount that
    ///   was added.
    /// </summary>
    float AddCompound(Compound compound, float amount);

    /// <summary>
    ///   Clears the held compounds
    /// </summary>
    void ClearCompounds();

    /// <summary>
    ///   Makes sure no compound amount is negative
    /// </summary>
    void ClampNegativeCompoundAmounts();
}
