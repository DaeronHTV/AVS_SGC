namespace SGC.Export.Common
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public abstract partial class ConComCommun : ConComBase
    {

        private int niveauField;

        private System.DateTime dateAcquisitionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int niveau
        {
            get
            {
                return this.niveauField;
            }
            set
            {
                this.niveauField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime dateAcquisition
        {
            get
            {
                return this.dateAcquisitionField;
            }
            set
            {
                this.dateAcquisitionField = value;
            }
        }
    }
}
