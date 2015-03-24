using System;
using ObjCRuntime;

[assembly: LinkWith ("libNMRangeSliderUniversal.a", LinkTarget.Simulator | LinkTarget.ArmV7, SmartLink = true, ForceLoad = true)]
