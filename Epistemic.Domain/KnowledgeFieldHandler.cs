namespace Epistemic.Domain;

public class KnowledgeFieldHandler
{
    public KnowledgeField Create(string knowledgeName)
    {
        return new KnowledgeField
        {
            Name = knowledgeName
        };
    }
}

public class KnowledgeField
{
    public required string Name { get; init; }
}