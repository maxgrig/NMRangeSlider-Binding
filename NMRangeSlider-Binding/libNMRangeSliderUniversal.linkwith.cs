using System;
using ObjCRuntime;

[assembly: LinkWith ("libNMRangeSliderUniversal.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64, Frameworks = "CoreGraphics" , SmartLink = true, ForceLoad = true)]
