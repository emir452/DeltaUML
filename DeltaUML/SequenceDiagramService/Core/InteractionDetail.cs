using System;

namespace SequenceDiagramService.Core 
{
    [Serializable]
    public class InteractionDetail
    {
        public ObjectDeclaration sender { get; set; }
        public ObjectDeclaration receiver { get; set; }
        public string method{ get; set; }
    }
}
