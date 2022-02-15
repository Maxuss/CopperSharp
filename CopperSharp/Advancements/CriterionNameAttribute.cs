namespace CopperSharp.Advancements;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal sealed class CriterionNameAttribute : Attribute
{
    public CriterionNameAttribute(string ctr)
    {
        CriterionName = ctr;
    }

    public string CriterionName { get; }
}