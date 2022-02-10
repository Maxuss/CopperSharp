namespace CopperSharp.Advancements;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
internal sealed class CriterionNameAttribute : Attribute
{
    public string CriterionName { get; }

    public CriterionNameAttribute(string ctr)
    {
        CriterionName = ctr;
    }
}