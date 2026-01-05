using projectFrameCut.Render.RenderAPIBase.ClipAndTrack;
using projectFrameCut.Render.RenderAPIBase.EffectAndMixture;
using projectFrameCut.Render.RenderAPIBase.Plugins;
using projectFrameCut.Render.RenderAPIBase.Sources;
using System.Text.Json;

namespace projectFrameCut
{
    public partial class CodecExtendPack : projectFrameCut.Render.RenderAPIBase.Plugins.IPluginBase
    {
        public Dictionary<string, Dictionary<string, string>> LocalizationProvider => new Dictionary<string, Dictionary<string, string>> 
        {
            {
                "en-US",
                new Dictionary<string, string>
                {

                }
            },
            {
                "option",
                new Dictionary<string, string>
                {
                    {"_IsFFmpegLibraryProvider","true" },
                    {"_FFmpegLicenseType","GPLv3" }
                }
            }
        };

        public Dictionary<string, Func<IEffect>> EffectProvider => new Dictionary<string, Func<IEffect>> { };

        public Dictionary<string, Func<IEffect>> ContinuousEffectProvider => new Dictionary<string, Func<IEffect>> { };

        public Dictionary<string, Func<IEffect>> VariableArgumentEffectProvider => new Dictionary<string, Func<IEffect>> { };

        public Dictionary<string, Func<IMixture>> MixtureProvider => new Dictionary<string, Func<IMixture>> { };

        public Dictionary<string, Func<IComputer>> ComputerProvider => new Dictionary<string, Func<IComputer>> { };

        public Dictionary<string, Func<string, string, IClip>> ClipProvider => new Dictionary<string, Func<string, string, IClip>> { };

        public Dictionary<string, Func<string, IVideoSource>> VideoSourceProvider => new Dictionary<string, Func<string, IVideoSource>> { };

        public Dictionary<string, string> Configuration { get => config; set { config = value; } }
        Dictionary<string, string> config = new Dictionary<string, string> { };

        public Dictionary<string, Dictionary<string, string>> ConfigurationDisplayString => new Dictionary<string, Dictionary<string, string>> { };

        public Dictionary<string, Func<string, string, ISoundTrack>> SoundTrackProvider => new Dictionary<string, Func<string, string, ISoundTrack>> { };

        public Dictionary<string, Func<string, IAudioSource>> AudioSourceProvider => new Dictionary<string, Func<string, IAudioSource>> { };

        public Dictionary<string, Func<string, IVideoWriter>> VideoWriterProvider => new Dictionary<string, Func<string, IVideoWriter>> { };

        public IClip ClipCreator(JsonElement element)
        {
            throw new NotImplementedException();
        }

        public ISoundTrack SoundTrackCreator(JsonElement element)
        {
            throw new NotImplementedException();
        }

        bool IPluginBase.OnLoaded(out string FailedReason)
        {
            FailedReason = string.Empty;
            return true;
        }

    }
}
