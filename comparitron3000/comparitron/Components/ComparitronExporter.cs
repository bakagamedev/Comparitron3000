﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace comparitron
{
    public class ComparitronExporter
    {
        ComparitronCore comparitron = null;
        Settings settings = null;
        public bool Running { get; private set; } = false;
        public string log { get; private set; } = "";

        public ComparitronExporter(ComparitronCore comparitron, Settings settings)
        {
            this.settings = settings;
            this.comparitron = comparitron;
        }

        public void Run()
        {
            log = "";
            Running = true;

            //Create directory and file 
            string basePath = comparitron.BasePath;
            string outPath = comparitron.BasePath + @"/output/";
            string outFile = outPath + comparitron.ProjectID + ".php";

            if(!Directory.Exists(outPath))
            {
                Directory.CreateDirectory(outPath);
            }

            //Start writing to it
            using (var output = new StreamWriter(outFile))
            {
                log += "Starting write..." + "\r\n";

                output.WriteLine(@"<!-- Generated with Comparitron3000 page builder -->");

                //Write header and page parameters
                output.WriteLine(@"<?php");
                output.WriteLine(@"$publishyear = '" + DateTime.Now.Year + @"';");
                output.WriteLine(@"$author = '" + settings.AuthorName + @"';");
                output.WriteLine("$contentname = \"" + comparitron.ProjectTitle + "\";");
                output.WriteLine(@"$pagename = $contentname;");
                output.WriteLine(@"$pagetype = 'comparison';");
                output.WriteLine(@"$contentpath = '';");
                output.WriteLine(@"$thumbpath = '/images/thumbs/" + comparitron.ProjectID + @".jpg';");
                output.WriteLine(@"$lastpage = '" + comparitron.PathPrevious + "';"); 
                output.WriteLine(@"$nextpage= '" + comparitron.PathNext + "';");
                output.WriteLine(@"?>");
                output.WriteLine(@"<?php include '" + settings.PathHeader + "';?>");
                
                //Page elements from list
                output.WriteLine(@"<ol>");

                log += "Items : " + comparitron.itemList.Count + "\r\n";
                for (var i=0; i<comparitron.itemList.Count; ++i)
                {
                    ComparitronItem item = comparitron.itemList[i];
                    ComparitronItem nextItem = null;
                    ComparitronItem prevItem = null;

                    log += i.ToString() + " : " + item.Type.ToString() + "\r\n";

                    //Find next item
                    if(i < comparitron.itemList.Count- 1)
                    {
                        nextItem = comparitron.itemList[i + 1];
                    }
                    //Find previous item (oooh)
                    if(i > 0)
                    {
                        prevItem = comparitron.itemList[i - 1];
                    }

                    switch (item.Type)
                    {
                        case ItemType.Comparison:
                            {
                                /*
                                 If this has no text and was was preceded by a comparison frame, append to the previous
                                 otherwise, don't.
                                */
                                if (!((prevItem != null) && (prevItem.Type == ItemType.Comparison) && (item.Text == "")))
                                {
                                    output.Write(@"<li>");
                                }
                                output.Write(item.Text);

                                string tvline = @"<img src='/images/" + comparitron.ProjectID + "/" + settings.TVPrefix + item.Frame.ToString("D5") + "." + settings.ImageFormat + @"'/>";
                                string bdline = @"<img src='/images/" + comparitron.ProjectID + "/" + settings.BDPrefix + item.Frame.ToString("D5") + "." + settings.ImageFormat + @"'/>";

                                output.Write("<div class=\"twentytwenty-container\">");
                                output.Write(tvline);
                                output.Write(bdline);
                                
                                /*
                                 If this is the last entry, end the list item.
                                 If it's followed by something that isn't a comparison frame, end
                                 If it's followed by a comparison frame with a caption, end
                                */
                                if((nextItem == null) || (nextItem.Type != ItemType.Comparison) || ((nextItem.Type == ItemType.Comparison) && (!string.IsNullOrEmpty(nextItem.Text))))
                                {
                                    output.Write("</div>");
                                    output.WriteLine(@"</li>");
                                }
                                else
                                {
                                    output.WriteLine("</div>");
                                }
                            }; break;
                        case ItemType.Text:
                            {
                                output.Write(@"<li>");
                                output.Write(item.Text);
                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Image:
                            {
                                output.Write(@"<li>");
                                output.Write(@"<img src='{0}' title='{1}' />", item.Image, item.Text);
                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Video:
                            {
                                output.Write(@"<li>");

                                output.Write(@"<video width='auto' {0}>", item.Text);
                                output.Write(@"<source src='{0}' type='video/webm'>",item.Video);

                                //Fallback image
                                if (!string.IsNullOrEmpty(item.Image))
                                    output.Write(@"<img src='{0}' style='max-width: 100%'>", item.Image);

                                output.Write(@"</video>");

                                output.WriteLine(@"</li>");
                            }; break;
                        case ItemType.Divider:
                            {
                                output.WriteLine(@"<li><hr/></li>");
                            }; break;
                    }
                }
                output.WriteLine(@"</ol>");

                //Insert lower template
                output.WriteLine(@"<?php include '" + settings.PathFooter + "';?>");

                log += "Done! \r\n";
            }

            //Move image files
            string TVPath = basePath + @"\" + settings.TVFolder + @"\";
            string BDPath = basePath + @"\" + settings.BDFolder + @"\";

            if (Directory.Exists(TVPath) && (Directory.Exists(BDPath)))
            {
                string imagePath = basePath + @"\output\images\" + comparitron.ProjectID + @"\";
                log += "Moving image files..." + "\r\n";

                if (!Directory.Exists(imagePath))
                    Directory.CreateDirectory(imagePath);

                foreach (var line in comparitron.itemList)
                {
                    if (line.Type == ItemType.Comparison)
                    { 
                        string tvName = string.Format("{0}{1:D5}.{2}", settings.TVPrefix, line.Frame, settings.ImageFormat);
                        string bdName = string.Format("{0}{1:D5}.{2}", settings.BDPrefix, line.Frame, settings.ImageFormat);

                        log += "Moving " + tvName + " from " + TVPath +" to " + imagePath + "\r\n";
                        if (File.Exists(TVPath + tvName))
                        { 
                            File.Copy(TVPath + tvName, imagePath + tvName, true);
                        }
                        log += "Moving " + tvName + " from " + TVPath + " to " + imagePath + "\r\n";
                        if (File.Exists(BDPath + bdName))
                        {
                            File.Copy(BDPath + bdName, imagePath + bdName, true);
                        }
                    }
                }
                log += "Done! \r\n";
            }

            log += "Export complete, go home \r\n";

            Running = false;
        }

    }
}
