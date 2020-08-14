using System;
using System.Collections.Generic;

namespace core.diagrams.sequenceDiagram
{
    [Serializable]
    public class SequenceDiagram : Diagram
    {
        public List<ObjectDeclaration> objectDeclarations { get; set; }
        public List<InteractionDetail> interactionDetails { get; set; }
        public ClassDiagram currentClassDiagram { get; set; }
        public SequenceDiagram()
        {
            objectDeclarations = new List<ObjectDeclaration>();
            interactionDetails = new List<InteractionDetail>();
        }


    }
}
