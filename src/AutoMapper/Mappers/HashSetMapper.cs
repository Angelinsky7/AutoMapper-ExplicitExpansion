﻿using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper.Internal;

namespace AutoMapper.Mappers
{
    using static CollectionMapperExpressionFactory;
    public class HashSetMapper : IObjectMapper
    {
        public bool IsMatch(in TypePair context) => context.SourceType.IsEnumerableType() && context.DestinationType.IsSetType();
        public Expression MapExpression(IGlobalConfiguration configurationProvider, ProfileMap profileMap,
            IMemberMap memberMap, Expression sourceExpression, Expression destExpression, Expression contextExpression)
            => MapCollectionExpression(configurationProvider, profileMap, memberMap, sourceExpression, destExpression, contextExpression, typeof(HashSet<>), MapItemExpr);
    }
}