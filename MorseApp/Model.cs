using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace MorseApp
{
    public class Model
    {
        private WaveFileReader? reader;
        public void Encode()
        {

        }

        public void Decode()
        {
            if (reader is null)
                return;
            byte[] buffer = new byte[reader.Length];
            int read = reader.Read(buffer, 0, buffer.Length);
            var bitsPerSample = reader.WaveFormat.BitsPerSample;
            float[] samples;
            switch(bitsPerSample)
            {
                case 16:
                    samples = Decode16(buffer);
                    break;
                case 24:
                    samples = Decode24(buffer);
                    break;
                case 32:
                    samples = Decode32(buffer);
                    break;  
            }
        }
        public float[] Decode16(byte[] buffer)
        {
            var samples = new float[buffer.Length / 4];
            for (int sampleIndex = 0; sampleIndex < buffer.Length / 4; sampleIndex++)
            {
                var intSampleValue = BitConverter.ToInt16(buffer, sampleIndex);
                samples[sampleIndex] = intSampleValue / 32768f;
            }
            return samples;
        }
        public float[] Decode24(byte[] buffer)
        {
            var samples = new float[buffer.Length / 3];
            for (var i = 0; i < buffer.Length; i += 3)
            {
                samples[i / 3] = (buffer[i] << 8 | buffer[i + 1] << 16 | buffer[i + 2] << 24) / 2147483648f;
            }
            return samples;
        }

        public float[] Decode32(byte[] buffer)
        {
            var samples = new float[buffer.Length / 4];
            for (int sampleIndex = 0; sampleIndex < buffer.Length / 4; sampleIndex++)
            {
                var intSampleValue = BitConverter.ToInt32(buffer, sampleIndex);
                samples[sampleIndex] = intSampleValue / 2147483648f;
            }
            return samples;
        }
        public void OpenFile(string path)
        {
            reader = new WaveFileReader(path);
        }

        public void SaveFile(string path)
        {

        }
        
        public void Register(IObserver observer)
        {
            listeners.Add(observer);
            observer.UpdateState();
        }
        public void Deregister(IObserver observer)
        {
            listeners.Remove(observer);
        }
        private ArrayList listeners = new ArrayList();

        public void UpdateObservers()
        {
            foreach (IObserver observer in listeners)
            {
                observer.UpdateState();
            }
        }
    }
}
