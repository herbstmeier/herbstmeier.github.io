namespace homepage;

public static class ProjectData
{
    public static List<Project> GetProjects()
    {
        var projects = new List<Project>();

        projects.Add(
            new Project(
                "redpoint",
                "redpoint-description",
                "img/projects/redpoint.png",
                new String[] { "Angular", "NodeJS", "MySQL", "TypeScript", "HTML", "Sass" },
                "redpoint"
            )
        );

        projects.Add(
            new Project(
                "portfolio-title",
                "portfolio-description",
                "img/projects/portfolio.png",
                new String[] { "Blazor", "C#", "HTML", "CSS" },
                "portfolio"
            )
        );

        projects.Add(
            new Project(
                "alarm-title",
                "alarm-description",
                "img/projects/alarm.png",
                new String[] { "Embedded", "Arduino", "C++", "Circuit Design" },
                "alarm"
            )
        );

        projects.Add(
            new Project(
                "bimeshof website",
                "bimeshof-description",
                "img/projects/bimeshof.png",
                new String[] { "HTML", "JavaScript", "CSS", "PHP" },
                "bimeshof"
            )
        );

        return projects;
    }
}