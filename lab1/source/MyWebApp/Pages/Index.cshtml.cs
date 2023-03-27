using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [ViewData]
    public string? videoFile {get; set;}
    [ViewData]
    public string? audioFile {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(string videoFile, string audioFile)
    {
        this.videoFile = videoFile;
        this.audioFile = audioFile;
        ViewData["videoFile"] = this.videoFile;
        ViewData["audioFile"] = this.audioFile;
        Console.WriteLine(videoFile);
        Console.WriteLine(audioFile);
    }
}
