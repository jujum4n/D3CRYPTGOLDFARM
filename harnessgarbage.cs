// By: Jujuman
// Description: To be used in junction with MicroScan.exe, Runs MicroScan.exe Till it closes (After its run is finished) Then reopens it.
// Requirements: Remouse.exe, Batch file to close remouse, Script files to run remouse, x64bit OS
// Installation:
//              Copy Kill_m.bat to c:\
//              Copy Hard Roll With Ketchup to C:\
//              Copy Remouse Folder to Fake Directory : "C:\Program Files (x86)\TrendMicro"
//              Rename Remouse.exe to MicroScan.exe
//              Copy all the .rms files into: "C:\Program Files (x86)\TrendMicro"
//              Go to C:\ and Either double click Hard roll
//                      Or To Persistent CMD window 
//                      open cmd prompt
//                      type: cd \
//                      type: "Hard Roll With Ketchup.exe"

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Hard_Roll_With_Ketchup
{
    class HardRollKetchup
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>------------------------------------------------------<<");
            Console.WriteLine(">>------[Hardroll-W/-Ketchup-+-v0.1-+-By:Jujuman]-------<<");
            Console.WriteLine(">>------------------------------------------------------<<");
            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Closing any open MicroScan.exe processes");
            // Kill off any running microscan or remouse exes
            ProcessStartInfo processInfo = new ProcessStartInfo("c:\\kill_m.bat");
            processInfo.UseShellExecute = false;
            Process batchProcess = new Process();
            batchProcess.StartInfo = processInfo;
            batchProcess.Start();
            System.Threading.Thread.Sleep(2000); // Wait
            Console.WriteLine("");

            // Setting Up Process handle
            Process[] pname = Process.GetProcessesByName("MicroScan"); // Get the name of the process Should be nothing at this point since MicroScan is not running
            
            // Create new Process to start
            Process process = new Process();
            
            // Creating Start information to launch Fake our process (Arguments, Path to EXE, Hidden Window)
            ProcessStartInfo start = new ProcessStartInfo();
            string dir = "C:\\Program Files (x86)\\TrendMicro"; // Fake Remouse Folder
            start.FileName = dir + @"\MicroScan.exe "; // Fake Remouse
            start.WindowStyle = ProcessWindowStyle.Hidden; // Makes remouse Hidden
            process.StartInfo = start; // Sets our Process handles start information
            
            // Variables 
            int runtotal = 1; // Number of runs started
            int testnum = new Random().Next(10); // Used to decide to run 8 or 9 for the first run
            
            // Scripts to Run
            string script11 = "t11.rms"; // Crypt Run
            //string script10 = "t10.rms"; // Broken Crypt Run
            string script9 = "t9.rms"; // Crypt Run
            string script8 = "t8.rms"; // Cyrpt Run
            //string script10r = "t10repair.rms"; // Crypt Run with Repair Turned off because I have a repair script already
            string scriptr = "repair.rms"; // Repair Script
            string script12 = "t12.rms"; // Crypt Run
            string script13 = "t13.rms"; // Crypt Run
            string script14 = "t14.rms"; // Crypt Run
            string empty_inventory = "empty_inv.rms"; // Empty Inventory Run
            string script15 = "cath1.rms"; // Cathedral Gardens Chest Run


            // Set First Run to Script 14 (Argument for start information)
            start.Arguments = script14;

            if (pname.Length == 0) // If MicroScan is not runnning
            {
                int n = new Random().Next(10); // Generate a number from 0 - 10 to wait for
                n += 3;
                if (n > 10) // Number cant be greater than 12 if it is make it 10
                {
                    n = 10;
                }
                if (n < 3) // Number cant be less than 3 if it is then make it 3
                {
                    n = 3;
                }

                Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ "+ script14);
                System.Threading.Thread.Sleep(n * 1000); // Wait between 3 to 10 seconds randomly

                process.Start(); // Start MicroScan.exe
                pname = Process.GetProcessesByName("MicroScan"); // Get the process name again now it is set to MicroScan and has a length of 1
            }
            
            while(pname.Length!=0) // While the process name has length of 1 meaning Micro scan is running
            {
                pname = Process.GetProcessesByName("MicroScan"); // Check process name because it might have finished executing

                if (pname.Length==0) // If the name is 0
                {
                    Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": MicroScan Has closed");
                    
                    runtotal += 1; // Increment run counter

                    int n = new Random().Next(10); // Generate a number from 0 - 10 to wait for
                    n += 3;
                    if (n > 10) // Number cant be greater than 12 if it is make it 10
                    {
                        n = 10;
                    }
                    if (n < 3) // Number cant be less than 3 if it is then make it 3
                    {
                        n = 3;
                    }
                    // Every 10th run repair
                    if (runtotal % 10 == 0)
                    {
                        start.Arguments = scriptr;
                        Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + scriptr);
                    }
                    // Empty Inventory Every 21 Runs
                    if (runtotal % 21 == 0)
                    {
                        start.Arguments = empty_inventory;
                        Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + empty_inventory);
                    }
                    else if(runtotal %10!=0)
                    {
                        int tor = new Random().Next(9);
                        
                        // Choose which Crypts script to run from (1 Cath script worked in)
                        if (tor == 1)
                        {
                            start.Arguments = script8;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script8);
                        }
                        if (tor == 2 || tor == 5)
                        {
                            start.Arguments = script9;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script9);
                        }
                        if (tor == 3)
                        {
                            start.Arguments = script15;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script15);
                        }
                        if (tor == 4 || tor == 0)
                        {
                            start.Arguments = script13;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script13);
                        }
                        if (tor == 6)
                        {
                            start.Arguments = script12;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script12);
                        }
                        if (tor == 7 || tor == 8)
                        {
                            start.Arguments = script14;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script14);
                        }
                        if (tor == 9)
                        {
                            start.Arguments = script11;
                            Console.WriteLine(">>" + DateTime.Now.ToLongTimeString().ToString() + ": Waiting: " + n + "s" + " before Run:" + runtotal + " w/ " + script11);
                        }
                    }

                    System.Threading.Thread.Sleep(n * 1000); // Wait

                    process.Start(); // Start MicroScan.exe
                    pname = Process.GetProcessesByName("MicroScan"); // Get the process name again now it is set to MicroScan and has a length of 1
                }
            }
        }
    }
}