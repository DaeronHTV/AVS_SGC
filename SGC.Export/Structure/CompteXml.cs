﻿namespace SGC.Export.Structure
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     Ce code a été généré par un outil.
    //     Version du runtime :4.0.30319.42000
    //
    //     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
    //     le code est régénéré.
    // </auto-generated>
    //------------------------------------------------------------------------------

    using System.Xml.Serialization;

    // 
    // Ce code source a été automatiquement généré par xsd, Version=4.8.3928.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Comptes
    {

        private ComptesCompte[] compteField;

        private string versionField;

        private System.DateTime dateExportField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Compte")]
        public ComptesCompte[] Compte
        {
            get
            {
                return this.compteField;
            }
            set
            {
                this.compteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dateExport
        {
            get
            {
                return this.dateExportField;
            }
            set
            {
                this.dateExportField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class ComptesCompte
    {

        private string codeField;

        private string mailField;

        private string typeCompteField;

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
        public string mail
        {
            get
            {
                return this.mailField;
            }
            set
            {
                this.mailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeCompte
        {
            get
            {
                return this.typeCompteField;
            }
            set
            {
                this.typeCompteField = value;
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