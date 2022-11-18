namespace homepage;

public class Project
{
    public Project(string title, string description, string imagePath, string[] tags, string url)
    {
        this.title = title;
        this.description = description;
        this.imagePath = imagePath;
        this.tags = tags;
        this.url = url;
    }

    public Project(Project project)
    {
        this.title = project.title;
        this.description = project.description;
        this.imagePath = project.imagePath;
        this.tags = project.tags;
        this.url = project.url;
    }

    public string title { get; set; }
    public string description { get; set; }
    public string imagePath { get; set; }
    public string[] tags { get; set; }
    public string url { get; set; }
}