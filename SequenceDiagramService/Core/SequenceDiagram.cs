using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using DeltaUMLSdk;
namespace SequenceDiagramService.Core
{
    [Serializable]
    public class SequenceDiagram : Diagram
    {
        public List<ObjectDeclaration> objectDeclarations { get; set; }
        public List<InteractionDetail> interactionDetails { get; set; }
                public SequenceDiagram()
        {
            objectDeclarations = new List<ObjectDeclaration>();
            interactionDetails = new List<InteractionDetail>();
        }


    }
}
