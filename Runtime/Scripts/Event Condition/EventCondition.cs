using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace SLIDDES.Modular
{
    /// <summary>
    /// All condition values an event can be compared too
    /// </summary>
    public enum EventCondition
    {
        none = 0,

        equalTo = 1,
        notEqualTo = 2,

        greaterThen = 3,
        lesserThen = 4,
        greaterOrEqual = 5,
        lesserOrEqual = 6,

        // String types
        contains = 7,
        containsNot = 8,

        // List types
        countIsEqual = 9,
        countIsNotEqual = 10,

        // Vectors
        equalToX = 11,
        notEqualToX = 12,
        greaterThenX = 13,
        lesserThenX = 14,
        greaterOrEqualToX = 15,
        lesserOrEqualToX = 16,

        equalToY = 17,
        notEqualToY = 18,
        greaterThenY = 19,
        lesserThenY = 20,
        greaterOrEqualToY = 21,
        lesserOrEqualToY = 22,

        equalToZ = 23,
        notEqualToZ = 24,
        greaterThenZ = 25,
        lesserThenZ = 26,
        greaterOrEqualToZ = 27,
        lesserOrEqualToZ = 28,
    }
}
