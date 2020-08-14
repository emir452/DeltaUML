using System;

namespace core.diagrams.sequenceDiagram
{
    [Serializable]
    public class InteractionDetail
    {
        public ObjectDeclaration sender { get; set; }
        public ObjectDeclaration receiver { get; set; }
        public string METHOD { get; set; }
    }
}
