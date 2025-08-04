public class LugarHistoricoService : ILugarHistoricoService
{
    private static List<LugarHistoricoDto> _lugares = new();

    public ServiceResult<List<LugarHistoricoDto>> GetAll()
    {
        return new ServiceResult<List<LugarHistoricoDto>> { Success = true, Data = _lugares };
    }

    public ServiceResult<LugarHistoricoDto> GetById(int id)
    {
        var lugar = _lugares.FirstOrDefault(l => l.Id == id);
        if (lugar == null) return ServiceResult<LugarHistoricoDto>.Fail("Lugar no encontrado");
        return new ServiceResult<LugarHistoricoDto> { Success = true, Data = lugar };
    }

    public ServiceResult Add(LugarHistoricoDto dto)
    {
        if (!dto.Validar(out var error)) return ServiceResult.Fail(error);
        dto.Id = _lugares.Count + 1;
        _lugares.Add(dto);
        return ServiceResult.Ok("Lugar agregado correctamente");
    }

    public ServiceResult Update(int id, LugarHistoricoDto dto)
    {
        if (!dto.Validar(out var error)) return ServiceResult.Fail(error);
        var index = _lugares.FindIndex(l => l.Id == id);
        if (index == -1) return ServiceResult.Fail("Lugar no encontrado");
        dto.Id = id;
        _lugares[index] = dto;
        return ServiceResult.Ok("Lugar actualizado correctamente");
    }

    public ServiceResult Delete(int id)
    {
        var lugar = _lugares.FirstOrDefault(l => l.Id == id);
        if (lugar == null) return ServiceResult.Fail("Lugar no encontrado");
        _lugares.Remove(lugar);
        return ServiceResult.Ok("Lugar eliminado");
    }
}
