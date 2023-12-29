using CarBook.Shared.DTOs.AboutDTOs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents.AboutViewComponents;

public class AboutUsViewComponent : ViewComponent
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;

    public AboutUsViewComponent(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var client = _httpClientFactory.CreateClient();
        var requestUri = new Uri($"{_configuration["BaseApiUrl"]}/api/abouts");
        var response = await client.GetAsync(requestUri);
        
        if (!response.IsSuccessStatusCode) return View();
        
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<List<AboutResultDTO>>(json);
        return View(result);

    }
}