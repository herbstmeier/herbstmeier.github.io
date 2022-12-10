namespace homepage;

public static class ProjectData
{
    public static List<Project> GetProjects()
    {
        var projects = new List<Project>();

        projects.Add(
        new Project(
        "redpoint-title",
        "redpoint-description",
        "img/projects/redpoint.png",
        new String[] { "Angular", "NodeJS", "MySQL", "Sass" },
        "redpoint"));

        projects.Add(
        new Project(
        "portfolio-title",
        "portfolio-description",
        "img/projects/portfolio.png",
        new String[] { "Blazor", "CSS" },
        "portfolio"));

        projects.Add(
        new Project(
        "alarm-title",
        "alarm-description",
        "img/projects/alarm.png",
        new String[] { "Embedded", "Arduino", "C++", "Circuit Design" },
        "alarm"));

        return projects;
    }
}