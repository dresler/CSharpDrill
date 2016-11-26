using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace CSharpDrill.Intermediate
{
    [Tags("Enum", "Attribute", "Extension method")]
    public class AttributesForEnum
    {
        // - Uncomment content of the test method.
        // - Create RequiredSkill attribute class and use it for decorating DeveloperType values (see the example for BackEndDeveloper).
        // - Create an extension method for a DeveloperType value that returns required skills as IReadOnlyCollection<DeveloperSkillType>.
        // - All tests must pass.

        [Theory]
        [InlineData(DeveloperType.BackEndDeveloper, new [] { DeveloperSkillType.CSharp, DeveloperSkillType.VisualBasic, DeveloperSkillType.MsSql })]
        [InlineData(DeveloperType.FrontEndDeveloper, new [] { DeveloperSkillType.CSharp, DeveloperSkillType.JavaScript, DeveloperSkillType.Mvc, DeveloperSkillType.React })]
        [InlineData(DeveloperType.ServiceDeveloper, new [] { DeveloperSkillType.CSharp, DeveloperSkillType.MsSql, DeveloperSkillType.SoapRest })]
        [InlineData(DeveloperType.FakeDeveloper, new DeveloperSkillType[0])]
        public void GetRequiredSkills_ForDeveloperType_ShouldReturnExpected(DeveloperType developerType, DeveloperSkillType[] expectedDeveloperSkills)
        {
            //var result = developerType.GetRequiredSkills();
            //result.ShouldBeEquivalentTo(expectedDeveloperSkills);
        }
    }

    public enum DeveloperSkillType
    {
        CSharp,
        VisualBasic,
        MsSql,
        SoapRest,
        Mvc,
        React,
        JavaScript
    }

    public enum DeveloperType
    {
        //[RequiredSkill(DeveloperSkillType.CSharp)]
        BackEndDeveloper,

        FrontEndDeveloper,

        ServiceDeveloper,

        FakeDeveloper
    }
}
