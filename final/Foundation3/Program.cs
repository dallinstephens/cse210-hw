// Reference for assignment:
// https://byui-cse.github.io/cse210-course-2023/unit06/project-plan.html

using System;

class Program
{
    static void Main(string[] args)
    {
        // Reference for BYU Library address:
        // https://lib.byu.edu/faq/244747/
        // Reference for author, title, and description:
        // https://www.youtube.com/watch?v=zb4CQ4W1qnU
        Address address1 = new Address("2060 Lee Lane", "Provo", "Utah", "84602");
        Lecture lecture = new Lecture("President Jeffrey R. Holland", 300, "Safety for the Soul", "How to navagate these turbulent waters that we found ourselves in during these times, the latter-days.", "2/5/24", "3:00 PM", address1);
        Console.WriteLine(lecture.ReturnStandardDetails());
        Console.WriteLine(lecture.ReturnFullDetails());
        Console.WriteLine(lecture.ReturnShortDescription());

        // Reference for University of Utah Institute of Religion Building address:
        // https://www.google.com/search?q=University+of+Utah+Institute+religion+address&sca_esv=588364199&ei=VYtwZYKHNaXikPIP1vC9-A0&ved=0ahUKEwjChdzQiPuCAxUlMUQIHVZ4D98Q4dUDCBA&uact=5&oq=University+of+Utah+Institute+religion+address&gs_lp=Egxnd3Mtd2l6LXNlcnAiLVVuaXZlcnNpdHkgb2YgVXRhaCBJbnN0aXR1dGUgcmVsaWdpb24gYWRkcmVzczIFECEYoAFI-rABUABYxa8BcBJ4AZABAJgBzgGgAZdHqgEGMC42Mi4xuAEDyAEA-AEBwgIREAAYgAQYigUYkQIYsQMYgwHCAhcQLhiABBiKBRiRAhixAxiDARjHARjRA8ICCxAAGIAEGLEDGIMBwgIFEC4YgATCAhEQLhiABBixAxiDARjHARjRA8ICCxAuGIAEGMcBGK8BwgIQEC4YgAQYigUYQxjHARjRA8ICCxAAGIAEGIoFGJECwgIREC4YgAQYigUYkQIYxwEYrwHCAgoQABiABBiKBRhDwgIfEC4YgAQYigUYQxjHARjRAxiXBRjcBBjeBBjgBNgBAcICDhAAGIAEGIoFGJECGMkDwgILEAAYgAQYigUYkgPCAgoQLhhDGIAEGIoFwgIQEC4YgAQYigUYQxjHARivAcICCBAuGIAEGLEDwgIOEC4YgAQYigUYkQIYsQPCAgUQABiABMICCxAuGIAEGLEDGIMBwgIdEC4YgAQYigUYkQIYsQMYlwUY3AQY3gQY4ATYAQHCAggQLhixAxiABMICCBAAGIAEGLEDwgIXEC4YsQMYgAQYlwUY3AQY3gQY4ATYAQHCAg4QABiABBiKBRiRAhixA8ICFxAuGIAEGLEDGJcFGNwEGN4EGOAE2AEBwgIGEAAYFhgewgILEAAYgAQYigUYhgPCAgcQABiABBgNwgIFECEYqwLCAggQIRgWGB4YHcICBxAAGIAEGArCAgsQABgWGB4Y8QQYCsICBhAuGBYYHuIDBBgAIEGIBgG6BgYIARABGBQ&sclient=gws-wiz-serp
        Address address2 = new Address("1780 S Campus Dr", "Salt Lake City", "Utah", "84112");
        Reception reception = new Reception("dallinstephens1@gmail.com", "Wedding Reception", "This is a wedding reception for Dallin Stephens and his recent bride.", "8/7/24", "7:00 PM", address2);
        Console.WriteLine(reception.ReturnStandardDetails());
        Console.WriteLine(reception.ReturnFullDetails());
        Console.WriteLine(reception.ReturnShortDescription());

        // Reference for Tunnel Springs Park address:
        // https://www.google.com/search?q=tunnel+springs+park&sca_esv=588364199&ei=gIxwZbyNHuShkPIP6sWPkAk&gs_ssp=eJzj4tVP1zc0TCorMTFINjUyYLRSNaiwMDc1SjMzMzJKNTc3MkkztDKosEy0TLUwNTC0sEgyNzW3MPYSLinNy0vNUSguKMrMSy9WKEgsygYA7skVfA&oq=Tunne&gs_lp=Egxnd3Mtd2l6LXNlcnAiBVR1bm5lKgIIADIUEC4YrwEYxwEYkQIYyQMYgAQYigUyCxAAGIAEGLEDGIMBMhAQABiABBiKBRhDGLEDGIMBMhAQABiABBiKBRhDGLEDGIMBMgoQABiABBiKBRhDMgoQABiABBiKBRhDMhEQLhiDARjHARixAxjRAxiABDIQEAAYgAQYigUYQxixAxiDATIIEC4YsQMYgAQyCBAAGIAEGLEDMiMQLhivARjHARiRAhjJAxiABBiKBRiXBRjcBBjeBBjgBNgBAUi7hQ9QkCpYkvQOcAF4ApABAJgBmAKgAdgNqgEGMC4xMS4xuAEByAEA-AEBwgIEEAAYR8ICERAAGIAEGIoFGJECGLEDGIMBwgIREC4YgAQYsQMYgwEYxwEY0QPCAg4QABiABBiKBRixAxiDAcICCxAAGIAEGIoFGJECwgIFEC4YgATCAgsQABiABBiKBRiSA8ICDRAAGIAEGIoFGEMYyQPCAg4QABiABBiKBRiRAhixA8ICDhAuGIAEGIoFGLEDGIMBwgIIEC4YgAQYsQPCAgsQLhiABBjHARivAcICDhAuGIAEGLEDGMcBGNEDwgIOEC4YgwEYsQMYgAQYigXCAgsQLhiABBixAxiDAeIDBBgAIEGIBgGQBgi6BgYIARABGBQ&sclient=gws-wiz-serp
        Address address3 = new Address("1080 Eaglepointe Dr", "North Salt Lake", "Utah", "84054");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Partly Cloudy, Chance of Rain: 0%, Low: 32 deg", "Ward Park Lunch Get Together", "The Ward is having a lunch potluck to help members in the Ward get to know each other.", "5/4/24", "1:00 PM", address3);
        Console.WriteLine(outdoorGathering.ReturnStandardDetails());
        Console.WriteLine(outdoorGathering.ReturnFullDetails());
        Console.WriteLine(outdoorGathering.ReturnShortDescription());
    }
}