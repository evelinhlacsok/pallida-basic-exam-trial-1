using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace UrlsFromHandles_practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a list of GitHub handles as input and returns a list of strings that represents
            // GitHub url's under Green Fox Academy organization in the following format: 
            //"https://github.com/greenfox-academy/teststudent"

            // example:
            // input: ["ghhandle1", "ghhandle2"]
            // output: ["https://github.com/greenfox-academy/ghhandle1", "https://github.com/greenfox-academy/ghhandle2"]
            List<string> gitHubUrls = UrlsFromHandles(new List<string> {"ghhandle1", "ghhandle2"});

            foreach (var userurl in gitHubUrls)
            {
                Console.WriteLine(userurl);
            }
        }

        private static List<string> UrlsFromHandles(List<string> handle)
        {
            for (int i = 0; i < handle.Count; i++)
            {
                handle[i] = "https://github.com/greenfox-academy/" + handle[i];
            }
            return handle;
        }
    }
}