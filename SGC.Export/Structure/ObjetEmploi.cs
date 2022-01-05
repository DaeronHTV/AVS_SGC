using SGC.Export.Common;

namespace SGC.Export.Structure
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ObjetEmploi
    {

        private string codeField;

        private string libelleField;

        private string descriptionField;

        private System.DateTime dateInsertionField;

        private System.DateTime dateMajField;

        private ServiceBase serviceField;

        private ConComBase[] competencesField;

        private ConComBase[] connaissancesField;

        private int indiceField;

        private bool indiceFieldSpecified;

        /// <remarks/>
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
        public ServiceBase service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Competence", IsNullable = false)]
        public ConComBase[] Competences
        {
            get
            {
                return this.competencesField;
            }
            set
            {
                this.competencesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Connaissance", IsNullable = false)]
        public ConComBase[] Connaissances
        {
            get
            {
                return this.connaissancesField;
            }
            set
            {
                this.connaissancesField = value;
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