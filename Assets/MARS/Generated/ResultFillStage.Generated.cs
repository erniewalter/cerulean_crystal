// This file is automatically generated - DO NOT EDIT MANUALLY!
using System.Collections.Generic;
using Unity.MARS.Data;

namespace Unity.MARS.Query
{
    partial class ResultFillTransform
    {
        internal static void FillQueryResultInternal(int dataId, ProxyConditions conditions, CachedTraitCollection traits,
            QueryMatchID matchId, QueryResult result)
        {
            traits.TryGetType(out List<Dictionary<int, System.Int32>> intCollections);
            conditions.TryGetType(out ICondition<System.Int32>[] intConditions);
            FillQueryResult<System.Int32>(dataId, intConditions, intCollections, result);

            traits.TryGetType(out List<Dictionary<int, System.Single>> floatCollections);
            conditions.TryGetType(out ICondition<System.Single>[] floatConditions);
            FillQueryResult<System.Single>(dataId, floatConditions, floatCollections, result);

            traits.TryGetType(out List<Dictionary<int, System.String>> stringCollections);
            conditions.TryGetType(out ICondition<System.String>[] stringConditions);
            FillQueryResult<System.String>(dataId, stringConditions, stringCollections, result);

            traits.TryGetType(out List<Dictionary<int, UnityEngine.Pose>> poseCollections);
            conditions.TryGetType(out ICondition<UnityEngine.Pose>[] poseConditions);
            FillQueryResult<UnityEngine.Pose>(dataId, poseConditions, poseCollections, result);

            traits.TryGetType(out List<Dictionary<int, UnityEngine.Vector2>> vector2Collections);
            conditions.TryGetType(out ICondition<UnityEngine.Vector2>[] vector2Conditions);
            FillQueryResult<UnityEngine.Vector2>(dataId, vector2Conditions, vector2Collections, result);
        }
    }
}