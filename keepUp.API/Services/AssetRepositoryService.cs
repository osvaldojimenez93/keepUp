using Microsoft.Azure.Cosmos;

namespace keepUp.API.Services;

public class AssetRepositoryService
{
    private readonly CosmosClient _cosmosClient;
    private readonly Container _container;

    public AssetRepositoryService(CosmosClient cosmosClient)
    {
        _cosmosClient = cosmosClient;
        var database = _cosmosClient.GetDatabase("keepUpDB");
        _container = database.GetContainer("Assets");
    }

    public async Task CreateAssetAsync<T>(T asset)
    where T : class
    {
        if (asset == null) throw new ArgumentNullException(nameof(asset));

        try
        {
            await _container.CreateItemAsync(asset);
        }
        catch (CosmosException ex)
        {
            // Handle exceptions as needed
            throw new Exception($"Error creating asset: {ex.Message}", ex);
        }
    }
}
