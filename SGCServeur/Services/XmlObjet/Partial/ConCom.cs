namespace SGCServeur.Services
{
    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConCom
    {

        private string codeField;

        private string libelleField;

        private string descriptionField;

        private System.DateTime dateInsertionField;

        private System.DateTime dateMajField;

        private int indiceField;

        private bool indiceFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
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
        public string Libelle
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
        public string Description
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
        public System.DateTime DateInsertion
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime DateMaj
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int Indice
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
        public bool IndiceSpecified
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
