﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Xunit;

namespace CSharpDrill.Intermediate
{
    public class KnowYourTypesTests
    {
        // Tasks: 
        // 1. Check types in each InlineData row. 
        // If needed, fix the third argument ("expected") to make the test valid.
        // "true" means that "type" is a subclass of "baseType".
        // 2. Implement logic to get isSubclass and verify your expectations.

        [Theory]
        [InlineData(typeof(object), typeof(object), false)]
        [InlineData(typeof(System.Object), typeof(object), true)]
        [InlineData(typeof(int), typeof(object), true)]
        [InlineData(typeof(object), typeof(List<int>), false)]
        [InlineData(typeof(int), typeof(System.ValueType), true)]
        [InlineData(typeof(string), typeof(System.ValueType), true)]
        [InlineData(typeof(char), typeof(System.ValueType), false)]
        [InlineData(typeof(decimal?), typeof(decimal), true)]
        [InlineData(typeof(Nullable<>), typeof(System.ValueType), true)]
        [InlineData(typeof(DateTime), typeof(System.ValueType), true)]
        [InlineData(typeof(Enum), typeof(System.ValueType), false)]
        [InlineData(typeof(Foo), typeof(System.ValueType), false)]
        [InlineData(typeof(Foo), typeof(Bar), false)]
        [InlineData(typeof(Bar), typeof(Baz), true)]
        [InlineData(typeof(Do), typeof(System.ValueType), false)]
        [InlineData(typeof(Action), typeof(Delegate), false)]
        [InlineData(typeof(Action<int>), typeof(Action), true)]
        [InlineData(typeof(FileStream), typeof(Stream), true)]
        [InlineData(typeof(ParameterizedThreadStart), typeof(System.ValueType), false)]
        [InlineData(typeof(List<Baz>), typeof(List<Bar>), true)]
        public void IsSubclassOf_ForGivenTypes_ShouldReturnExpected(Type type, Type baseType, bool expected)
        {
            throw new NotImplementedException();

            var isSubclass = /* Implement */false; 
            Assert.Equal(expected, isSubclass);
        }

        public struct Foo { }
        public class Bar { }
        public class Baz : Bar { }
        public delegate void Do();
    }
}