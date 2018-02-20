namespace Cake.Appium
{
    /// <summary>
    /// These Capabilities are available only on the <see href="https://appium.io/docs/en/drivers/ios-xcuitest/index.html">XCUITest Driver</see> and the deprecated <see href="https://appium.io/docs/en/drivers/ios-uiautomation/index.html">UIAutomation Driver</see>".
    /// </summary>
    public class IOSCapabilities : GeneralCapabilities
    {
        /// <summary>
        /// (Sim-only) Calendar format to set for the iOS Simulator
        /// </summary>
        /// <value>
        /// e.g. gregoria
        /// </value>
        [Argument("calendarFormat")]
        public string CalendarFormat { get; set; }

        /// <summary>
        /// Bundle ID of the app under test. Useful for starting an app on a real device or for using other caps which require the bundle ID during test startup. To run a test on a real device using the bundle ID, you may omit the 'app' capability, but you must provide 'udid'.
        /// </summary>
        /// <value>
        /// e.g. io.appium.TestApp
        /// </value>
        [Argument("bundleId")]
        public string BundleId { get; set; }

        /// <summary>
        /// Amount of time in ms to wait for instruments before assuming it hung and failing the session
        /// </summary>
        /// <value>
        /// e.g. 20000
        /// </value>
        [Argument("launchTimeout")]
        public string LaunchTimeout { get; set; }

        /// <summary>
        /// (Sim-only) Force location services to be either on or off. Default is to keep current sim setting.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("locationServicesEnabled")]
        public string LocationServicesEnabled { get; set; }

        /// <summary>
        /// (Sim-only) Set location services to be authorized or not authorized for app via plist, so that location services alert doesn't pop up. Default is to keep current sim setting. Note that if you use this setting you MUST also use the bundleId capability to send in your app's bundle ID.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("locationServicesAuthorized")]
        public string LocationServicesAuthorized { get; set; }

        /// <summary>
        /// Accept all iOS alerts automatically if they pop up. This includes privacy access permission alerts (e.g., location, contacts, photos). Default is false. Does not work on XCUITest-based tests.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("autoAcceptAlerts")]
        public string AutoAcceptAlerts { get; set; }

        /// <summary>
        /// Dismiss all iOS alerts automatically if they pop up. This includes privacy access permission alerts (e.g., location, contacts, photos). Default is false. Does not work on XCUITest-based tests.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("autoDismissAlerts")]
        public string AutoDismissAlerts { get; set; }

        /// <summary>
        /// Use native intruments lib (ie disable instruments-without-delay).
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("nativeInstrumentsLib")]
        public string NativeInstrumentsLib { get; set; }

        /// <summary>
        /// (Sim-only) Enable "real", non-javascript-based web taps in Safari. Default: false. Warning: depending on viewport size/ratio this might not accurately tap an element
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("nativeWebTap")]
        public string NativeWebTap { get; set; }

        /// <summary>
        /// (Sim-only) (>= 8.1) Initial safari url, default is a local welcome page
        /// </summary>
        /// <value>
        /// e.g. https://www.github.com
        /// </value>
        [Argument("safariInitialUrl")]
        public string SafariInitialUrl { get; set; }

        /// <summary>
        /// (Sim-only) Allow javascript to open new windows in Safari. Default keeps current sim setting
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("safariAllowPopups")]
        public string SafariAllowPopups { get; set; }

        /// <summary>
        /// (Sim-only) Prevent Safari from showing a fraudulent website warning. Default keeps current sim setting.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("safariIgnoreFraudWarning")]
        public string SafariIgnoreFraudWarning { get; set; }

        /// <summary>
        /// (Sim-only) Whether Safari should allow links to open in new windows. Default keeps current sim setting.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("safariOpenLinksInBackground")]
        public string SafariOpenLinksInBackground { get; set; }

        /// <summary>
        /// (Sim-only) Whether to keep keychains (Library/Keychains) when appium session is started/finished
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("keepKeyChains")]
        public string KeepKeyChains { get; set; }

        /// <summary>
        /// Where to look for localizable strings. Default en.lproj
        /// </summary>
        /// <value>
        /// en.lproj
        /// </value>
        [Argument("localizableStringsDir")]
        public string LocalizableStringsDir { get; set; }

        /// <summary>
        /// Arguments to pass to the AUT using instruments
        /// </summary>
        /// <value>
        /// e.g., -myflag
        /// </value>
        [Argument("processArguments")]
        public string ProcessArguments { get; set; }

        /// <summary>
        /// The delay, in ms, between keystrokes sent to an element when typing.
        /// </summary>
        /// <value>
        /// e.g., 100
        /// </value>
        [Argument("interKeyDelay")]
        public string InterKeyDelay { get; set; }

        /// <summary>
        /// Whether to show any logs captured from a device in the appium logs. Default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("showIOSLog")]
        public string ShowIOSLog { get; set; }

        /// <summary>
        /// strategy to use to type test into a test field. Simulator default: oneByOne. Real device default: grouped
        /// </summary>
        /// <value>
        /// oneByOne, grouped or setValue
        /// </value>
        [Argument("sendKeyStrategy")]
        public string SendKeyStrategy { get; set; }

        /// <summary>
        /// Max timeout in sec to wait for a screenshot to be generated. default: 10
        /// </summary>
        /// <value>
        /// e.g., 5
        /// </value>
        [Argument("screenshotWaitTimeout")]
        public string ScreenshotWaitTimeout { get; set; }

        /// <summary>
        /// The ios automation script used to determined if the app has been launched, by default the system wait for the page source not to be empty. The result must be a boolean
        /// </summary>
        /// <value>
        /// e.g. true;, target.elements().length > 0;, $.delay(5000); true;
        /// </value>
        [Argument("waitForAppScript")]
        public string WaitForAppScript { get; set; }

        /// <summary>
        /// Number of times to send connection message to remote debugger, to get webview. Default: 8
        /// </summary>
        /// <value>
        /// e.g., 12
        /// </value>
        [Argument("webviewConnectRetries")]
        public string WebviewConnectRetries { get; set; }

        /// <summary>
        /// The display name of the application under test. Used to automate backgrounding the app in iOS 9+.
        /// </summary>
        /// <value>
        /// e.g., UICatalog
        /// </value>
        [Argument("appName")]
        public string AppName { get; set; }

        /// <summary>
        /// (Sim/Emu-only) Add an SSL certificate to simulator.
        /// </summary>
        /// <value>
        /// e.g. 
        /// -----BEGIN CERTIFICATE-----MIIFWjCCBEKg...
        /// -----END CERTIFICATE-----
        /// </value>
        [Argument("customSSLCert")]
        public string CustomSSLCert { get; set; }

        /// <summary>
        /// (Real device only) Set the time, in ms, to wait for a response from WebKit in a Safari session. Defaults to 5000
        /// </summary>
        /// <value>
        /// e.g., 10000
        /// </value>
        [Argument("webkitResponseTimeout")]
        public string WebkitResponseTimeout { get; set; }
    }
}
