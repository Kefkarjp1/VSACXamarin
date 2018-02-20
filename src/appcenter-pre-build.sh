#!/usr/bin/env bash
if [ "$APPCENTER_BRANCH" == "QA" ];
then
/usr/libexec/plistbuddy -c "Set :CfBundleDisplayName VSACXamarin.$APPCENTER_BRANCH" "iOS/Info.plist"
fi