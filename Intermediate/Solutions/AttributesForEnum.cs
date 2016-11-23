using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDrill.Intermediate.Solutions
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var developerTypes = Enum.GetValues(typeof(DeveloperType)).OfType<DeveloperType>();

            foreach (var developerType in developerTypes)
            {
                Console.WriteLine($"{developerType}: {string.Join(",", developerType.GetRequiredSkills())}");
            }

            Console.ReadKey();
        }
    }

    public static class DeveloperTypeExtensions
    {
        public static IEnumerable<RequiredSkill> GetRequiredSkills(this DeveloperType developerType)
        {
            return typeof(DeveloperType).GetField(developerType.ToString()).GetCustomAttributes(typeof(RequiredSkill), false).OfType<RequiredSkill>();
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public sealed class RequiredSkill : Attribute
    {
        public RequiredSkill(DeveloperSkillType developerSkillType)
        {
            SkillType = developerSkillType;
        }

        public DeveloperSkillType SkillType { get; }

        public override string ToString()
        {
            return SkillType.ToString();
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
        [RequiredSkill(DeveloperSkillType.CSharp)]
        [RequiredSkill(DeveloperSkillType.VisualBasic)]
        [RequiredSkill(DeveloperSkillType.MsSql)]
        BackEndDeveloper,

        [RequiredSkill(DeveloperSkillType.CSharp)]
        [RequiredSkill(DeveloperSkillType.JavaScript)]
        [RequiredSkill(DeveloperSkillType.Mvc)]
        [RequiredSkill(DeveloperSkillType.React)]
        FrontEndDeveloper,

        [RequiredSkill(DeveloperSkillType.CSharp)]
        [RequiredSkill(DeveloperSkillType.MsSql)]
        [RequiredSkill(DeveloperSkillType.SoapRest)]
        ServiceDeveloper
    }
}