using System;

namespace Roughcut.Atlassian.Interfaces
{
    public interface IArtifact : IAnythingBase
    {

        // artifact info
        public Guid ArtifactKeyId { get; set; }
        public string? ShortKeyId { get; set; }
        public string? ArtifactType { get; }

    }
}
