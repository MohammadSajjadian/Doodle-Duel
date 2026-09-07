using DoodleDuel.Utility;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace DoodleDuel.Services;

public class GameSettingsService(IJSRuntime js)
{
    private const string StorageKey = "settings";
    public async Task<GameSettings> LoadAsync()
    {
        var json = await js.InvokeAsync<string?>("localStorage.getItem", StorageKey);

        if (string.IsNullOrEmpty(json))
            return new GameSettings();

        try
        {
            var settings = JsonSerializer.Deserialize<GameSettings>(json);

            if (settings is null)
                return new GameSettings();

            var context = new ValidationContext(settings);
            var results = new List<ValidationResult>();

            if (!Validator.TryValidateObject(settings, context, results, validateAllProperties: true))
            {
                return new GameSettings();
            }

            return settings;
        }
        catch
        {
            return new GameSettings();
        }
    }
    public async Task<Result> SaveAsync(GameSettings settings)
    {
        try
        {
            var json = JsonSerializer.Serialize(settings);

            await js.InvokeVoidAsync("localStorage.setItem", StorageKey, json);

            return Result.Success;
        }
        catch
        {
            return Result.Failed;
        }
    }
}
