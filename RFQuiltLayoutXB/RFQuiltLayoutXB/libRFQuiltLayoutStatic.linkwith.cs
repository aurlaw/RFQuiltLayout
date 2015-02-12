using System;
using ObjCRuntime;

[assembly: LinkWith ("libRFQuiltLayoutStatic.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, SmartLink = true, ForceLoad = true)]
