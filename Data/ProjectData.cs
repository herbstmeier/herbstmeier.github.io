namespace homepage;

public static class ProjectData
{
    public static List<Project> GetProjects()
    {
        var projects = new List<Project>();

        projects.Add(
        new Project(
        "alarm-title",
        "alarm-description",
        "img/projects/9Mkg.gif",
        new String[] { "birb", "bruh" },
        "birb"));

        projects.Add(
        new Project(
        "alarm-title",
        "alarm-description",
        "img/projects/9Mkg.gif",
        new String[] { "apple", "bruh" },
        "birb"));

        projects.Add(
        new Project(
        "alarm-title",
        "alarm-description",
        "img/projects/9Mkg.gif",
        new String[] { "birb", "cow" },
        "birb"));

        projects.Add(
        new Project(
        "alarm-title",
        "alarm-description",
        "img/projects/9Mkg.gif",
        new String[] { "potato", "bruh" },
        "birb"));

        return projects;
    }
}