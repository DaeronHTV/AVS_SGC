namespace SGC.Export.Common
{

    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConComCommun))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class ConComBase
    {

        private string codeField;

        private string libelleField;

        private string descriptionField;

        private System.DateTime dateInsertionField;

        private bool dateInsertionFieldSpecified;

        private System.DateTime dateMajField;

        private bool dateMajFieldSpecified;

        private int indiceField;

        private bool indiceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string libelle
        {
            get
            {
                return this.libelleField;
            }
            set
            {
                this.libelleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dateInsertion
        {
            get
            {
                return this.dateInsertionField;
            }
            set
            {
                this.dateInsertionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateInsertionSpecified
        {
            get
            {
                return this.dateInsertionFieldSpecified;
            }
            set
            {
                this.dateInsertionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dateMaj
        {
            get
            {
                return this.dateMajField;
            }
            set
            {
                this.dateMajField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dateMajSpecified
        {
            get
            {
                return this.dateMajFieldSpecified;
            }
            set
            {
                this.dateMajFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int indice
        {
            get
            {
                return this.indiceField;
            }
            set
            {
                this.indiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool indiceSpecified
        {
            get
            {
                return this.indiceFieldSpecified;
            }
            set
            {
                this.indiceFieldSpecified = value;
            }
        }
    }
}
