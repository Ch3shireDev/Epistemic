using AwesomeAssertions;

namespace Epistemic.Domain.Tests.Unit;

public class KnowledgeFieldHandlerTests
{
    private readonly KnowledgeFieldHandler _handler = new();
    
    [Fact]
    public void Create_GivenKnowledgeField_CreatesKnowledgeField()
    {
        // Arrange
        var knowledgeName = "Classical physics";

        // Act
        var result = _handler.Create(knowledgeName);

        // Assert
        result.Should().NotBeNull();
        result.Name.Should().Be(knowledgeName);
    }
}