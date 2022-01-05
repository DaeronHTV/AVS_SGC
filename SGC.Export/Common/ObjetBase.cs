namespace SGC.Export.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObjetBase
    {

        private string codeField;

        private string libelleField;

        private System.DateTime dateInsertionField;

        private bool dateInsertionFieldSpecified;

        private System.DateTime dateMajField;

        private bool dateMajFieldSpecified;

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
    }
}
