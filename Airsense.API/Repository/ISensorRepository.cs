using Airsense.API.Models.Dto.Sensor;
using Airsense.API.Models.Entity;

namespace Airsense.API.Repository;

public interface ISensorRepository
{
    public Task<ICollection<SensorDto>> GetAsync(int roomId, int count, int skip);
    
    public Task<int> CountAsync(int roomId);
    
    public Task<Sensor?> GetByIdAsync(int sensorId);
    
    public Task<Sensor?> GetBySerialNumberAsync(string serialNumber);
    
    public Task UpdateRoomAsync(int sensorId, int roomId);
    
    public Task DeleteRoomAsync(int sensorId);
}