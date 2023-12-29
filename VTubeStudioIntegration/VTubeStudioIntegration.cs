using System;
using VTubeStudio;

public class VTubeStudioIntegration
{
    static void Main()
    {
        // Initialize VTube Studio SDK
        VTubeStudioSDK.Initialize();

        // Connect to VTube Studio
        VTubeStudioSDK.Connect("127.0.0.1", 8001);  // Adjust IP and port based on your VTube Studio settings

        // Example: Change character emotion to "happy"
        ChangeEmotion("happy");

        // Close connection when done
        VTubeStudioSDK.Disconnect();
    }

    static void ChangeEmotion(string emotion)
    {
        // Example: Send command for changing emotion
        VTubeStudioSDK.SendCommand("set_expression", emotion);

        Console.WriteLine($"Changed emotion to: {emotion}");
    }

    // Function to talk back using gTTS and pygame
    static void TalkBack(string textToSpeak)
    {
        if (!string.IsNullOrEmpty(textToSpeak))
        {
            // Update the path to your Python executable and the path to your script
            string pythonExecutable = @"C:\Users\Kryzr\AppData\Local\Programs\Python\Python38\python.exe";
            string scriptPath = @"E:\AnnyAi\code\main.py";

            // Execute Python script to talk back
            string command = $"\"{pythonExecutable}\" \"{scriptPath}\" \"{textToSpeak}\"";
            System.Diagnostics.Process.Start("cmd", $"/c {command}");
        }
    }
}
