using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class FileIO : IFileInterface
    {
        public List<string> ReturnMediaFile(string path)
        {
            //initialize the list we'll be returning
            List<string> mediaFile = new List<string>();// This is to look at the file and spit out strings. This is an empt list
                                                        //throw appropriate exepction


            try
            {
                //check to see whether the file exists

                if (!File.Exists(path))

                {
                    throw new FileLoadException("file Not Found", path);
                }

            }

            string line;
            using (StreamReader reader = new StreamReader(path))
            {

                line = reader.ReadLine();

                while (line != null)
                {
                    mediaFile.Add(line); //This reads the line of the same file. 
                }
                line = reader.ReadLine();    // reads the next line   
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("And Exception has happend,please be advised.");

                //write out appropriate message
                //implement

            }
            catch (Exception e) // e is the var the pts to the exceptions
            {
                Console.WriteLine(e);
                //write out the message
                //implement
            }

            return mediaFile; // media file is the list we are building
        }

        //not yet implemented
        public void UpdateMediaFile(List<string> newMedia)
        {
            throw new NotImplementedException();
        }
    }
}



/*Throw an appropriate exception when the file is not found
Open a StreamReader in the folder specified in the path variable that is passed into ReturnMediaFile
Implement a while loop to read the file line by line and add each line to mediaFile
Write a message to be written out when FileNotFoundException is thrown
Write a message to be written when a general exception is thrown */

/*var lines = File.ReadLines(@"Cupcakes.txt");

int[] favoriteNumbers = { 7, 3, 12, 19, 26, 14 };*/
