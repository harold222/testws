using System.Xml.Serialization;

namespace WSGYG63.Models.UpdateBP
{
    public class UpdateBPResponse
    {
        [XmlElement(ElementName = "BPARTNER")]
        public string Bpartner { get; set; }

        [XmlElement(ElementName = "FIRSTNAME")]
        public string FirstName { get; set; }

        [XmlElement(ElementName = "MIDDLENAME")]
        public string MiddleName { get; set; }

        [XmlElement(ElementName = "LASTNAME")]
        public string LastName { get; set; }

        [XmlElement(ElementName = "SECONDNAME")]
        public string SecondName { get; set; }

        [XmlElement(ElementName = "SEARCHTERM1")]
        public string SearchTerm1 { get; set; }

        [XmlElement(ElementName = "POSTL_COD1")]
        public string Postl_Cod1 { get; set; }

        [XmlElement(ElementName = "STREET")]
        public string Street { get; set; }

        [XmlElement(ElementName = "CITY")]
        public string City { get; set; }

        [XmlElement(ElementName = "COUNTRY")]
        public string Country { get; set; }

        [XmlElement(ElementName = "REGION")]
        public string Region { get; set; }

        [XmlElement(ElementName = "LANGU")]
        public string Langu { get; set; }

        [XmlElement(ElementName = "TELEPHONE")]
        public string Telephone { get; set; }

        [XmlElement(ElementName = "MOVIL")]
        public string Movil { get; set; }

        [XmlElement(ElementName = "FAX")]
        public string Fax { get; set; }

        [XmlElement(ElementName = "EMAIL")]
        public string Email { get; set; }

        [XmlElement(ElementName = "SEX")]
        public string Sex { get; set; }

        [XmlElement(ElementName = "ESTADO")]
        public string State { get; set; }

        [XmlElement(ElementName = "FECHA_NAC")]
        public string BirthDate { get; set; }

        [XmlElement(ElementName = "NIF")]
        public string Nif { get; set; }

        [XmlElement(ElementName = "TIPOID")]
        public string TypeId { get; set; }

        [XmlElement(ElementName = "PET_BORRADO")]
        public string DeletePet { get; set; }

        [XmlElement(ElementName = "CLAVE_GRPO")]
        public string GrpKey { get; set; }

        [XmlElement(ElementName = "LONGITUD")]
        public string Length { get; set; }

        [XmlElement(ElementName = "LATITUD")]
        public string Latitude { get; set; }
    }
}
