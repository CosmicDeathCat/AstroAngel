using System.Reflection.Metadata.Ecma335;
using DLS.Api.Utilities.API.Client;
using Microsoft.Extensions.Configuration;
using ZodiacSignDailyHoroscopeApi.Models;
using ZodiacSignDailyHoroscopeApi.Services;
using static System.Console;
namespace Angel_Numbers;

class Program
{
    static async Task Main (string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppContext.BaseDirectory) // Set base path to the root of the application
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        
        var apiSettings = new APISettings();
        configuration.GetSection("ApiSettings").Bind(apiSettings);
        
        WriteLine($"{apiSettings.ApiKey} {apiSettings.BaseUrl}");
        string? response = "";
        WriteLine("Welcome to the AstroAngel program!");
        WriteLine("What is your name?");
        var name = ReadLine();
        WriteLine($"Hello, {name}!");
        WriteLine("Thinking of a number...");
        var numberHandler = new NumberHandler();
        WriteLine(numberHandler.GetNumber());
        
        AngelNumRead.ReadAngelNum(numberHandler.GetNumber());
        
        WriteLine("Would you like a Tarot card reading?");
        try
        {
            while (response?.ToLower() != "yes" && response?.ToLower() != "no")
            {
                WriteLine("Please enter 'yes' or 'no'");
                response = ReadLine();
                if (response?.ToLower() == "yes")
                {
                    var tarotHandler = new TarotHandler();
                    WriteLine("Your Tarot card is:");
                    WriteLine(tarotHandler.GetTarotCard());
                    TarotCardRead.ReadTarotCard(tarotHandler.GetTarotCard());
                    break;
                }

                if (response?.ToLower() == "no")
                {
                    WriteLine("Okay, have a great day!");
                    break;
                }
            }
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }

        try
        {
            WriteLine("Would you like a daily horoscope?");
            response = ReadLine();
            while (!string.IsNullOrWhiteSpace(response))
            {
                if (response?.ToLower() == "yes")
                {
                    ApiClient apiClient = new ApiClient(apiSettings.ApiKey, apiSettings.Host);
                    HoroscopeService horoscopeService = new HoroscopeService(apiClient, apiSettings.BaseUrl);
                    WriteLine("What is your zodiac sign?");
                    var signInput = ReadLine();
                    WriteLine("Your horoscope is:");
                    var horoscope = await horoscopeService.GetHoroscope(signInput);
                    WriteLine(horoscope.HoroscopeText);
                    break;
                }
                if (response?.ToLower() == "no")
                {
                    WriteLine("Okay, have a great day!");
                    break;
                }
            }
        }
        catch (Exception e)
        {
            WriteLine(e.Message);
        }
    }
}