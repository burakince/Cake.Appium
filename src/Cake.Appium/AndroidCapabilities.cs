namespace Cake.Appium
{
    /// <summary>
    /// These Capabilities are available only on Android-based drivers (like <see href="https://appium.io/docs/en/drivers/android-uiautomator2/index.html">UiAutomator2</see> for example).
    /// </summary>
    public class AndroidCapabilities : GeneralCapabilities
    {
        /// <summary>
        /// Activity name for the Android activity you want to launch from your package. This often needs to be preceded by a . (e.g., .MainActivity instead of MainActivity)
        /// </summary>
        /// <value>
        /// MainActivity, .Settings
        /// </value>
        [Argument("appActivity")]
        public string AppActivity { get; set; }

        /// <summary>
        /// Java package of the Android app you want to run
        /// </summary>
        /// <value>
        /// com.example.android.myApp, com.android.settings
        /// </value>
        [Argument("appPackage")]
        public string AppPackage { get; set; }

        /// <summary>
        /// Activity name/names, comma separated, for the Android activity you want to wait for
        /// </summary>
        /// <value>
        /// SplashActivity, SplashActivity,OtherActivity, *, *.SplashActivity
        /// </value>
        [Argument("appWaitActivity")]
        public string AppWaitActivity { get; set; }

        /// <summary>
        /// Java package of the Android app you want to wait for
        /// </summary>
        /// <value>
        /// com.example.android.myApp, com.android.settings
        /// </value>
        [Argument("appWaitPackage")]
        public string AppWaitPackage { get; set; }

        /// <summary>
        /// Timeout in milliseconds used to wait for the appWaitActivity to launch (default 20000)
        /// </summary>
        /// <value>
        /// 30000
        /// </value>
        [Argument("appWaitDuration")]
        public string AppWaitDuration { get; set; }

        /// <summary>
        /// Timeout in seconds while waiting for device to become ready
        /// </summary>
        /// <value>
        /// 5
        /// </value>
        [Argument("deviceReadyTimeout")]
        public string DeviceReadyTimeout { get; set; }

        /// <summary>
        /// Fully qualified instrumentation class. Passed to -w in adb shell am instrument -e coverage true -w
        /// </summary>
        /// <value>
        /// com.my.Pkg/com.my.Pkg.instrumentation.MyInstrumentation
        /// </value>
        [Argument("androidCoverage")]
        public string AndroidCoverage { get; set; }

        /// <summary>
        /// A broadcast action implemented by yourself which is used to dump coverage into file system. Passed to -a in adb shell am broadcast -a
        /// </summary>
        /// <value>
        /// com.example.pkg.END_EMMA
        /// </value>
        [Argument("androidCoverageEndIntent")]
        public string AndroidCoverageEndIntent { get; set; }

        /// <summary>
        /// Timeout in seconds used to wait for a device to become ready after booting
        /// </summary>
        /// <value>
        /// e.g., 30
        /// </value>
        [Argument("androidDeviceReadyTimeout")]
        public string AndroidDeviceReadyTimeout { get; set; }

        /// <summary>
        /// Timeout in milliseconds used to wait for an apk to install to the device. Defaults to 90000
        /// </summary>
        /// <value>
        /// e.g., 90000
        /// </value>
        [Argument("androidInstallTimeout")]
        public string AndroidInstallTimeout { get; set; }

        /// <summary>
        /// The name of the directory on the device in which the apk will be push before install. Defaults to /data/local/tmp
        /// </summary>
        /// <value>
        /// e.g. /sdcard/Downloads/
        /// </value>
        [Argument("androidInstallPath")]
        public string AndroidInstallPath { get; set; }

        /// <summary>
        /// Port used to connect to the ADB server (default 5037)
        /// </summary>
        /// <value>
        /// 5037
        /// </value>
        [Argument("adbPort")]
        public string AdbPort { get; set; }

        /// <summary>
        /// systemPort used to connect to <see href="https://github.com/appium/appium-uiautomator2-server">appium-uiautomator2-server</see>, default is 8200 in general and selects one port from 8200 to 8299. When you run tests in parallel, you must adjust the port to avoid conflicts. Read <see href="https://github.com/appium/appium/blob/master/docs/en/advanced-concepts/parallel-tests.md#parallel-android-tests">Parallel Testing Setup Guide</see> for more details.
        /// </summary>
        /// <value>
        /// e.g., 8201
        /// </value>
        [Argument("systemPort")]
        public string SystemPort { get; set; }

        /// <summary>
        /// Optional remote ADB server host
        /// </summary>
        /// <value>
        /// e.g.: 192.168.0.101
        /// </value>
        [Argument("remoteAdbHost")]
        public string RemoteAdbHost { get; set; }

        /// <summary>
        /// Devtools socket name. Needed only when tested app is a Chromium embedding browser. The socket is open by the browser and Chromedriver connects to it as a devtools client.
        /// </summary>
        /// <value>
        /// e.g., chrome_devtools_remote
        /// </value>
        [Argument("androidDeviceSocket")]
        public string AndroidDeviceSocket { get; set; }

        /// <summary>
        /// Name of avd to launch
        /// </summary>
        /// <value>
        /// e.g., api19
        /// </value>
        [Argument("avd")]
        public string Avd { get; set; }

        /// <summary>
        /// How long to wait in milliseconds for an avd to launch and connect to ADB (default 120000)
        /// </summary>
        /// <value>
        /// 300000
        /// </value>
        [Argument("avdLaunchTimeout")]
        public string AvdLaunchTimeout { get; set; }

        /// <summary>
        /// How long to wait in milliseconds for an avd to finish its boot animations (default 120000)
        /// </summary>
        /// <value>
        /// 300000
        /// </value>
        [Argument("avdReadyTimeout")]
        public string AvdReadyTimeout { get; set; }

        /// <summary>
        /// Additional emulator arguments used when launching an avd
        /// </summary>
        /// <value>
        /// e.g., -netfast
        /// </value>
        [Argument("avdArgs")]
        public string AvdArgs { get; set; }

        /// <summary>
        /// Use a custom keystore to sign apks, default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("useKeystore")]
        public string UseKeystore { get; set; }

        /// <summary>
        /// Path to custom keystore, default ~/.android/debug.keystore
        /// </summary>
        /// <value>
        /// e.g., /path/to.keystore
        /// </value>
        [Argument("keystorePath")]
        public string KeystorePath { get; set; }

        /// <summary>
        /// Password for custom keystore
        /// </summary>
        /// <value>
        /// e.g., foo
        /// </value>
        [Argument("keystorePassword")]
        public string KeystorePassword { get; set; }

        /// <summary>
        /// Alias for key
        /// </summary>
        /// <value>
        /// e.g., androiddebugkey
        /// </value>
        [Argument("keyAlias")]
        public string KeyAlias { get; set; }

        /// <summary>
        /// Password for key
        /// </summary>
        /// <value>
        /// e.g., foo
        /// </value>
        [Argument("keyPassword")]
        public string KeyPassword { get; set; }

        /// <summary>
        /// The absolute local path to webdriver executable (if Chromium embedder provides its own webdriver, it should be used instead of original chromedriver bundled with Appium)
        /// </summary>
        /// <value>
        /// /abs/path/to/webdriver
        /// </value>
        [Argument("chromedriverExecutable")]
        public string ChromedriverExecutable { get; set; }

        /// <summary>
        /// Amount of time to wait for Webview context to become active, in ms. Defaults to 2000
        /// </summary>
        /// <value>
        /// e.g. 4
        /// </value>
        [Argument("autoWebviewTimeout")]
        public string AutoWebviewTimeout { get; set; }

        /// <summary>
        /// Intent action which will be used to start activity (default android.intent.action.MAIN)
        /// </summary>
        /// <value>
        /// e.g.android.intent.action.MAIN, android.intent.action.VIEW
        /// </value>
        [Argument("intentAction")]
        public string IntentAction { get; set; }

        /// <summary>
        /// Intent category which will be used to start activity (default android.intent.category.LAUNCHER)
        /// </summary>
        /// <value>
        /// e.g. android.intent.category.LAUNCHER, android.intent.category.APP_CONTACTS
        /// </value>
        [Argument("intentCategory")]
        public string IntentCategory { get; set; }

        /// <summary>
        /// Flags that will be used to start activity (default 0x10200000)
        /// </summary>
        /// <value>
        /// e.g. 0x10200000
        /// </value>
        [Argument("intentFlags")]
        public string IntentFlags { get; set; }

        /// <summary>
        /// Additional intent arguments that will be used to start activity. See <see href="http://developer.android.com/reference/android/content/Intent.html">Intent arguments</see>
        /// </summary>
        /// <value>
        /// e.g. --esn &lt;EXTRA_KEY&gt;, --ez &lt;EXTRA_KEY&gt; &lt;EXTRA_BOOLEAN_VALUE&gt;, etc.
        /// </value>
        [Argument("optionalIntentArguments")]
        public string OptionalIntentArguments { get; set; }

        /// <summary>
        /// Doesn't stop the process of the app under test, before starting the app using adb. If the app under test is created by another anchor app, setting this false, allows the process of the anchor app to be still alive, during the start of the test app using adb. In other words, with dontStopAppOnReset set to true, we will not include the -S flag in the adb shell am start call. With this capability omitted or set to false, we include the -S flag. Default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("dontStopAppOnReset")]
        public string DontStopAppOnReset { get; set; }

        /// <summary>
        /// Enable Unicode input, default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("unicodeKeyboard")]
        public string UnicodeKeyboard { get; set; }

        /// <summary>
        /// Reset keyboard to its original state, after running Unicode tests with unicodeKeyboard capability. Ignored if used alone. Default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("resetKeyboard")]
        public string ResetKeyboard { get; set; }

        /// <summary>
        /// Skip checking and signing of app with debug keys, will work only with UiAutomator and not with selendroid, default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("noSign")]
        public string NoSign { get; set; }

        /// <summary>
        /// Calls the setCompressedLayoutHierarchy() uiautomator function. This capability can speed up test execution, since Accessibility commands will run faster ignoring some elements. The ignored elements will not be findable, which is why this capability has also been implemented as a toggle-able setting as well as a capability. Defaults to false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("ignoreUnimportantViews")]
        public string IgnoreUnimportantViews { get; set; }

        /// <summary>
        /// Disables android watchers that watch for application not responding and application crash, this will reduce cpu usage on android device/emulator. This capability will work only with UiAutomator and not with selendroid, default false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("disableAndroidWatchers")]
        public string DisableAndroidWatchers { get; set; }

        /// <summary>
        /// Allows passing chromeOptions capability for ChromeDriver. For more information see <see href="https://sites.google.com/a/chromium.org/chromedriver/capabilities">chromeOptions</see>
        /// </summary>
        /// <value>
        /// chromeOptions: {args: ['--disable-popup-blocking']}
        /// </value>
        [Argument("chromeOptions")]
        public string ChromeOptions { get; set; }

        /// <summary>
        /// Kill ChromeDriver session when moving to a non-ChromeDriver webview. Defaults to false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("recreateChromeDriverSessions")]
        public string RecreateChromeDriverSessions { get; set; }

        /// <summary>
        /// In a web context, use native (adb) method for taking a screenshot, rather than proxying to ChromeDriver. Defaults to false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("nativeWebScreenshot")]
        public string NativeWebScreenshot { get; set; }

        /// <summary>
        /// The name of the directory on the device in which the screenshot will be put. Defaults to /data/local/tmp
        /// </summary>
        /// <value>
        /// e.g. /sdcard/screenshots/
        /// </value>
        [Argument("androidScreenshotPath")]
        public string AndroidScreenshotPath { get; set; }

        /// <summary>
        /// Have Appium automatically determine which permissions your app requires and grant them to the app on install. Defaults to false
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("autoGrantPermissions")]
        public string AutoGrantPermissions { get; set; }

        /// <summary>
        /// Set the network speed emulation. Specify the maximum network upload and download speeds. Defaults to full
        /// </summary>
        /// <value>
        /// ['full','gsm', 'edge', 'hscsd', 'gprs', 'umts', 'hsdpa', 'lte', 'evdo'] Check <see href="https://developer.android.com/studio/run/emulator-commandline.html">-netspeed option</see> more info about speed emulation for avds
        /// </value>
        [Argument("networkSpeed")]
        public string NetworkSpeed { get; set; }

        /// <summary>
        /// Toggle gps location provider for emulators before starting the session. By default the emulator will have this option enabled or not according to how it has been provisioned.
        /// </summary>
        /// <value>
        /// true or false
        /// </value>
        [Argument("gpsEnabled")]
        public string GpsEnabled { get; set; }

        /// <summary>
        /// Set this capability to true to run the Emulator headless when device display is not needed to be visible. false is the default value. isHeadless is also support for iOS, check XCUITest-specific capabilities.
        /// </summary>
        /// <value>
        /// e.g., true
        /// </value>
        [Argument("isHeadless")]
        public string IsHeadless { get; set; }
    }
}
