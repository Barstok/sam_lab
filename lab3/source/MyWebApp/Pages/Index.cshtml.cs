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
    [ViewData]
    public string? imgFile {get; set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(string videoFile, string audioFile, string imgFile)
    {
        this.videoFile = videoFile;
        this.audioFile = audioFile;
        this.imgFile = imgFile;
        ViewData["videoFile"] = this.videoFile;
        ViewData["audioFile"] = this.audioFile;
        ViewData["imgFile"] = this.imgFile;
    }
}
