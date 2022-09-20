using Modding;
using System;

namespace GlassKnight
{
    public class GlassKnight : Mod
    {
        private static GlassKnight? _instance;

        internal static GlassKnight Instance
        {
            get
            {
                if (_instance == null)
                {
                    throw new InvalidOperationException($"An instance of {nameof(GlassKnight)} was never constructed");
                }
                return _instance;
            }
        }

        public override string GetVersion() => GetType().Assembly.GetName().Version.ToString();

        public GlassKnight() : base()
        {
            _instance = this;
        }

        // if you need preloads, you will need to implement GetPreloadNames and use the other signature of Initialize.
        public override void Initialize()
        {
            Log("Initializing");

            // put additional initialization logic here

            Log("Initialized");
        }
    }
}
