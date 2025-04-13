using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Threading;

namespace CypherChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayIntroductionAudio("Cypher Chatbot.wav");

            Console.Title = "Cypher - Your Cybersecurity Companion";
        }

        static void PlayIntroductionAudio(string filePath)
        {
            try
            {
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), filePath);
                if (File.Exists(fullPath))
                {
                    new SoundPlayer(fullPath).PlaySync();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Audio file not found: {filePath}");
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error playing audio: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}