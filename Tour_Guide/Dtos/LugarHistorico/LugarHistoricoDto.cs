public class LugarHistoricoDto : DtoBase
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string Horario { get; set; }
    public string ImagenUrl { get; set; }

    public bool Validar(out string error)
    {
        if (string.IsNullOrWhiteSpace(Nombre))
        {
            error = "El nombre es obligatorio.";
            return false;
        }

        if (string.IsNullOrWhiteSpace(Descripcion))
        {
            error = "La descripción es obligatoria.";
            return false;
        }

        error = string.Empty;
        return true;
    }
}
