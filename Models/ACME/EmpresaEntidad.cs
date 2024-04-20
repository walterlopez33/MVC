using System.ComponentModel.DataAnnotations;

namespace Models.ACME
{
    public class EmpresaEntidad
    {
        [Range(0, int.MaxValue, ErrorMessage = "Debe seleccionar una empresa")]
        [Display(Name = "Codigo")]
        public int IDEmpresa {  get; set; }


        [Required(ErrorMessage ="Debe seleccionar un tipo de empresa")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar un tipo de empresa")]
        [Display(Name = "Tipo empresa")]   
        public int? IDTipoEmpresa { get; set; }


        [Required(ErrorMessage = "El nombre de la empresa es obligatorio")]
        [Display(Name = "Nombre empresa")]
        public string Empresa { get; set; } = string.Empty;


        [Required(ErrorMessage = "La direccion de la empresa es obligatoria")]
        [Display(Name = "Direccion de la empresa")]
        public string Direccion {  get; set; } = string.Empty;


        [Required(ErrorMessage = "El RUC de la empresa es obligatoria")]
        [Display(Name = "RUC")]
        public string RUC {  get; set; } = string.Empty;


        [Required(ErrorMessage = "La fecha de creacion es obligatoria")]
        [Display(Name = "Fecha de creacion")]
        public DateTime FechaCreacion {  get; set; } = DateTime.Now;


        [Required(ErrorMessage = "El presupuesto es obligatorio")]
        [Display(Name = "Presupuesto")]
        public decimal Presupuesto { get; set; }


        public bool Activo {  get; set; } = true;

        //Propiedad de navegacion a TipoEmpresa

        public TipoEmpresaEntidad? TipoEmpresaEntidad { get; set; }
    }
}
