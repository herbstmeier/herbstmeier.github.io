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

    public static List<String> ExtractTags(List<Project> source)
    {
        List<String> output = new List<String>();

        foreach (var project in source)
        {
            foreach (var tag in project.tags)
            {
                if (!output.Contains(tag))
                {
                    output.Add(tag);
                }
            }
        }
        return output;
    }
    public static List<Project> SortByTags(List<Project> source, List<String> tags)
    {
        List<Project> output = new List<Project>();

        if (tags.Any() == false)
        {
            return source;
        }
        else
        {
            foreach (var project in source)
            {
                foreach (var tag in tags)
                {
                    if (project.tags.Contains(tag) && !output.Contains(project))
                    {
                        output.Add(project);
                    }
                }
            }
            return output;
        }
    }
}