using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

using System.Text.RegularExpressions;

namespace FTPme.Tools
{
    public class FTPManager
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private Stream ftpStream = null;
        private int bufferSize = 2048;

        public bool Connected = false;

        /* Construct Object */
<<<<<<< HEAD
<<<<<<< HEAD
        public FTPManager(string hostIP, string userName, string password)
        {
            host = hostIP; user = userName; pass = password;

=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
        public FTPManager(string hostAddr, string username, string password)
        {
            int count = 0;
            foreach (char c in hostAddr)
                if (c == '.') count++;

            if (!hostAddr.Contains(@"ftp://"))
                host = @"ftp://";

            if (count == 3)         // if hostAddr is in IPAddress form
                host = hostAddr;
            else
            {
                IPAddress[] ip = Dns.GetHostAddresses(hostAddr);
                for (int i = 0; i < 4; i++)
                {
                    if (i != 3)
                        host += ip[0].GetAddressBytes()[i].ToString() + '.';
                    else
                        host += ip[0].GetAddressBytes()[i].ToString();
                }
            }

            user = username;
            pass = password;
<<<<<<< HEAD
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
        }

        /* Download File */
        public void download(string remoteFile, string localFile)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.DownloadFile;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpStream = ftpResponse.GetResponseStream();
                /* Open a File Stream to Write the Downloaded File */
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                /* Download the File by Writing the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesRead > 0)
                    {
                        localFileStream.Write(byteBuffer, 0, bytesRead);
                        bytesRead = ftpStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                
                localFileStream.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /* Upload File */
        public void upload(string remoteFile, string localFile)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + remoteFile);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                
                ftpStream = ftpRequest.GetRequestStream();
                /* Open a File Stream to Read the File for Upload */
                FileStream localFileStream = new FileStream(localFile, FileMode.Create);
                /* Buffer for the Downloaded Data */
                byte[] byteBuffer = new byte[bufferSize];
                int bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                /* Upload the File by Sending the Buffered Data Until the Transfer is Complete */
                try
                {
                    while (bytesSent != 0)
                    {
                        ftpStream.Write(byteBuffer, 0, bytesSent);
                        bytesSent = localFileStream.Read(byteBuffer, 0, bufferSize);
                    }
                }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                
                localFileStream.Close();
                ftpStream.Close();
                ftpRequest = null;
                Connected = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /* Delete File */
        public void delete(string deleteFile)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + deleteFile);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.DeleteFile;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /* Rename File */
        public void rename(string currentFileNameAndPath, string newFileName)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + currentFileNameAndPath);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.Rename;
                /* Rename the File */
                ftpRequest.RenameTo = newFileName;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /* Create a New Directory on the FTP Server */
        public void createDirectory(string newDirectory)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + newDirectory);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.MakeDirectory;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }

        /* Get the Date/Time a File was Created */
        public string getFileCreatedDateTime(string fileName)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + fileName);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.GetDateTimestamp;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpStream = ftpResponse.GetResponseStream();
                
                StreamReader ftpReader = new StreamReader(ftpStream);
                
                string fileInfo = null;
                /* Read the Full Response Stream */
                try { fileInfo = ftpReader.ReadToEnd(); }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
                /* Return File Created Date Time */
                return fileInfo;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
            return "";
        }

        /* Get the Size of a File */
        public string getFileSize(string fileName)
        {
            try
            {
                
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + fileName);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                
                ftpRequest.Method = WebRequestMethods.Ftp.GetFileSize;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpStream = ftpResponse.GetResponseStream();
                
                StreamReader ftpReader = new StreamReader(ftpStream);
                
                string fileInfo = null;
                /* Read the Full Response Stream */
                try { while (ftpReader.Peek() != -1) { fileInfo = ftpReader.ReadToEnd(); } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
                /* Return File Size */
                return fileInfo;
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            
            return "";
        }

        /* List Directory Contents File/Folder Name Only */
        public List<RowScheme> SchemeRowList(string directory)
        {
            try
            {
                List<RowScheme> rows = new List<RowScheme>();
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + directory);
                 
                ftpRequest.Credentials = new NetworkCredential(user, pass);
<<<<<<< HEAD
<<<<<<< HEAD
               
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = true;
                /* When in doubt, use these options */
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                ftpRequest.ConnectionGroupName = "2";
                
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                
                ftpStream = ftpResponse.GetResponseStream();
                
                StreamReader ftpReader = new StreamReader(ftpStream);
                
                string directoryRaw = null;

                try { while (ftpReader.Peek() != -1) { directoryRaw += ftpReader.ReadLine() + "|"; } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
<<<<<<< HEAD
<<<<<<< HEAD
                
                try { 
                    string[] directoryList = directoryRaw.Split("|".ToCharArray());

                    // =====================================================================================
                    //     [0]       [1]     [2]         [3]            [4]          [5-7]           [8]    ||
                    //  ==RIGHTS==  =HL=    =UID=     == GID ==      == SIZE ==  === DATE ===  == FNAME ==  ||
                    //  drwxrwxr-x    6    1089909    www-data         4096       Dec 18 23:49  templates|  ||
                    //  -rw-rw-r--    1    1089909    www-data            0       Jan 20 03:38  test.txt|   ||
                    // =====================================================================================
                    for (int i = 0; i < directoryList.Length; i++)
                    {                     
                        directoryList[i] = Regex.Replace(directoryList[i], @"\s+", " ");
                        string[] param = directoryList[i].Split(" ".ToCharArray());

                        if (!param[0].Equals("") && (!param[8].Equals('.') || !param[8].Equals("..")))
                            rows.Add(new RowScheme(param[0], param[1], param[2], param[3], param[4], param[8]));
                    }
                    
                    return rows; 

                }
=======
=======
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                Connected = false;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try { string[] directoryList = directoryRaw.Split("|".ToCharArray()); return directoryList; }
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

            return null;
        }

        private bool isDir(string fileName)
        {
            if (fileName.Contains('.'))
                return false;

            return true;
        }

        public DateTime getFileLastModifiedDateTime(string fileName)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(host + "/" + fileName);

            ftpRequest.Credentials = new NetworkCredential(user, pass);
            ftpRequest.Method = WebRequestMethods.Ftp.GetDateTimestamp;

            try
            {
<<<<<<< HEAD
                using (FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse())
                {
                    return response.LastModified;
                }
            }
            catch (Exception exp)
            {
                throw new Exception(String.Format("An error occured getting the timestamp for {0}: {1}<br />", host + "/" + fileName, exp.Message));
=======
                /* Create an FTP Request */
                ftpRequest = (FtpWebRequest)FtpWebRequest.Create(host + "/" + directory);
                /* Log in to the FTP Server with the User Name and Password Provided */
                ftpRequest.Credentials = new NetworkCredential(user, pass);
                Connected = true;
                /* When in doubt, use these options */
                ftpRequest.UseBinary = true;
                ftpRequest.UsePassive = true;
                ftpRequest.KeepAlive = true;
                /* Specify the Type of FTP Request */
                ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
                /* Establish Return Communication with the FTP Server */
                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                /* Establish Return Communication with the FTP Server */
                ftpStream = ftpResponse.GetResponseStream();
                /* Get the FTP Server's Response Stream */
                StreamReader ftpReader = new StreamReader(ftpStream);
                /* Store the Raw Response */
                string directoryRaw = null;
                /* Read Each Line of the Response and Append a Pipe to Each Line for Easy Parsing */
                try { while (ftpReader.Peek() != -1) { directoryRaw += ftpReader.ReadLine() + "|"; } }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
                /* Resource Cleanup */
                ftpReader.Close();
                ftpStream.Close();
                ftpResponse.Close();
                ftpRequest = null;
                Connected = false;
                /* Return the Directory Listing as a string Array by Parsing 'directoryRaw' with the Delimiter you Append (I use | in This Example) */
                try { string[] directoryList = directoryRaw.Split("|".ToCharArray()); return directoryList; }
                catch (Exception ex) { Console.WriteLine(ex.ToString()); }
>>>>>>> 627dfec460d53d4235a82c9f3a26aae68d56dbaf
            }
        }
    }
}
