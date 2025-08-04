public interface ILugarHistoricoService
{
    ServiceResult<List<LugarHistoricoDto>> GetAll();
    ServiceResult<LugarHistoricoDto> GetById(int id);
    ServiceResult Add(LugarHistoricoDto dto);
    ServiceResult Update(int id, LugarHistoricoDto dto);
    ServiceResult Delete(int id);
}
