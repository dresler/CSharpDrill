using System;

namespace CSharpDrill
{
    public sealed class TagsAttribute : Attribute
    {
        public string[] Tags { get; }

        public TagsAttribute(params string[] tags)
        {
            Tags = tags;
        }
    }
}