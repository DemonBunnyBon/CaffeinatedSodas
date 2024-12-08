using ModSettings;
using System.Reflection;

namespace CaffeinatedSodas
{
    internal class Settings : JsonModSettings
    {
        internal static Settings instance = new Settings();

        [Section("Orange Soda Settings")]

        [Name("Enable Orange Soda")]
        [Description("Gives Orange Soda reduced fatigue buff. [Requires scene reload or transition]")]
        public bool Orange = true;
        [Name("Orange Soda Initial Buff")]
        [Description("Controls how much fatigue drinking orange soda will immediately restore. [Requires scene reload or transition]")]
        [Slider(1,10)]
        public int OrangeInitial = 7;
        [Name("Orange Soda Buff Duration ")]
        [Description("Controls the length of the buff. [Requires scene reload or transition]")]
        [Choice("5 minutes","10 minutes","15 minutes","30 minutes")]
        public int OrangeDuration = 1;




        [Section("Summit Soda Settings")]
        [Name("Enable Summit Soda")]
        [Description("Gives Summit Soda reduced fatigue buff. [Requires scene reload or transition]")]
        public bool Summit = true;
        [Name("Summit Soda Initial Buff")]
        [Description("Controls how much fatigue drinking orange soda will immediately restore. [Requires scene reload or transition]")]
        [Slider(1, 10)]
        public int SummitInitial = 3;
        [Name("Summit Soda Buff Duration")]
        [Description("Controls the length of the buff. [Requires scene reload or transition]")]
        [Choice("5 minutes", "10 minutes", "15 minutes", "30 minutes")]
        public int SummitDuration = 0;



        [Section("Grape Soda Settings")]
        [Name("Enable Grape Soda")]
        [Description("Gives Grape Soda reduced fatigue buff. [Requires scene reload or transition]")]
        public bool Grape = true;
        [Name("Summit Soda Initial Buff")]
        [Description("Controls how much fatigue drinking orange soda will immediately restore. [Requires scene reload or transition]")]
        [Slider(1, 10)]
        public int GrapeInitial = 5;
        [Name("Summit Soda Buff Duration")]
        [Description("Controls the length of the buff. [Requires scene reload or transition]")]
        [Choice("5 minutes", "10 minutes", "15 minutes", "30 minutes")]
        public int GrapeDuration = 1;

        [Section("Reset Settings")]
        [Name("Reset To Default")]
        [Description("Resets all settings to Default. (Confirm required.)")]
        public bool ResetSettings = false;
        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue) => RefreshFields();
        protected override void OnConfirm()
        {
            ApplyReset();
            instance.ResetSettings = false;
            instance.RefreshGUI();
            base.OnConfirm();
        }
        internal static void OnLoad()
        {
            instance.RefreshFields();
        }
        internal void RefreshFields()
        {
            if (Orange == true)
            {

                SetFieldVisible(nameof(OrangeInitial), true);
                SetFieldVisible(nameof(OrangeDuration), true);
            }
            else
            {
                SetFieldVisible(nameof(OrangeInitial), false);
                SetFieldVisible(nameof(OrangeDuration), false);
            }

            if (Summit == true)
            {
                SetFieldVisible(nameof(SummitInitial), true);
                SetFieldVisible(nameof(SummitDuration), true);
            }
            else
            {
                SetFieldVisible(nameof(SummitInitial), false);
                SetFieldVisible(nameof(SummitDuration), false);
            }
            if (Grape == true)
            {
                SetFieldVisible(nameof(GrapeInitial), true);
                SetFieldVisible(nameof(GrapeDuration), true);
            }
            else
            {
                SetFieldVisible(nameof(GrapeInitial), false);
                SetFieldVisible(nameof(GrapeDuration), false);
            }
        }
        public static void ApplyReset()
        {
            if (instance.ResetSettings == true)
            {
                instance.Orange = true;
                instance.Summit = true;
                instance.Grape = true;
                instance.OrangeInitial = 7;
                instance.OrangeDuration = 1;
                instance.SummitInitial = 3;
                instance.SummitDuration = 0;
                instance.GrapeInitial = 5;
                instance.GrapeDuration = 1;
                instance.RefreshFields();
                instance.RefreshGUI();
            }
        }
    }
}