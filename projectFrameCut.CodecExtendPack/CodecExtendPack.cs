using projectFrameCut.Render.RenderAPIBase.ClipAndTrack;
using projectFrameCut.Render.RenderAPIBase.EffectAndMixture;
using projectFrameCut.Render.RenderAPIBase.Plugins;
using projectFrameCut.Render.RenderAPIBase.Sources;
using projectFrameCut.Shared;
using System.Text.Json;

namespace projectFrameCut
{
    public partial class CodecExtendPack : projectFrameCut.Render.RenderAPIBase.Plugins.IPluginBase
    {
        public Dictionary<string, Dictionary<string, string>> LocalizationProvider => new Dictionary<string, Dictionary<string, string>> 
        {

        };

        public IReadOnlyDictionary<string, string> Properties => new Dictionary<string, string>
        {
            {"IsFFmpegLibraryProvider","true" }
        };

        public Dictionary<string, Func<IEffect>> EffectProvider => new Dictionary<string, Func<IEffect>> { };

        public Dictionary<string, Func<IEffect>> ContinuousEffectProvider => new Dictionary<string, Func<IEffect>> { };

        public Dictionary<string, Func<IEffect>> BindableArgumentEffectProvider => new();

        public Dictionary<string, IEffectFactory> EffectFactoryProvider => new();

        public Dictionary<string, IEffectFactory> ContinuousEffectFactoryProvider => new();

        public Dictionary<string, IEffectFactory> BindableArgumentEffectFactoryProvider => new();

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

        public IMessagingService MessagingQueue { get; set; }

        public Dictionary<string, Func<Guid, Guid, ITransform>> TransformProvider => new Dictionary<string, Func<Guid, Guid, ITransform>> { };
    }
}
