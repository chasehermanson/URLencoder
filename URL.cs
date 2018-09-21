using System;

namespace URLencoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProjectName;
            int good = 0;
            string ActivityName;
            string x = "y";
            while (x == "y")
            {
                Console.WriteLine("Enter The Project Name: ");
                ProjectName = Console.ReadLine();
                good = 0;
                while (good == 0)
                {
                    foreach (char i in ProjectName)
                    {
                        if (i <= (char)1F & i >= (char)00)
                        {
                            Console.WriteLine("Input Invalid! Enter A New Project Name Without Control Characters: ");
                            ProjectName = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            if (i == (char)7F)
                            {
                                Console.WriteLine("Input Invalid! Enter A New Project Name Without Control Characters: ");
                                ProjectName = Console.ReadLine();
                                break;
                            }
                            else
                            {
                                good++;
                            }
                        }
                    }
                }
                Console.WriteLine("Enter The Activity Name: ");
                ActivityName = Console.ReadLine();
                good = 0;
                while (good == 0)
                {
                    foreach (char j in ActivityName)
                    {
                        if (j <= (char)1F & j >= (char)00)
                        {
                            Console.WriteLine("Input Invalid! Enter A New Activity Name Without Control Characters: ");
                            ActivityName = Console.ReadLine();
                            break;
                        }
                        else
                        {
                            if (j == (char)7F)
                            {
                                Console.WriteLine("Input Invalid! Enter A New Activity Name Without Control Characters: ");
                                ActivityName = Console.ReadLine();
                                break;
                            }
                            else
                            {
                                good++;
                            }
                        }
                    }
                }
                ProjectName = ProjectName.Replace("%", "%25");
                ProjectName = ProjectName.Replace(" ", "%20");
                ProjectName = ProjectName.Replace("<", "%3C");
                ProjectName = ProjectName.Replace(">", "%3E");
                ProjectName = ProjectName.Replace("#", "%23");
                ProjectName = ProjectName.Replace("\"", "%22");
                ProjectName = ProjectName.Replace(";", "%3B");
                ProjectName = ProjectName.Replace("/", "%2F");
                ProjectName = ProjectName.Replace("?", "%3F");
                ProjectName = ProjectName.Replace(":", "%3A");
                ProjectName = ProjectName.Replace("@", "%40");
                ProjectName = ProjectName.Replace("&", "%26");
                ProjectName = ProjectName.Replace("=", "%3D");
                ProjectName = ProjectName.Replace("+", "%2B");
                ProjectName = ProjectName.Replace("$", "%24");
                ProjectName = ProjectName.Replace("{", "%7B");
                ProjectName = ProjectName.Replace("}", "%7D");
                ProjectName = ProjectName.Replace("|", "%7C");
                ProjectName = ProjectName.Replace("\\", "%5C");
                ProjectName = ProjectName.Replace("^", "%5E");
                ProjectName = ProjectName.Replace("[", "%5B");
                ProjectName = ProjectName.Replace("]", "%5D");
                ProjectName = ProjectName.Replace("`", "%60");
                ActivityName = ActivityName.Replace("%", "%25");
                ActivityName = ActivityName.Replace(" ", "%20");
                ActivityName = ActivityName.Replace("<", "%3C");
                ActivityName = ActivityName.Replace(">", "%3E");
                ActivityName = ActivityName.Replace("#", "%23");
                ActivityName = ActivityName.Replace("\"", "%22");
                ActivityName = ActivityName.Replace(";", "%3B");
                ActivityName = ActivityName.Replace("/", "%2F");
                ActivityName = ActivityName.Replace("?", "%3F");
                ActivityName = ActivityName.Replace(":", "%3A");
                ActivityName = ActivityName.Replace("@", "%40");
                ActivityName = ActivityName.Replace("&", "%26");
                ActivityName = ActivityName.Replace("=", "%3D");
                ActivityName = ActivityName.Replace("+", "%2B");
                ActivityName = ActivityName.Replace("$", "%24");
                ActivityName = ActivityName.Replace("{", "%7B");
                ActivityName = ActivityName.Replace("}", "%7D");
                ActivityName = ActivityName.Replace("|", "%7C");
                ActivityName = ActivityName.Replace("\\", "%5C");
                ActivityName = ActivityName.Replace("^", "%5E");
                ActivityName = ActivityName.Replace("[", "%5B");
                ActivityName = ActivityName.Replace("]", "%5D");
                ActivityName = ActivityName.Replace("`", "%60");
                Console.WriteLine("https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", ProjectName, ActivityName);
                Console.WriteLine("Enter 'y' If You Would Like To Continue With Another URL.)");
                x = Console.ReadLine();
            }
        }
    }
}