﻿using UnityEngine;
using System.Collections;
using System;

public abstract class FurnitureController : Agent {

    FurnitureType ourFurnitureType;

    EnemyCollection enemyCollection;
    GuardCollection guardCollection;

    protected void initialize(FurnitureType ourFurnitureType, Map parentMap, GridPosition initialGridPosition, float agentScale, FurnitureCollection enclosingCollection, EnemyCollection enemyCollection, GuardCollection guardCollection)
    {
        base.initialize(parentMap, initialGridPosition, agentScale, enclosingCollection);
        this.enemyCollection = enemyCollection;
        this.guardCollection = guardCollection;
    }

    protected void initialize(FurnitureType ourFurnitureType, Map parentMap, GridPosition initialGridPosition, float agentScale, EnemyCollection enemyCollection, GuardCollection guardCollection)
    {
        initialize(ourFurnitureType, parentMap, initialGridPosition, agentScale, null, enemyCollection, guardCollection);
    }

    protected override float getAddedVisibilityValue(float otherAgentDistance)
    {
        throw new NotImplementedException();
    }

    public FurnitureType getFurnitureType()
    {
        return ourFurnitureType;
    }
}

public enum FurnitureType { rest=0 };