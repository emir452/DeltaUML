﻿using System;

namespace core.diagrams.sequenceDiagram
{
    [Serializable]
    public class ObjectDeclaration
    {
        public string objectName { get; set; }
        public string className { get; set; }
        public override string ToString()
        {
            return objectName;
        }
    }
}
