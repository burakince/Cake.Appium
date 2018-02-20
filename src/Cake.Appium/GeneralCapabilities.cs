using Cake.Core.Tooling;

namespace Cake.Appium
{
    /// <summary>
    /// These Capabilities span multiple drivers.
    /// </summary>
    public class GeneralCapabilities : ToolSettings
    {
        /// <summary>
        /// Which automation engine to use
        /// </summary>
        /// <value>
        /// Appium (default) or Selendroid or UiAutomator2 or Espresso for Android or XCUITest for iOS or YouiEngine for application built with You.i Engine
        /// </value>
        [Argument("automationName")]
        public string AutomationName { get; set; }

        /// <summary>
        /// Which mobile OS platform to use
        /// </summary>
        /// <value>
        /// iOS, Android, or FirefoxOS
        /// </value>
        [Argument("platformName")]
        public string PlatformName { get; set; }

        /// <summary>
        /// Mobile OS version
        /// </summary>
        /// <value>
        /// e.g., 7.1, 4.4
        /// </value>
        [Argument("platformVersion")]
        public string PlatformVersion { get; set; }

        /// <summary>
        /// The kind of mobile device or emulator to use
        /// </summary>
        /// <value>
        /// iPhone Simulator, iPad Simulator, iPhone Retina 4-inch, Android Emulator, Galaxy S4, etc.... On iOS, this should be one of the valid devices returned by instruments with instruments -s devices. On Android this capability is currently ignored, though it remains required.
        /// </value>
        [Argument("deviceName")]
        public string DeviceName { get; set; }

        /// <summary>
        /// The absolute local path or remote http URL to an .ipa or .apk file, or a .zip containing one of these. Appium will attempt to install this app binary on the appropriate device first. Note that this capability is not required for Android if you specify appPackage and appActivity capabilities (see below). Incompatible with browserName.
        /// </summary>
        /// <value>
        /// /abs/path/to/my.apk or http://myapp.com/app.ipa
        /// </value>
        [Argument("app")]
        public string App { get; set; }

        /// <summary>
        /// Name of mobile web browser to automate. Should be an empty string if automating an app instead.
        /// </summary>
        /// <value>
        /// 'Safari' for iOS and 'Chrome', 'Chromium', or 'Browser' for Android
        /// </value>
        [Argument("browserName")]
        public string BrowserName { get; set; }

        /// <summary>
        /// How long (in seconds) Appium will wait for a new command from the client before assuming the client quit and ending the session
        /// </summary>
        /// <value>
        /// e.g. 60
        /// </value>
        [Argument("newCommandTimeout")]
        public string NewCommandTimeout { get; set; }

        /// <summary>
        /// (Sim/Emu-only) Language to set for the simulator / emulator. On Android, available only on API levels 22 and below
        /// </summary>
        /// <value>
        /// e.g. fr
        /// </value>
        [Argument("language")]
        public string Language { get; set; }

        /// <summary>
        /// (Sim/Emu-only) Locale to set for the simulator / emulator.
        /// </summary>
        /// <value>
        /// e.g. fr_CA
        /// </value>
        [Argument("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Unique device identifier of the connected physical device
        /// </summary>
        /// <value>
        /// e.g. 1ae203187fc012g
        /// </value>
        [Argument("udid")]
        public string UDID { get; set; }

        /// <summary>
        /// (Sim/Emu-only) start in a certain orientation
        /// </summary>
        /// <value>
        /// LANDSCAPE or PORTRAIT
        /// </value>
        [Argument("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// Move directly into Webview context. Default false
        /// </summary>
        /// <value>
        /// true, false
        /// </value>
        [Argument("autoWebview")]
        public string AutoWebview { get; set; }

        /// <summary>
        /// Don't reset app state before this session. See <see href="https://appium.io/docs/en/writing-running-appium/other/reset-strategies/index.html">here</see> for more details
        /// </summary>
        /// <value>
        /// true, false
        /// </value>
        [Argument("noReset")]
        public string NoReset { get; set; }

        /// <summary>
        /// Perform a complete reset. See <see href="https://appium.io/docs/en/writing-running-appium/other/reset-strategies/index.html">here</see> for more details
        /// </summary>
        /// <value>
        /// true, false
        /// </value>
        [Argument("fullReset")]
        public string FullReset { get; set; }

        /// <summary>
        /// Enable or disable the reporting of the timings for various Appium-internal events (e.g., the start and end of each command, etc.). Defaults to false. To enable, use true. The timings are then reported as events property on response to querying the current session. See the <see href="https://appium.io/docs/en/advanced-concepts/event-timings/index.html">event timing docs</see> for the the structure of this response.
        /// </summary>
        /// <value>
        /// e.g., true
        /// </value>
        [Argument("eventTimings")]
        public string EventTimings { get; set; }

        /// <summary>
        /// (Web and webview only) Enable Chromedriver's (on Android) or Safari's (on iOS) performance logging (default false)
        /// </summary>
        /// <value>
        /// true, false
        /// </value>
        [Argument("enablePerformanceLogging")]
        public string EnablePerformanceLogging { get; set; }

        /// <summary>
        /// When a find operation fails, print the current page source. Defaults to false.
        /// </summary>
        /// <value>
        /// e.g., true
        /// </value>
        [Argument("printPageSourceOnFindFailure")]
        public string PrintPageSourceOnFindFailure { get; set; }
    }
}
