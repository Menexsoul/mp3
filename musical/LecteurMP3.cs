using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using NAudio.Wave;

namespace musical
{
    internal class LecteurMP3
    {
        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        public void Jouer(string cheminfichier)
        {
            try
            {
                if(outputDevice == null)
                {
                    outputDevice = new WaveOutEvent();
                }

                if(audioFile != null)
                {
                    audioFile.Dispose();
                }

                audioFile = new AudioFileReader(cheminfichier);
                outputDevice.Init(audioFile);
                outputDevice.Play();

                Console.WriteLine($"Lecture en Cours : {cheminfichier}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
        public void Stop()
        {
            if (outputDevice != null)
            {
                outputDevice.Stop();
                Console.WriteLine("Lecture arrétée.");
            }
        }
    }

    
}
