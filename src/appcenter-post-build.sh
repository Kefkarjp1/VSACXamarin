appcenter login --token $VSAC_Token

appcenter test run uitest --app "PLATOTesting/XamarinApp-iOS" --devices 08dd42ea --app-path "$APPCENTER_SOURCE_DIRECTORY/src/ios/bin/iphone/$APPCENTER_BRANCH/VSACXamarin.ios.ipa"  --test-series "master" --locale "en_US" --build-dir "$APPCENTER_SOURCE_DIRECTORY/src/VSACXamarin.UITest.Ios/bin/release"

appcenter logout