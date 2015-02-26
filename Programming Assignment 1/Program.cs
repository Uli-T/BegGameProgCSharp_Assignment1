using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace programmingAssignment1
/// <summary>
/// Programming Assignment 1: Shell Trajectory
/// </summary>
{
    /// <summary>
    /// Programming Assignment 1: Shell Trajectory
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // define constant
            const decimal g = 9.81M; // gravity constant

            // print welcoming message
            Console.WriteLine("Welcome to this game, n00b!");
            
            // let user input initial angle (theta) in degrees
            Console.WriteLine("Please enter initial angle (in degrees):");
            float theta = float.Parse(Console.ReadLine());

            // let user input initial speed in m/s
            Console.WriteLine("Please enter initial speed (in m/s):");
            float speed = float.Parse(Console.ReadLine());

            // convert initial angle (theta) from degrees to radians
            float thetaRad = (float)(Math.PI / 180) * theta;

            // calculate x and y components of velocity at start (vox & voy)
            float vox = speed * (float)Math.Cos(thetaRad);
            float voy = speed * (float)Math.Sin(thetaRad);

            // calculate time until shell hits apex (t)
            float t = voy / (float)g;

            // calculate height of shell at apex (h)
            float h = voy * voy / (2 * (float)g);

            // calculate horizontal distance travelled by the shell (dx)
            // (assuming equal elevations of launch and target site)
            float dx = vox * 2 * t;

            // output height of shell at apex (h) and horiz. distance travelled (dx)
            Console.WriteLine("The height of the shell at its apex is:" + h.ToString("F3"));
            Console.WriteLine("The distance the shell travels horizontally is:" + dx.ToString("F3"));
            Console.WriteLine();
            }
    }
}
